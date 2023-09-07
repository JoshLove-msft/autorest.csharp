// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ModelsTypeSpec.Models
{
    /// <summary> Single base model without any child model. </summary>
    public abstract partial class SingleBase
    {
        /// <summary> Initializes a new instance of SingleBase. </summary>
        /// <param name="size"></param>
        protected SingleBase(int size)
        {
            Size = size;
        }

        /// <summary> Initializes a new instance of SingleBase. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="size"></param>
        internal SingleBase(string kind, int size)
        {
            Kind = kind;
            Size = size;
        }

        /// <summary> Discriminator. </summary>
        internal string Kind { get; set; }
        /// <summary> Gets the size. </summary>
        public int Size { get; }
    }
}