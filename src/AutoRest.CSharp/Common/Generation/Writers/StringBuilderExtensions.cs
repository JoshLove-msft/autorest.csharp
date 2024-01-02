// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;

namespace AutoRest.CSharp.Common.Generation.Writers
{
    //TODO this needs to be moved into shared source in Azure.Core or ClientModel
    internal static class StringBuilderExtensions
    {
        internal static void AppendChildObject(this StringBuilder sb, IPersistableModel<object> childObject, ModelReaderWriterOptions options, bool indentFirstLine = false, int spaces = 2)
        {
            string indent = new string(' ', spaces);
            BinaryData properties = ModelReaderWriter.Write(childObject, options);
            string[] lines = properties.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string indentToUse = !indentFirstLine && i == 0 ? string.Empty : indent;
                sb.AppendLine($"{indentToUse}{lines[i]}");
            }
        }

        internal static void AppendChildObject<T>(this StringBuilder sb, IEnumerable<T> childObjects, ModelReaderWriterOptions options, bool indentFirstLine = false, int spaces = 2)
            where T : IPersistableModel<T>
        {
            string indent = new string(' ', spaces);
            sb.Append($"{indent} [");
            foreach (var child in childObjects)
            {
                BinaryData properties = ModelReaderWriter.Write(child, options);
                // use flattened objects when they are part of an array
                sb.Append(properties.ToString().Replace(Environment.NewLine,""));
                sb.Append(',');
            }

            // remove trailing comma
            sb.Remove(sb.Length - 1, 1);
            sb.AppendLine("]");
        }

        internal static void AppendChildObject<T>(this StringBuilder sb, IDictionary<string, T> childObjects, ModelReaderWriterOptions options, bool indentFirstLine = false, int spaces = 2)
            where T : IPersistableModel<T>
        {
            string indent = new string(' ', spaces);
            sb.Append($"{indent} {{");
            foreach (var kvp in childObjects)
            {
                BinaryData properties = ModelReaderWriter.Write(kvp.Value, options);
                // use flattened objects when they are part of a dictionary
                sb.AppendLine($"{kvp.Key}: {properties.ToString().Replace(Environment.NewLine,"")}");
            }
            sb.AppendLine("}");
        }
    }
}
