// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace body_complex.Models
{
    /// <summary> The Siamese. </summary>
    public partial class Siamese : Cat
    {
        /// <summary> Initializes a new instance of <see cref="Siamese"/>. </summary>
        public Siamese()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Siamese"/>. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="hates"></param>
        /// <param name="breed"></param>
        internal Siamese(int? id, string name, string color, IList<Dog> hates, string breed) : base(id, name, color, hates)
        {
            Breed = breed;
        }

        /// <summary> Gets or sets the breed. </summary>
        public string Breed { get; set; }
    }
}
