// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using AutoRest.CSharp.Common.Generation.Writers;
using AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions;
using AutoRest.CSharp.Common.Output.Expressions.Statements;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Common.Output.Models;
using AutoRest.CSharp.Common.Output.Models.Types;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Serialization.Bicep;
using AutoRest.CSharp.Output.Models.Serialization.Json;
using AutoRest.CSharp.Output.Models.Serialization.Xml;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using Parameter = AutoRest.CSharp.Output.Models.Shared.Parameter;

namespace AutoRest.CSharp.Common.Output.Builders
{
    internal static class BicepSerializationMethodsBuilder
    {
        public static IEnumerable<Method> BuildBicepSerializationMethods(
            SerializableObjectType model,
            BicepObjectSerialization bicepObject)
        {
            yield return new Method
            (
                new MethodSignature(
                    "SerializeBicep",
                    null,
                    null,
                    MethodSignatureModifiers.Private,
                    typeof(BinaryData),
                    null,
                    new Parameter[]{KnownParameters.Serializations.Options}),
                WriteObject(bicepObject).ToArray()
            );
        }

        private static IEnumerable<MethodBodyStatement> WriteObject(BicepObjectSerialization objectSerialization)
        {
            VariableReference sb = new VariableReference(new CSharpType(typeof(StringBuilder)), $"sb");
            var decl = Snippets.Declare(sb, Snippets.New.Instance(new CSharpType(typeof(StringBuilder))));
            yield return decl;
            foreach (BicepPropertySerialization property in objectSerialization.Properties)
            {
                if (property.SerializedType?.IsValueType == true)
                {
                    yield return sb.Invoke(
                        nameof(StringBuilder.AppendLine),
                        new FormattableStringExpression(
                            // TODO only need single quotes for string values?
                            $"{property.SerializedName}: '{{0}}'",
                            new ValueExpression[] { property.Value })).ToStatement();
                }
                else
                {
                    yield return sb.Invoke(
                        nameof(StringBuilderExtensions.AppendChildObject),
                        property.Value,
                        KnownParameters.Serializations.Options)
                        .ToStatement();
                }
            }

            yield return Snippets.Return(BinaryDataExpression.FromString(sb.Invoke(nameof(StringBuilder.ToString))));
        }
    }
}
