// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections.Generic;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Mgmt.Output;

namespace AutoRest.CSharp.Output.Models.Serialization.Bicep
{
    internal class BicepObjectSerialization
    {
        public BicepObjectSerialization(string name, MgmtObjectType model)
        {
            Type = model.Type;
            var properties = new List<BicepPropertySerialization>(model.Properties.Length);
            foreach (var property in model.Properties)
            {
                properties.Add(new BicepPropertySerialization(property));
            }
            Properties = properties;
            Name = name;

            // select interface model type here
            var modelType = model.IsUnknownDerivedType && model.Inherits is { IsFrameworkType: false, Implementation: { } baseModel } ? baseModel.Type : model.Type;
            IPersistableModelTInterface = new CSharpType(typeof(IPersistableModel<>), modelType);
            // we only need this interface when the model is a struct
            IPersistableModelObjectInterface = model.IsStruct ? (CSharpType)typeof(IPersistableModel<object>) : null;
        }

        public IReadOnlyList<BicepPropertySerialization> Properties { get; }

        public string Name { get; }
        public CSharpType Type { get; }

        /// The interface IPersistableModel{T}
        /// </summary>
        public CSharpType IPersistableModelTInterface { get; }
        /// <summary>
        /// The interface IPersistableModel{object}
        /// </summary>
        public CSharpType? IPersistableModelObjectInterface { get; }
    }
}
