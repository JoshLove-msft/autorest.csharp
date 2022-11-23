// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.Models;
using ExactMatchInheritance.Models;

namespace ExactMatchInheritance
{
    /// <summary> A class representing the ExactMatchModel1 data model. </summary>
    public partial class ExactMatchModel1Data : ResourceData
    {
        /// <summary> Initializes a new instance of ExactMatchModel1Data. </summary>
        public ExactMatchModel1Data()
        {
            SupportingUris = new ChangeTrackingList<Uri>();
        }

        /// <summary> Initializes a new instance of ExactMatchModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="new"></param>
        /// <param name="supportingUris"></param>
        /// <param name="type1"></param>
        /// <param name="type2"></param>
        /// <param name="type3"></param>
        /// <param name="type4"></param>
        /// <param name="type5"> Any object. </param>
        /// <param name="type6"> Any object. </param>
        /// <param name="type7"> Any object. </param>
        /// <param name="type8"> Any object. </param>
        /// <param name="type9"> Any object. </param>
        /// <param name="type10"> Any object. </param>
        /// <param name="type11"> Any object. </param>
        /// <param name="type12"> Any object. </param>
        /// <param name="type13"> Any object. </param>
        /// <param name="type14"> Any object. </param>
        /// <param name="type15"> Any object. </param>
        /// <param name="type16"> Any object. </param>
        /// <param name="type17"> Any object. </param>
        internal ExactMatchModel1Data(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string @new, IList<Uri> supportingUris, Type1? type1, Type2? type2, IPAddress type3, object type4, DataFactoryExpression<string> type5, DataFactoryExpression<double> type6, DataFactoryExpression<bool> type7, DataFactoryExpression<int> type8, DataFactoryExpression<IList<BinaryData>> type9, DataFactoryExpression<BinaryData> type10, DataFactoryExpression<IList<SeparateClass>> type11, DataFactoryExpression<IList<string>> type12, DataFactoryExpression<IDictionary<string, string>> type13, DataFactoryExpression<IList<SeparateClass>> type14, DataFactoryExpression<DateTimeOffset> type15, DataFactoryExpression<TimeSpan> type16, DataFactoryExpression<Uri> type17) : base(id, name, resourceType, systemData)
        {
            New = @new;
            SupportingUris = supportingUris;
            Type1 = type1;
            Type2 = type2;
            Type3 = type3;
            Type4 = type4;
            Type5 = type5;
            Type6 = type6;
            Type7 = type7;
            Type8 = type8;
            Type9 = type9;
            Type10 = type10;
            Type11 = type11;
            Type12 = type12;
            Type13 = type13;
            Type14 = type14;
            Type15 = type15;
            Type16 = type16;
            Type17 = type17;
        }

        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
        /// <summary> Gets the supporting uris. </summary>
        public IList<Uri> SupportingUris { get; }
        /// <summary> Gets or sets the type 1. </summary>
        public Type1? Type1 { get; set; }
        /// <summary> Gets or sets the type 2. </summary>
        public Type2? Type2 { get; set; }
        /// <summary> Gets or sets the type 3. </summary>
        public IPAddress Type3 { get; set; }
        /// <summary> Gets or sets the type 4. </summary>
        public object Type4 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<string> Type5 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<double> Type6 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<bool> Type7 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<int> Type8 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<IList<BinaryData>> Type9 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<BinaryData> Type10 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<IList<SeparateClass>> Type11 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<IList<string>> Type12 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<IDictionary<string, string>> Type13 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<IList<SeparateClass>> Type14 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<DateTimeOffset> Type15 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<TimeSpan> Type16 { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<Uri> Type17 { get; set; }
    }
}
