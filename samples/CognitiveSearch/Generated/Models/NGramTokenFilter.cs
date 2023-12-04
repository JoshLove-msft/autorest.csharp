// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary> Generates n-grams of the given size(s). This token filter is implemented using Apache Lucene. </summary>
    public partial class NGramTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="NGramTokenFilter"/>. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public NGramTokenFilter(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            OdataType = "#Microsoft.Azure.Search.NGramTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="NGramTokenFilter"/>. </summary>
        /// <param name="odataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="minGram"> The minimum n-gram length. Default is 1. Must be less than the value of maxGram. </param>
        /// <param name="maxGram"> The maximum n-gram length. Default is 2. </param>
        internal NGramTokenFilter(string odataType, string name, int? minGram, int? maxGram) : base(odataType, name)
        {
            MinGram = minGram;
            MaxGram = maxGram;
            OdataType = odataType ?? "#Microsoft.Azure.Search.NGramTokenFilter";
        }

        /// <summary> The minimum n-gram length. Default is 1. Must be less than the value of maxGram. </summary>
        public int? MinGram { get; set; }
        /// <summary> The maximum n-gram length. Default is 2. </summary>
        public int? MaxGram { get; set; }
    }
}
