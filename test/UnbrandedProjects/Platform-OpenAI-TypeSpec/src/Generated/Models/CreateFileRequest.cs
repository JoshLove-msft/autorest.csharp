// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The CreateFileRequest. </summary>
    public partial class CreateFileRequest
    {
        /// <summary> Initializes a new instance of <see cref="CreateFileRequest"/>. </summary>
        /// <param name="file">
        /// Name of the [JSON Lines](https://jsonlines.readthedocs.io/en/latest/) file to be uploaded.
        ///
        /// If the `purpose` is set to "fine-tune", the file will be used for fine-tuning.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded documents. Use "fine-tune" for
        /// [fine-tuning](/docs/api-reference/fine-tuning). This allows us to validate the format of the
        /// uploaded file.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/> or <paramref name="purpose"/> is null. </exception>
        public CreateFileRequest(BinaryData file, string purpose)
        {
            ClientUtilities.AssertNotNull(file, nameof(file));
            ClientUtilities.AssertNotNull(purpose, nameof(purpose));

            File = file;
            Purpose = purpose;
        }

        /// <summary>
        /// Name of the [JSON Lines](https://jsonlines.readthedocs.io/en/latest/) file to be uploaded.
        ///
        /// If the `purpose` is set to "fine-tune", the file will be used for fine-tuning.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData File { get; }
        /// <summary>
        /// The intended purpose of the uploaded documents. Use "fine-tune" for
        /// [fine-tuning](/docs/api-reference/fine-tuning). This allows us to validate the format of the
        /// uploaded file.
        /// </summary>
        public string Purpose { get; }
    }
}
