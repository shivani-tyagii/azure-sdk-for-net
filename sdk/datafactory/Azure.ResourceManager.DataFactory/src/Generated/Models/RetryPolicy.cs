// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execution policy for an activity. </summary>
    public partial class RetryPolicy
    {
        /// <summary> Initializes a new instance of RetryPolicy. </summary>
        public RetryPolicy()
        {
        }

        /// <summary> Initializes a new instance of RetryPolicy. </summary>
        /// <param name="count"> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="intervalInSeconds"> Interval between retries in seconds. Default is 30. </param>
        internal RetryPolicy(DataFactoryElement<int> count, int? intervalInSeconds)
        {
            Count = count;
            IntervalInSeconds = intervalInSeconds;
        }

        /// <summary> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> Count { get; set; }
        /// <summary> Interval between retries in seconds. Default is 30. </summary>
        public int? IntervalInSeconds { get; set; }
    }
}
