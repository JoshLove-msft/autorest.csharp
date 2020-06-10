// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Inheritance.Models
{
    /// <summary> The SomeProperties. </summary>
    internal partial class SomeProperties
    {
        /// <summary> Initializes a new instance of SomeProperties. </summary>
        internal SomeProperties()
        {
        }

        /// <summary> Initializes a new instance of SomeProperties. </summary>
        /// <param name="someProperty"> . </param>
        /// <param name="someOtherProperty"> . </param>
        internal SomeProperties(string someProperty, string someOtherProperty)
        {
            SomeProperty = someProperty;
            SomeOtherProperty = someOtherProperty;
        }

        public string SomeProperty { get; }
        public string SomeOtherProperty { get; }
    }
}
