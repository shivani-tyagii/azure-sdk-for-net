// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class AutomationPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of AutomationPrivateLinkResourceListResult. </summary>
        internal AutomationPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<AutomationPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of AutomationPrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal AutomationPrivateLinkResourceListResult(IReadOnlyList<AutomationPrivateLinkResource> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<AutomationPrivateLinkResource> Value { get; }
    }
}
