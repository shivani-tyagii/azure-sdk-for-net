// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NetworkAnalytics;

namespace Azure.ResourceManager.NetworkAnalytics.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableNetworkAnalyticsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableNetworkAnalyticsArmClient"/> class for mocking. </summary>
        protected MockableNetworkAnalyticsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNetworkAnalyticsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNetworkAnalyticsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableNetworkAnalyticsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataProductResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataProductResource.CreateResourceIdentifier" /> to create a <see cref="DataProductResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataProductResource" /> object. </returns>
        public virtual DataProductResource GetDataProductResource(ResourceIdentifier id)
        {
            DataProductResource.ValidateResourceId(id);
            return new DataProductResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataProductsCatalogResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataProductsCatalogResource.CreateResourceIdentifier" /> to create a <see cref="DataProductsCatalogResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataProductsCatalogResource" /> object. </returns>
        public virtual DataProductsCatalogResource GetDataProductsCatalogResource(ResourceIdentifier id)
        {
            DataProductsCatalogResource.ValidateResourceId(id);
            return new DataProductsCatalogResource(Client, id);
        }
    }
}
