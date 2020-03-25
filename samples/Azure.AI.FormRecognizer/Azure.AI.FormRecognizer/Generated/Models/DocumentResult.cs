// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> A set of extracted fields corresponding to the input document. </summary>
    public partial class DocumentResult
    {
        /// <summary> Initializes a new instance of DocumentResult. </summary>
        /// <param name="docType"> Document type. </param>
        /// <param name="pageRange"> First and last page number where the document is found. </param>
        /// <param name="fields"> Dictionary of named field values. </param>
        internal DocumentResult(string docType, IEnumerable<int> pageRange, IReadOnlyDictionary<string, FieldValue> fields)
        {
            if (docType == null)
            {
                throw new ArgumentNullException(nameof(docType));
            }
            if (pageRange == null)
            {
                throw new ArgumentNullException(nameof(pageRange));
            }
            if (fields == null)
            {
                throw new ArgumentNullException(nameof(fields));
            }

            DocType = docType;
            PageRange = pageRange.ToArray();
            Fields = fields;
        }

        /// <summary> Initializes a new instance of DocumentResult. </summary>
        /// <param name="docType"> Document type. </param>
        /// <param name="pageRange"> First and last page number where the document is found. </param>
        /// <param name="fields"> Dictionary of named field values. </param>
        internal DocumentResult(string docType, IReadOnlyList<int> pageRange, IReadOnlyDictionary<string, FieldValue> fields)
        {
            DocType = docType;
            PageRange = pageRange;
            Fields = fields;
        }

        /// <summary> Document type. </summary>
        public string DocType { get; }
        /// <summary> First and last page number where the document is found. </summary>
        public IReadOnlyList<int> PageRange { get; }
        /// <summary> Dictionary of named field values. </summary>
        public IReadOnlyDictionary<string, FieldValue> Fields { get; }
    }
}