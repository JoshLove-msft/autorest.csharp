// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class VaultSecretGroup : IUtf8JsonSerializable, IPersistableModel<VaultSecretGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVault))
            {
                writer.WritePropertyName("sourceVault"u8);
                JsonSerializer.Serialize(writer, SourceVault);
            }
            if (Optional.IsCollectionDefined(VaultCertificates))
            {
                writer.WritePropertyName("vaultCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in VaultCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VaultSecretGroup DeserializeVaultSecretGroup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> sourceVault = default;
            Optional<IList<VaultCertificate>> vaultCertificates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("vaultCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VaultCertificate> array = new List<VaultCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VaultCertificate.DeserializeVaultCertificate(item));
                    }
                    vaultCertificates = array;
                    continue;
                }
            }
            return new VaultSecretGroup(sourceVault, Optional.ToList(vaultCertificates));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SourceVault))
            {
                builder.Append("  sourceVault:");
                AppendChildObject(builder, SourceVault, options, 2);
            }

            if (Optional.IsCollectionDefined(VaultCertificates))
            {
                builder.Append("  vaultCertificates:");
                builder.AppendLine(" [");
                foreach (var item in VaultCertificates)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }
    }
}
