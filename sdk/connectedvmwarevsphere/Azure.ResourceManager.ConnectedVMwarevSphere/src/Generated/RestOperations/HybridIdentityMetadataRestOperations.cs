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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal partial class HybridIdentityMetadataRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of HybridIdentityMetadataRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public HybridIdentityMetadataRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-10-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, HybridIdentityMetadataData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/", false);
            uri.AppendPath(virtualMachineName, true);
            uri.AppendPath("/hybridIdentityMetadata/", false);
            uri.AppendPath(metadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create Or Update HybridIdentityMetadata. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the hybridIdentityMetadata. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/>, <paramref name="metadataName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<HybridIdentityMetadataData>> CreateAsync(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, HybridIdentityMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create Or Update HybridIdentityMetadata. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the hybridIdentityMetadata. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/>, <paramref name="metadataName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<HybridIdentityMetadataData> Create(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, HybridIdentityMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/", false);
            uri.AppendPath(virtualMachineName, true);
            uri.AppendPath("/hybridIdentityMetadata/", false);
            uri.AppendPath(metadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Implements HybridIdentityMetadata GET method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<HybridIdentityMetadataData>> GetAsync(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridIdentityMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Implements HybridIdentityMetadata GET method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<HybridIdentityMetadataData> Get(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridIdentityMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/", false);
            uri.AppendPath(virtualMachineName, true);
            uri.AppendPath("/hybridIdentityMetadata/", false);
            uri.AppendPath(metadataName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Implements HybridIdentityMetadata DELETE method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Implements HybridIdentityMetadata DELETE method. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineName"/> or <paramref name="metadataName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));
            Argument.AssertNotNullOrEmpty(metadataName, nameof(metadataName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualMachineName, metadataName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVmRequest(string subscriptionId, string resourceGroupName, string virtualMachineName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/", false);
            uri.AppendPath(virtualMachineName, true);
            uri.AppendPath("/hybridIdentityMetadata", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<HybridIdentityMetadataList>> ListByVmAsync(string subscriptionId, string resourceGroupName, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var message = CreateListByVmRequest(subscriptionId, resourceGroupName, virtualMachineName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<HybridIdentityMetadataList> ListByVm(string subscriptionId, string resourceGroupName, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var message = CreateListByVmRequest(subscriptionId, resourceGroupName, virtualMachineName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVmNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string virtualMachineName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<HybridIdentityMetadataList>> ListByVmNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var message = CreateListByVmNextPageRequest(nextLink, subscriptionId, resourceGroupName, virtualMachineName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription ID. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="virtualMachineName"> Name of the vm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<HybridIdentityMetadataList> ListByVmNextPage(string nextLink, string subscriptionId, string resourceGroupName, string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var message = CreateListByVmNextPageRequest(nextLink, subscriptionId, resourceGroupName, virtualMachineName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridIdentityMetadataList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HybridIdentityMetadataList.DeserializeHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
