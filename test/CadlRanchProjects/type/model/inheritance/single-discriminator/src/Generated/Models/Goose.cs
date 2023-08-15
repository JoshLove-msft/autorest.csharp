// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Type.Model.Inheritance.SingleDiscriminator.Models
{
    /// <summary> The second level model in polymorphic single level inheritance. </summary>
    public partial class Goose : Bird
    {
        /// <summary> Initializes a new instance of Goose. </summary>
        /// <param name="wingspan"></param>
        public Goose(int wingspan) : base(wingspan)
        {
            Kind = "goose";
        }

        /// <summary> Initializes a new instance of Goose. </summary>
        /// <param name="kind"></param>
        /// <param name="wingspan"></param>
        internal Goose(string kind, int wingspan) : base(kind, wingspan)
        {
        }
    }
}