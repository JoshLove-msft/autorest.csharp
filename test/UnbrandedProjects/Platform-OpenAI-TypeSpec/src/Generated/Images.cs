// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;
using OpenAI.Models;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The Images sub-client. </summary>
    public partial class Images
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Images for mocking. </summary>
        protected Images()
        {
        }

        /// <summary> Initializes a new instance of Images. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal Images(ClientPipeline pipeline, ApiKeyCredential keyCredential, Uri endpoint)
        {
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _endpoint = endpoint;
        }

        /// <summary> Creates an image given a prompt. </summary>
        /// <param name="image"> The <see cref="CreateImageRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        /// <remarks> Create. </remarks>
        public virtual async Task<ClientResult<ImagesResponse>> CreateAsync(CreateImageRequest image)
        {
            Argument.AssertNotNull(image, nameof(image));

            using BinaryContent content = image.ToBinaryContent();
            ClientResult result = await CreateAsync(content, null).ConfigureAwait(false);
            return ClientResult.FromValue(ImagesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Creates an image given a prompt. </summary>
        /// <param name="image"> The <see cref="CreateImageRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        /// <remarks> Create. </remarks>
        public virtual ClientResult<ImagesResponse> Create(CreateImageRequest image)
        {
            Argument.AssertNotNull(image, nameof(image));

            using BinaryContent content = image.ToBinaryContent();
            ClientResult result = Create(content, null);
            return ClientResult.FromValue(ImagesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Creates an image given a prompt
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateAsync(CreateImageRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Creates an image given a prompt
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Create(CreateImageRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Create(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Creates an edited or extended image given an original image and a prompt. </summary>
        /// <param name="image"> The <see cref="CreateImageEditRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        /// <remarks> Create edit. </remarks>
        public virtual async Task<ClientResult<ImagesResponse>> CreateEditAsync(CreateImageEditRequest image)
        {
            Argument.AssertNotNull(image, nameof(image));

            using MultipartFormDataBinaryContent content = image.ToMultipartBinaryBody();
            ClientResult result = await CreateEditAsync(content, content.ContentType, null).ConfigureAwait(false);
            return ClientResult.FromValue(ImagesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Creates an edited or extended image given an original image and a prompt. </summary>
        /// <param name="image"> The <see cref="CreateImageEditRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        /// <remarks> Create edit. </remarks>
        public virtual ClientResult<ImagesResponse> CreateEdit(CreateImageEditRequest image)
        {
            Argument.AssertNotNull(image, nameof(image));

            using MultipartFormDataBinaryContent content = image.ToMultipartBinaryBody();
            ClientResult result = CreateEdit(content, content.ContentType, null);
            return ClientResult.FromValue(ImagesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Creates an edited or extended image given an original image and a prompt.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateEditAsync(CreateImageEditRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The <see cref="string"/> to use. Allowed values: "multipart/form-data". </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateEditAsync(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateEditRequest(content, contentType, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Creates an edited or extended image given an original image and a prompt.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateEdit(CreateImageEditRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The <see cref="string"/> to use. Allowed values: "multipart/form-data". </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateEdit(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateEditRequest(content, contentType, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Creates an edited or extended image given an original image and a prompt. </summary>
        /// <param name="image"> The <see cref="CreateImageVariationRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        /// <remarks> Create variation. </remarks>
        public virtual async Task<ClientResult<ImagesResponse>> CreateVariationAsync(CreateImageVariationRequest image)
        {
            Argument.AssertNotNull(image, nameof(image));

            using MultipartFormDataBinaryContent content = image.ToMultipartBinaryBody();
            ClientResult result = await CreateVariationAsync(content, content.ContentType, null).ConfigureAwait(false);
            return ClientResult.FromValue(ImagesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Creates an edited or extended image given an original image and a prompt. </summary>
        /// <param name="image"> The <see cref="CreateImageVariationRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        /// <remarks> Create variation. </remarks>
        public virtual ClientResult<ImagesResponse> CreateVariation(CreateImageVariationRequest image)
        {
            Argument.AssertNotNull(image, nameof(image));

            using MultipartFormDataBinaryContent content = image.ToMultipartBinaryBody();
            ClientResult result = CreateVariation(content, content.ContentType, null);
            return ClientResult.FromValue(ImagesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Creates an edited or extended image given an original image and a prompt.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateVariationAsync(CreateImageVariationRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The <see cref="string"/> to use. Allowed values: "multipart/form-data". </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateVariationAsync(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateVariationRequest(content, contentType, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Creates an edited or extended image given an original image and a prompt.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateVariation(CreateImageVariationRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The <see cref="string"/> to use. Allowed values: "multipart/form-data". </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateVariation(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateVariationRequest(content, contentType, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateCreateRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/images/generations", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateCreateEditRequest(BinaryContent content, string contentType, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/images/edits", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("content-type", contentType);
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateCreateVariationRequest(BinaryContent content, string contentType, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/images/variations", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("content-type", contentType);
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
