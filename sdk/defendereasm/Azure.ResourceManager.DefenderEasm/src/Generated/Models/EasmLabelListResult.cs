// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DefenderEasm;

namespace Azure.ResourceManager.DefenderEasm.Models
{
    /// <summary> The list of labels. </summary>
    internal partial class EasmLabelListResult
    {
        /// <summary> Initializes a new instance of EasmLabelListResult. </summary>
        internal EasmLabelListResult()
        {
            Value = new ChangeTrackingList<EasmLabelData>();
        }

        /// <summary> Initializes a new instance of EasmLabelListResult. </summary>
        /// <param name="value"> The list of labels. </param>
        /// <param name="nextLink"> The link used to get the next page of Label list. </param>
        internal EasmLabelListResult(IReadOnlyList<EasmLabelData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of labels. </summary>
        public IReadOnlyList<EasmLabelData> Value { get; }
        /// <summary> The link used to get the next page of Label list. </summary>
        public string NextLink { get; }
    }
}
