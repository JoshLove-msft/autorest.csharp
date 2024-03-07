// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using CognitiveServices.TextAnalytics;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The DocumentError. </summary>
    public partial class DocumentError
    {
        /// <summary> Initializes a new instance of <see cref="DocumentError"/>. </summary>
        /// <param name="id"> Document Id. </param>
        /// <param name="error"> Document Error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="error"/> is null. </exception>
        internal DocumentError(string id, TextAnalyticsError error)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(error, nameof(error));

            Id = id;
            Error = error;
        }

        /// <summary> Document Id. </summary>
        public string Id { get; }
        /// <summary> Document Error. </summary>
        public TextAnalyticsError Error { get; }
    }
}
