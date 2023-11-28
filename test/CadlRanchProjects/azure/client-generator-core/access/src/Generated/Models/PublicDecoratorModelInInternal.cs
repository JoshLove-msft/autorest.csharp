// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace _Specs_.Azure.ClientGenerator.Core.Access.Models
{
    /// <summary> Used in an internal operation but with public decorator, should be generated and exported. </summary>
    public partial class PublicDecoratorModelInInternal
    {
        /// <summary> Initializes a new instance of <see cref="PublicDecoratorModelInInternal"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal PublicDecoratorModelInInternal(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
    }
}