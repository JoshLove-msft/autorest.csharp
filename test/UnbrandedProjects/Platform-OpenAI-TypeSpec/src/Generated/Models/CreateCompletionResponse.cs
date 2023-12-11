// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Models
{
    /// <summary>
    /// Represents a completion response from the API. Note: both the streamed and non-streamed response
    /// objects share the same shape (unlike the chat endpoint).
    /// </summary>
    public partial class CreateCompletionResponse
    {
        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponse"/>. </summary>
        /// <param name="id"> A unique identifier for the completion. </param>
        /// <param name="object"> The object type, which is always `text_completion`. </param>
        /// <param name="created"> The Unix timestamp (in seconds) of when the completion was created. </param>
        /// <param name="model"> The model used for the completion. </param>
        /// <param name="choices"> The list of completion choices the model generated for the input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="object"/>, <paramref name="model"/> or <paramref name="choices"/> is null. </exception>
        internal CreateCompletionResponse(string id, string @object, DateTimeOffset created, string model, IEnumerable<CreateCompletionResponseChoice> choices)
        {
            ClientUtilities.AssertNotNull(id, nameof(id));
            ClientUtilities.AssertNotNull(@object, nameof(@object));
            ClientUtilities.AssertNotNull(model, nameof(model));
            ClientUtilities.AssertNotNull(choices, nameof(choices));

            Id = id;
            Object = @object;
            Created = created;
            Model = model;
            Choices = choices.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponse"/>. </summary>
        /// <param name="id"> A unique identifier for the completion. </param>
        /// <param name="object"> The object type, which is always `text_completion`. </param>
        /// <param name="created"> The Unix timestamp (in seconds) of when the completion was created. </param>
        /// <param name="model"> The model used for the completion. </param>
        /// <param name="choices"> The list of completion choices the model generated for the input. </param>
        /// <param name="usage"></param>
        internal CreateCompletionResponse(string id, string @object, DateTimeOffset created, string model, IReadOnlyList<CreateCompletionResponseChoice> choices, CompletionUsage usage)
        {
            Id = id;
            Object = @object;
            Created = created;
            Model = model;
            Choices = choices;
            Usage = usage;
        }

        /// <summary> A unique identifier for the completion. </summary>
        public string Id { get; }
        /// <summary> The object type, which is always `text_completion`. </summary>
        public string Object { get; }
        /// <summary> The Unix timestamp (in seconds) of when the completion was created. </summary>
        public DateTimeOffset Created { get; }
        /// <summary> The model used for the completion. </summary>
        public string Model { get; }
        /// <summary> The list of completion choices the model generated for the input. </summary>
        public IReadOnlyList<CreateCompletionResponseChoice> Choices { get; }
        /// <summary> Gets the usage. </summary>
        public CompletionUsage Usage { get; }
    }
}
