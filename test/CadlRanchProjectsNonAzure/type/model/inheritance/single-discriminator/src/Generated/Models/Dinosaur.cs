// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Model.Inheritance.SingleDiscriminator.Models
{
    /// <summary>
    /// Define a base class in the legacy way. Discriminator property is not explicitly defined in the model.
    /// Please note <see cref="Dinosaur"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="TRex"/>.
    /// </summary>
    public abstract partial class Dinosaur
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Dinosaur"/>. </summary>
        /// <param name="size"></param>
        protected Dinosaur(int size)
        {
            Size = size;
        }

        /// <summary> Initializes a new instance of <see cref="Dinosaur"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="size"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Dinosaur(string kind, int size, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Size = size;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Dinosaur"/> for deserialization. </summary>
        internal Dinosaur()
        {
        }

        /// <summary> Discriminator. </summary>
        internal string Kind { get; set; }
        /// <summary> Gets the size. </summary>
        public int Size { get; }
    }
}
