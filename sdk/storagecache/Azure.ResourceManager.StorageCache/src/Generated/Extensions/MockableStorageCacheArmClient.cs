// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.StorageCache;

namespace Azure.ResourceManager.StorageCache.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableStorageCacheArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStorageCacheArmClient"/> class for mocking. </summary>
        protected MockableStorageCacheArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStorageCacheArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStorageCacheArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableStorageCacheArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AmlFileSystemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AmlFileSystemResource.CreateResourceIdentifier" /> to create an <see cref="AmlFileSystemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AmlFileSystemResource" /> object. </returns>
        public virtual AmlFileSystemResource GetAmlFileSystemResource(ResourceIdentifier id)
        {
            AmlFileSystemResource.ValidateResourceId(id);
            return new AmlFileSystemResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageCacheResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageCacheResource.CreateResourceIdentifier" /> to create a <see cref="StorageCacheResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageCacheResource" /> object. </returns>
        public virtual StorageCacheResource GetStorageCacheResource(ResourceIdentifier id)
        {
            StorageCacheResource.ValidateResourceId(id);
            return new StorageCacheResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageTargetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageTargetResource.CreateResourceIdentifier" /> to create a <see cref="StorageTargetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageTargetResource" /> object. </returns>
        public virtual StorageTargetResource GetStorageTargetResource(ResourceIdentifier id)
        {
            StorageTargetResource.ValidateResourceId(id);
            return new StorageTargetResource(Client, id);
        }
    }
}
