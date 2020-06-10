// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Report for a custom model training document. </summary>
    public partial class TrainingDocumentInfo
    {
        /// <summary> Initializes a new instance of TrainingDocumentInfo. </summary>
        /// <param name="documentName"> Training document name. </param>
        /// <param name="pages"> Total number of pages trained. </param>
        /// <param name="errors"> List of errors. </param>
        /// <param name="status"> Status of the training operation. </param>
        internal TrainingDocumentInfo(string documentName, int pages, IEnumerable<ErrorInformation> errors, TrainStatus status)
        {
            if (documentName == null)
            {
                throw new ArgumentNullException(nameof(documentName));
            }
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }

            DocumentName = documentName;
            Pages = pages;
            Errors = errors.ToArray();
            Status = status;
        }

        /// <summary> Initializes a new instance of TrainingDocumentInfo. </summary>
        /// <param name="documentName"> Training document name. </param>
        /// <param name="pages"> Total number of pages trained. </param>
        /// <param name="errors"> List of errors. </param>
        /// <param name="status"> Status of the training operation. </param>
        internal TrainingDocumentInfo(string documentName, int pages, IReadOnlyList<ErrorInformation> errors, TrainStatus status)
        {
            DocumentName = documentName;
            Pages = pages;
            Errors = errors ?? new List<ErrorInformation>();
            Status = status;
        }

        /// <summary> Training document name. </summary>
        public string DocumentName { get; }
        /// <summary> Total number of pages trained. </summary>
        public int Pages { get; }
        /// <summary> List of errors. </summary>
        public IReadOnlyList<ErrorInformation> Errors { get; }
        /// <summary> Status of the training operation. </summary>
        public TrainStatus Status { get; }
    }
}
