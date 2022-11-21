// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Inheritance.Models
{
    /// <summary> The BaseClass. </summary>
    public partial class BaseClass
    {
        /// <summary> Initializes a new instance of BaseClass. </summary>
        public BaseClass()
        {
        }

        /// <summary> Initializes a new instance of BaseClass. </summary>
        /// <param name="baseClassProperty"></param>
        /// <param name="dfeString"> Any object. </param>
        /// <param name="dfeDouble"> Any object. </param>
        /// <param name="dfeBool"> Any object. </param>
        /// <param name="dfeInt"> Any object. </param>
        /// <param name="dfeObject"> Any object. </param>
        /// <param name="dfeListOfObject"> Any object. </param>
        /// <param name="dfeListOfT"></param>
        /// <param name="dfeListOfString"> Any object. </param>
        /// <param name="dfeKeyValuePairs"> Any object. </param>
        internal BaseClass(string baseClassProperty, DataFactoryExpression<string> dfeString, DataFactoryExpression<double> dfeDouble, DataFactoryExpression<bool> dfeBool, DataFactoryExpression<int> dfeInt, DataFactoryExpression<BinaryData> dfeObject, DataFactoryExpression<IList<BinaryData>> dfeListOfObject, DataFactoryExpression<IList<SeparateClass>> dfeListOfT, DataFactoryExpression<IList<string>> dfeListOfString, DataFactoryExpression<IDictionary<string, string>> dfeKeyValuePairs)
        {
            BaseClassProperty = baseClassProperty;
            DfeString = dfeString;
            DfeDouble = dfeDouble;
            DfeBool = dfeBool;
            DfeInt = dfeInt;
            DfeObject = dfeObject;
            DfeListOfObject = dfeListOfObject;
            DfeListOfT = dfeListOfT;
            DfeListOfString = dfeListOfString;
            DfeKeyValuePairs = dfeKeyValuePairs;
        }

        /// <summary> Gets or sets the base class property. </summary>
        public string BaseClassProperty { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<string> DfeString { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<double> DfeDouble { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<bool> DfeBool { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<int> DfeInt { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<BinaryData> DfeObject { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<IList<BinaryData>> DfeListOfObject { get; set; }
        /// <summary> Gets or sets the dfe list of t. </summary>
        public DataFactoryExpression<IList<SeparateClass>> DfeListOfT { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<IList<string>> DfeListOfString { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryExpression<IDictionary<string, string>> DfeKeyValuePairs { get; set; }
    }
}
