// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing the Workbook data model.
    /// A workbook definition.
    /// </summary>
    public partial class WorkbookData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of WorkbookData. </summary>
        /// <param name="location"> The location. </param>
        public WorkbookData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of WorkbookData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="displayName"> The user-defined name (display name) of the workbook. </param>
        /// <param name="serializedData"> Configuration of this particular workbook. Configuration data is a string containing valid JSON. </param>
        /// <param name="version"> Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData. </param>
        /// <param name="modifiedOn"> Date and time in UTC of the last modification that was made to this workbook definition. </param>
        /// <param name="category"> Workbook category, as defined by the user at creation time. </param>
        /// <param name="userId"> Unique user id of the specific user that owns this workbook. </param>
        /// <param name="sourceId"> ResourceId for a source resource. </param>
        /// <param name="storageUri"> The resourceId to the storage account when bring your own storage is used. </param>
        /// <param name="description"> The description of the workbook. </param>
        /// <param name="revision"> The unique revision id for this workbook definition. </param>
        /// <param name="identity"> Identity used for BYOS. </param>
        /// <param name="kind"> The kind of workbook. Only valid value is shared. </param>
        /// <param name="etag"> Resource etag. </param>
        internal WorkbookData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string displayName, string serializedData, string version, DateTimeOffset? modifiedOn, string category, string userId, string sourceId, Uri storageUri, string description, string revision, ManagedServiceIdentity identity, WorkbookSharedTypeKind? kind, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            DisplayName = displayName;
            SerializedData = serializedData;
            Version = version;
            ModifiedOn = modifiedOn;
            Category = category;
            UserId = userId;
            SourceId = sourceId;
            StorageUri = storageUri;
            Description = description;
            Revision = revision;
            Identity = identity;
            Kind = kind;
            ETag = etag;
        }

        /// <summary> The user-defined name (display name) of the workbook. </summary>
        public string DisplayName { get; set; }
        /// <summary> Configuration of this particular workbook. Configuration data is a string containing valid JSON. </summary>
        public string SerializedData { get; set; }
        /// <summary> Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData. </summary>
        public string Version { get; set; }
        /// <summary> Date and time in UTC of the last modification that was made to this workbook definition. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Workbook category, as defined by the user at creation time. </summary>
        public string Category { get; set; }
        /// <summary> Unique user id of the specific user that owns this workbook. </summary>
        public string UserId { get; }
        /// <summary> ResourceId for a source resource. </summary>
        public string SourceId { get; set; }
        /// <summary> The resourceId to the storage account when bring your own storage is used. </summary>
        public Uri StorageUri { get; set; }
        /// <summary> The description of the workbook. </summary>
        public string Description { get; set; }
        /// <summary> The unique revision id for this workbook definition. </summary>
        public string Revision { get; }
        /// <summary> Identity used for BYOS. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The kind of workbook. Only valid value is shared. </summary>
        public WorkbookSharedTypeKind? Kind { get; set; }
        /// <summary> Resource etag. </summary>
        public ETag? ETag { get; set; }
    }
}
