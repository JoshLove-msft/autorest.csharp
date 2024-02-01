// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.Collections.Generic;

namespace OpenAI.Models
{
    /// <summary> The CreateEditResponseChoice. </summary>
    public partial class CreateEditResponseChoice
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateEditResponseChoice"/>. </summary>
        /// <param name="text"> The edited result. </param>
        /// <param name="index"> The index of the choice in the list of choices. </param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a
        /// natural stop point or a provided stop sequence, or `length` if the maximum number of tokens
        /// specified in the request was reached.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal CreateEditResponseChoice(string text, long index, CreateEditResponseChoiceFinishReason finishReason)
        {
            ClientUtilities.AssertNotNull(text, nameof(text));

            Text = text;
            Index = index;
            FinishReason = finishReason;
        }

        /// <summary> Initializes a new instance of <see cref="CreateEditResponseChoice"/>. </summary>
        /// <param name="text"> The edited result. </param>
        /// <param name="index"> The index of the choice in the list of choices. </param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a
        /// natural stop point or a provided stop sequence, or `length` if the maximum number of tokens
        /// specified in the request was reached.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateEditResponseChoice(string text, long index, CreateEditResponseChoiceFinishReason finishReason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Index = index;
            FinishReason = finishReason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateEditResponseChoice"/> for deserialization. </summary>
        internal CreateEditResponseChoice()
        {
        }

        /// <summary> The edited result. </summary>
        public string Text { get; }
        /// <summary> The index of the choice in the list of choices. </summary>
        public long Index { get; }
        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a
        /// natural stop point or a provided stop sequence, or `length` if the maximum number of tokens
        /// specified in the request was reached.
        /// </summary>
        public CreateEditResponseChoiceFinishReason FinishReason { get; }
    }
}
