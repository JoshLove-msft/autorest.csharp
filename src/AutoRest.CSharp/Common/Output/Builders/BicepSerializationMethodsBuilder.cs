// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions;
using AutoRest.CSharp.Common.Output.Expressions.Statements;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Common.Output.Models;
using AutoRest.CSharp.Common.Output.Models.Types;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Serialization.Bicep;
using AutoRest.CSharp.Output.Models.Shared;
using Azure.Core;
using static AutoRest.CSharp.Common.Output.Models.Snippets;
using Constant = AutoRest.CSharp.Output.Models.Shared.Constant;
using Parameter = AutoRest.CSharp.Output.Models.Shared.Parameter;
using ValidationType = AutoRest.CSharp.Output.Models.Shared.ValidationType;

namespace AutoRest.CSharp.Common.Output.Builders
{
    internal static class BicepSerializationMethodsBuilder
    {
        private const string SerializeBicepMethodName = "SerializeBicep";
        private const string AppendChildObjectMethodName = "AppendChildObject";

        private static readonly Parameter Spaces =
            new Parameter("spaces", null, typeof(int), null, ValidationType.None, null);

        private static readonly Parameter ChildObject = new Parameter("childObject", null, typeof(object),
            null, ValidationType.None, null);

        private static readonly Parameter StringBuilderParameter =
            new Parameter("stringBuilder", null, typeof(StringBuilder), null, ValidationType.None, null);

        private static readonly Parameter IndentFirstLine =
            new Parameter("indentFirstLine", null, typeof(bool), null, ValidationType.None, null);

        public static IEnumerable<Method> BuildBicepSerializationMethods(
            SerializableObjectType model,
            BicepObjectSerialization bicepObject)
        {
            yield return new Method(
                new MethodSignature(
                    SerializeBicepMethodName,
                    null,
                    null,
                    MethodSignatureModifiers.Private,
                    typeof(BinaryData),
                    null,
                    new Parameter[] { KnownParameters.Serializations.Options }),
                WriteSerializeBicep(bicepObject).ToArray());

            yield return new Method(
                new MethodSignature(
                    AppendChildObjectMethodName,
                    null,
                    null,
                    MethodSignatureModifiers.Private,
                    null,
                    null,
                    new Parameter[]
                    {
                        new Parameter("stringBuilder", null, typeof(StringBuilder), null, ValidationType.None,
                            null),
                        ChildObject, KnownParameters.Serializations.Options, Spaces, IndentFirstLine
                    }),
                WriteAppendChildObject().ToArray());
        }

        private static IEnumerable<MethodBodyStatement> WriteSerializeBicep(
            BicepObjectSerialization objectSerialization)
        {
            VariableReference stringBuilder = new VariableReference(typeof(StringBuilder), "builder");
            yield return Declare(stringBuilder, New.Instance(typeof(StringBuilder)));

            var stringBuilderExpression = new StringBuilderExpression(stringBuilder);

            yield return stringBuilderExpression.AppendLine("{");
            yield return EmptyLine;
            var spaces = 2;
            foreach (BicepPropertySerialization property in objectSerialization.Properties)
            {
                foreach (MethodBodyStatement statement in SerializeProperty(stringBuilderExpression, property, spaces))
                {
                    yield return statement;
                }
            }

            if (objectSerialization.NestedProperties.Count > 0)
            {
                yield return stringBuilderExpression.AppendLine("  properties: {");
                spaces += 2;
            }

            foreach (BicepPropertySerialization property in objectSerialization.NestedProperties)
            {
                foreach (MethodBodyStatement statement in SerializeProperty(stringBuilderExpression, property, spaces))
                {
                    yield return statement;
                }
            }

            if (objectSerialization.NestedProperties.Count > 0)
            {
                yield return stringBuilderExpression.AppendLine("  }");
            }

            yield return stringBuilderExpression.AppendLine("}");
            yield return Return(BinaryDataExpression.FromString(stringBuilder.Invoke(nameof(StringBuilderParameter.ToString))));
        }

        private static IEnumerable<MethodBodyStatement> WriteAppendChildObject()
        {
            VariableReference indent = new VariableReference(typeof(string), "indent");
            yield return Declare(indent, New.Instance(typeof(string), Literal(' '), Spaces));

            VariableReference data = new VariableReference(typeof(BinaryData), "data");
            yield return Declare(
                data,
                new InvokeStaticMethodExpression(typeof(ModelReaderWriter), nameof(ModelReaderWriter.Write),
                    new[]
                    {
                        new ParameterReference(ChildObject),
                        new ParameterReference(KnownParameters.Serializations.Options)
                    }));
            VariableReference lines = new VariableReference(typeof(string[]), "lines");
            yield return Declare(
                lines,
                new InvokeInstanceMethodExpression(
                    new InvokeInstanceMethodExpression(data, nameof(ToString), Array.Empty<ValueExpression>(), null,
                        false),
                    nameof(string.Split),
                    new ValueExpression[]
                    {
                        new InvokeInstanceMethodExpression(
                            new TypeReference(typeof(Environment)).Property(nameof(Environment.NewLine)), nameof(string.ToCharArray),
                            Array.Empty<ValueExpression>(), null, false),
                        new TypeReference(typeof(StringSplitOptions)).Property(nameof(StringSplitOptions.RemoveEmptyEntries))
                    },
                    null,
                    false)
            );
            var stringBuilder = new StringBuilderExpression(new ParameterReference(StringBuilderParameter));
            yield return new ForStatement(typeof(string), "i", "line", new ListExpression(typeof(string), lines), out var i, out var line)
            {
                new IfElseStatement(And(Equal(i, new ConstantExpression(new Constant(0, typeof(int)))), Not(new BoolExpression(IndentFirstLine))),
                    stringBuilder.AppendLine(new FormattableStringExpression(" {0}", new ValueExpression[] {line})),
                stringBuilder.AppendLine(new FormattableStringExpression("{0}{1}", indent, line)))
            };
        }

        private static IEnumerable<MethodBodyStatement> SerializeProperty(StringBuilderExpression stringBuilder, BicepPropertySerialization property, int spaces)
        {
            var indent = new string(' ', spaces);
            yield return InvokeOptional.WrapInIsDefined(
                property,
                InvokeOptional.WrapInIsNotEmpty(
                    property,
                new[]
                    {
                        // add in customization hooks
                        stringBuilder.Append($"{indent}{property.SerializedName}:"),
                        SerializeExpression(stringBuilder, property.ValueSerialization, property.Value, spaces)
                    }),
                true);

            yield return EmptyLine;
        }

        private static MethodBodyStatement SerializeExpression(
            StringBuilderExpression stringBuilder,
            BicepSerialization propertyValueSerialization,
            ValueExpression expression,
            int spaces,
            bool isArrayElement = false)
        {
            return propertyValueSerialization switch
            {
                BicepArraySerialization array => SerializeArray(
                    stringBuilder,
                    array,
                    new EnumerableExpression(TypeFactory.GetElementType(array.ImplementationType), expression),
                    spaces),
                BicepDictionarySerialization dictionary => SerializeDictionary(
                    stringBuilder,
                    dictionary,
                    new DictionaryExpression(dictionary.Type.Arguments[0], dictionary.Type.Arguments[1], expression),
                    spaces),
                BicepValueSerialization value => SerializeValue(
                    stringBuilder,
                    value,
                    expression,
                    spaces,
                    isArrayElement),
                _ => throw new NotSupportedException()
            };
        }

        private static MethodBodyStatement SerializeArray(
            StringBuilderExpression stringBuilder,
            BicepArraySerialization arraySerialization,
            EnumerableExpression array,
            int spaces)
        {
            string indent = new string(' ', spaces);
            return new[]
            {
                stringBuilder.AppendLine(" ["),
                new ForeachStatement("item", array, out var item)
                {
                    CheckCollectionItemForNull(stringBuilder, arraySerialization.ValueSerialization, item),
                    SerializeExpression(stringBuilder, arraySerialization.ValueSerialization, item, spaces, true)
                },
                stringBuilder.AppendLine($"{indent}]"),
            };
        }

        private static MethodBodyStatement SerializeDictionary(
            StringBuilderExpression stringBuilder,
            BicepDictionarySerialization dictionarySerialization,
            DictionaryExpression dictionary,
            int spaces)
        {
            var indent = new string(' ', spaces);

            return new[]
            {
                stringBuilder.AppendLine(" {"),
                new ForeachStatement("item", dictionary, out KeyValuePairExpression keyValuePair)
                {
                    stringBuilder.Append(
                        new FormattableStringExpression(
                            $"{indent}{indent}{{0}}: ", keyValuePair.Key)),
                    CheckCollectionItemForNull(stringBuilder, dictionarySerialization.ValueSerialization, keyValuePair.Value),
                    SerializeExpression(stringBuilder, dictionarySerialization.ValueSerialization, keyValuePair.Value, spaces + 2)
                },
                stringBuilder.AppendLine($"{indent}}}")
            };
        }

        private static MethodBodyStatement SerializeValue(
            StringBuilderExpression stringBuilder,
            BicepValueSerialization valueSerialization,
            ValueExpression expression,
            int spaces,
            bool isArrayElement = false)
        {

            var indent = isArrayElement ? new string(' ', spaces + 2) : new string(' ', 1);

            if (valueSerialization.Type.IsFrameworkType)
            {
                return SerializeFrameworkTypeValue(stringBuilder, valueSerialization, expression, indent);
            }

            if (valueSerialization.Type.IsValueType)
            {
                return stringBuilder.AppendLine(new FormattableStringExpression($"{indent}'{{0}}'", expression.Invoke(nameof(ToString))));
            }

            return new[]
            {
                new InvokeStaticMethodStatement(
                    null,
                    AppendChildObjectMethodName,
                    new[]
                    {
                        stringBuilder, expression, KnownParameters.Serializations.Options,
                        new ConstantExpression(new Constant(isArrayElement ? spaces + 2 : spaces, typeof(int))),
                        isArrayElement ? BoolExpression.True : BoolExpression.False
                    })
            };
        }

        private static MethodBodyStatement SerializeFrameworkTypeValue(
            StringBuilderExpression stringBuilder,
            BicepValueSerialization valueSerialization,
            ValueExpression expression,
            string indent)
        {
            var frameworkType = valueSerialization.Type.FrameworkType;
            if (frameworkType == typeof(Nullable<>))
            {
                frameworkType = valueSerialization.Type.Arguments[0].FrameworkType;
            }

            expression = expression.NullableStructValue(valueSerialization.Type);

            if (frameworkType == typeof(Uri))
            {
                return stringBuilder.AppendLine(
                    new FormattableStringExpression($"{indent}'{{0}}'",
                        expression.Property(nameof(Uri.AbsoluteUri))));
            }

            if (frameworkType == typeof(string))
            {
                return stringBuilder.AppendLine(new FormattableStringExpression($"{indent}'{{0}}'", expression));
            }

            if (frameworkType == typeof(int))
            {
                return stringBuilder.AppendLine(new FormattableStringExpression($"{indent}{{0}}", expression));
            }

            if (frameworkType == typeof(TimeSpan))
            {
                return new[]
                {
                    Var(
                        "formattedTimeSpan",
                        new StringExpression(new InvokeStaticMethodExpression(typeof(XmlConvert),
                            nameof(XmlConvert.ToString), new[] { expression })),
                        out var timeSpanVariable),
                    stringBuilder.AppendLine(new FormattableStringExpression(
                        $"{indent}'{{0}}'",
                        timeSpanVariable))
                };
            }

            if (frameworkType == typeof(DateTimeOffset) || frameworkType == typeof(DateTime))
            {
                return new[]
                {
                    Var(
                        "formattedDateTimeString",
                        new StringExpression(new InvokeStaticMethodExpression(typeof(TypeFormatters),
                            nameof(TypeFormatters.ToString), new[] { expression, Literal("o") })),
                        out var dateTimeStringVariable),
                    stringBuilder.AppendLine(new FormattableStringExpression(
                        $"{indent}'{{0}}'",
                        dateTimeStringVariable))
                };
            }

            if (frameworkType == typeof(bool))
            {
                return new[]
                {
                    Var(
                        "boolValue",
                        new StringExpression(new TernaryConditionalOperator(
                            Equal(expression, BoolExpression.True),
                            Literal("true"), Literal("false"))),
                        out var boolVariable),
                    stringBuilder.AppendLine(new FormattableStringExpression($"{indent}{{0}}", boolVariable))
                };
            }

            return stringBuilder.AppendLine(new FormattableStringExpression($"{indent}'{{0}}'", expression.Invoke(nameof(ToString))));
        }

        private static MethodBodyStatement CheckCollectionItemForNull(
            StringBuilderExpression stringBuilder,
            BicepSerialization valueSerialization,
            ValueExpression value)
            => CollectionItemRequiresNullCheckInSerialization(valueSerialization)
                ? new IfStatement(Equal(value, Null)) { stringBuilder.Append("null"), Continue }
                : EmptyStatement;

        private static bool CollectionItemRequiresNullCheckInSerialization(BicepSerialization serialization) =>
            // nullable value type, like int?
            serialization is { IsNullable: true } and BicepValueSerialization { Type.IsValueType: true } ||
            // list or dictionary
            serialization is BicepArraySerialization or BicepDictionarySerialization ||
            // framework reference type, e.g. byte[]
            serialization is BicepValueSerialization { Type: { IsValueType: false, IsFrameworkType: true } };
    }
}
