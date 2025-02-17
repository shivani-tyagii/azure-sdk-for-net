// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Communication;

namespace Azure.ResourceManager.Communication.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableCommunicationArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableCommunicationArmClient"/> class for mocking. </summary>
        protected MockableCommunicationArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCommunicationArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCommunicationArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableCommunicationArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommunicationServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommunicationServiceResource.CreateResourceIdentifier" /> to create a <see cref="CommunicationServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommunicationServiceResource" /> object. </returns>
        public virtual CommunicationServiceResource GetCommunicationServiceResource(ResourceIdentifier id)
        {
            CommunicationServiceResource.ValidateResourceId(id);
            return new CommunicationServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommunicationDomainResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommunicationDomainResource.CreateResourceIdentifier" /> to create a <see cref="CommunicationDomainResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommunicationDomainResource" /> object. </returns>
        public virtual CommunicationDomainResource GetCommunicationDomainResource(ResourceIdentifier id)
        {
            CommunicationDomainResource.ValidateResourceId(id);
            return new CommunicationDomainResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EmailServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EmailServiceResource.CreateResourceIdentifier" /> to create an <see cref="EmailServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EmailServiceResource" /> object. </returns>
        public virtual EmailServiceResource GetEmailServiceResource(ResourceIdentifier id)
        {
            EmailServiceResource.ValidateResourceId(id);
            return new EmailServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SenderUsernameResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SenderUsernameResource.CreateResourceIdentifier" /> to create a <see cref="SenderUsernameResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SenderUsernameResource" /> object. </returns>
        public virtual SenderUsernameResource GetSenderUsernameResource(ResourceIdentifier id)
        {
            SenderUsernameResource.ValidateResourceId(id);
            return new SenderUsernameResource(Client, id);
        }
    }
}
