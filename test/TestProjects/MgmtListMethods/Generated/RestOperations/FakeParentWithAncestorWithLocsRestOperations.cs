// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    internal partial class FakeParentWithAncestorWithLocsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of FakeParentWithAncestorWithLocsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public FakeParentWithAncestorWithLocsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-06-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string fakeName, string fakeParentWithAncestorWithLocName, FakeParentWithAncestorWithLocData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Fake/fakes/", false);
            uri.AppendPath(fakeName, true);
            uri.AppendPath("/fakeParentWithAncestorWithLocs/", false);
            uri.AppendPath(fakeParentWithAncestorWithLocName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update. </summary>
        /// <param name="fakeName"> Name. </param>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/>, <paramref name="fakeParentWithAncestorWithLocName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<FakeParentWithAncestorWithLocData>> CreateOrUpdateAsync(string fakeName, string fakeParentWithAncestorWithLocName, FakeParentWithAncestorWithLocData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(fakeName, fakeParentWithAncestorWithLocName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FakeParentWithAncestorWithLocData.DeserializeFakeParentWithAncestorWithLocData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="fakeName"> Name. </param>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/>, <paramref name="fakeParentWithAncestorWithLocName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response<FakeParentWithAncestorWithLocData> CreateOrUpdate(string fakeName, string fakeParentWithAncestorWithLocName, FakeParentWithAncestorWithLocData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(fakeName, fakeParentWithAncestorWithLocName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FakeParentWithAncestorWithLocData.DeserializeFakeParentWithAncestorWithLocData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string fakeName, string fakeParentWithAncestorWithLocName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Fake/fakes/", false);
            uri.AppendPath(fakeName, true);
            uri.AppendPath("/fakeParentWithAncestorWithLocs/", false);
            uri.AppendPath(fakeParentWithAncestorWithLocName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="fakeName"> Name. </param>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="fakeParentWithAncestorWithLocName"/> is null. </exception>
        public async Task<Response<FakeParentWithAncestorWithLocData>> GetAsync(string fakeName, string fakeParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }

            using var message = CreateGetRequest(fakeName, fakeParentWithAncestorWithLocName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FakeParentWithAncestorWithLocData.DeserializeFakeParentWithAncestorWithLocData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FakeParentWithAncestorWithLocData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="fakeName"> Name. </param>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="fakeParentWithAncestorWithLocName"/> is null. </exception>
        public Response<FakeParentWithAncestorWithLocData> Get(string fakeName, string fakeParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }

            using var message = CreateGetRequest(fakeName, fakeParentWithAncestorWithLocName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FakeParentWithAncestorWithLocData.DeserializeFakeParentWithAncestorWithLocData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FakeParentWithAncestorWithLocData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestRequest(string fakeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Fake/fakes/", false);
            uri.AppendPath(fakeName, true);
            uri.AppendPath("/fakeParentWithAncestorWithLocs", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="fakeName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public async Task<Response<FakeParentWithAncestorWithLocListResult>> GetTestAsync(string fakeName, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var message = CreateGetTestRequest(fakeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="fakeName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public Response<FakeParentWithAncestorWithLocListResult> GetTest(string fakeName, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var message = CreateGetTestRequest(fakeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetBySubscriptionRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Fake/fakeParentWithAncestorWithLocs", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<FakeParentWithAncestorWithLocListResult>> GetBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetBySubscriptionRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FakeParentWithAncestorWithLocListResult> GetBySubscription(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetBySubscriptionRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestByLocationsRequest(string location)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Fake/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/fakeParentWithAncestorWithLocs", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all under the specified subscription for the specified location. </summary>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public async Task<Response<FakeParentWithAncestorWithLocListResult>> GetTestByLocationsAsync(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var message = CreateGetTestByLocationsRequest(location);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all under the specified subscription for the specified location. </summary>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Response<FakeParentWithAncestorWithLocListResult> GetTestByLocations(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var message = CreateGetTestByLocationsRequest(location);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestNextPageRequest(string nextLink, string fakeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="fakeName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="fakeName"/> is null. </exception>
        public async Task<Response<FakeParentWithAncestorWithLocListResult>> GetTestNextPageAsync(string nextLink, string fakeName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var message = CreateGetTestNextPageRequest(nextLink, fakeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="fakeName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="fakeName"/> is null. </exception>
        public Response<FakeParentWithAncestorWithLocListResult> GetTestNextPage(string nextLink, string fakeName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var message = CreateGetTestNextPageRequest(nextLink, fakeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetBySubscriptionNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<FakeParentWithAncestorWithLocListResult>> GetBySubscriptionNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetBySubscriptionNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<FakeParentWithAncestorWithLocListResult> GetBySubscriptionNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetBySubscriptionNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestByLocationsNextPageRequest(string nextLink, string location)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all under the specified subscription for the specified location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="location"/> is null. </exception>
        public async Task<Response<FakeParentWithAncestorWithLocListResult>> GetTestByLocationsNextPageAsync(string nextLink, string location, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var message = CreateGetTestByLocationsNextPageRequest(nextLink, location);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all under the specified subscription for the specified location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="location"/> is null. </exception>
        public Response<FakeParentWithAncestorWithLocListResult> GetTestByLocationsNextPage(string nextLink, string location, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var message = CreateGetTestByLocationsNextPageRequest(nextLink, location);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FakeParentWithAncestorWithLocListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FakeParentWithAncestorWithLocListResult.DeserializeFakeParentWithAncestorWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
