// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace SpecialWords
{
    /// <summary> The for. </summary>
    public partial class For
    {
        /// <summary> Initializes a new instance of <see cref="For"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public For(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
    }
}
