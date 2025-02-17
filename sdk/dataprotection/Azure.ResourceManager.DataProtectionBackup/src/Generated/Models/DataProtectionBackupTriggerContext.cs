// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Trigger context
    /// Please note <see cref="DataProtectionBackupTriggerContext"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AdhocBasedBackupTriggerContext"/> and <see cref="ScheduleBasedBackupTriggerContext"/>.
    /// </summary>
    public abstract partial class DataProtectionBackupTriggerContext
    {
        /// <summary> Initializes a new instance of DataProtectionBackupTriggerContext. </summary>
        protected DataProtectionBackupTriggerContext()
        {
        }

        /// <summary> Initializes a new instance of DataProtectionBackupTriggerContext. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal DataProtectionBackupTriggerContext(string objectType)
        {
            ObjectType = objectType;
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}
