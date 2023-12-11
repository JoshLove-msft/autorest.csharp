// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateEditResponse
    {
        internal static CreateEditResponse DeserializeCreateEditResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CreateEditResponseObject @object = default;
            DateTimeOffset created = default;
            IReadOnlyList<CreateEditResponseChoice> choices = default;
            CompletionUsage usage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("object"u8))
                {
                    @object = new CreateEditResponseObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    created = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("choices"u8))
                {
                    List<CreateEditResponseChoice> array = new List<CreateEditResponseChoice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CreateEditResponseChoice.DeserializeCreateEditResponseChoice(item));
                    }
                    choices = array;
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    usage = CompletionUsage.DeserializeCompletionUsage(property.Value);
                    continue;
                }
            }
            return new CreateEditResponse(@object, created, choices, usage);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateEditResponse FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateEditResponse(document.RootElement);
        }
    }
}
