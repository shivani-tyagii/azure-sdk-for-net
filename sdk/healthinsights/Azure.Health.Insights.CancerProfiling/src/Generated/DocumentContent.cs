// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> The content of the patient document. </summary>
    public partial class DocumentContent
    {
        /// <summary> Initializes a new instance of DocumentContent. </summary>
        /// <param name="sourceType">
        /// The type of the content's source.
        /// In case the source type is 'inline', the content is given as a string (for instance, text).
        /// In case the source type is 'reference', the content is given as a URI.
        /// </param>
        /// <param name="value"> The content of the document, given either inline (as a string) or as a reference (URI). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentContent(DocumentContentSourceType sourceType, string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            SourceType = sourceType;
            Value = value;
        }

        /// <summary>
        /// The type of the content's source.
        /// In case the source type is 'inline', the content is given as a string (for instance, text).
        /// In case the source type is 'reference', the content is given as a URI.
        /// </summary>
        public DocumentContentSourceType SourceType { get; }
        /// <summary> The content of the document, given either inline (as a string) or as a reference (URI). </summary>
        public string Value { get; }
    }
}
