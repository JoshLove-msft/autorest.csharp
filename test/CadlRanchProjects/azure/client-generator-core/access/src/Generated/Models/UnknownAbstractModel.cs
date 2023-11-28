// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace _Specs_.Azure.ClientGenerator.Core.Access.Models
{
    /// <summary> Unknown version of AbstractModel. </summary>
    internal partial class UnknownAbstractModel : AbstractModel
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAbstractModel"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal UnknownAbstractModel(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAbstractModel"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"></param>
        internal UnknownAbstractModel(string kind, string name) : base(kind, name)
        {
        }
    }
}