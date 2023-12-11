// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Request parameter to train a new custom model. </summary>
    public partial class TrainContent
    {
        /// <summary> Initializes a new instance of <see cref="TrainContent"/>. </summary>
        /// <param name="source"> Source path containing the training documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public TrainContent(string source)
        {
            Argument.AssertNotNull(source, nameof(source));

            Source = source;
        }

        /// <summary> Initializes a new instance of <see cref="TrainContent"/>. </summary>
        /// <param name="source"> Source path containing the training documents. </param>
        /// <param name="sourceFilter"> Filter to apply to the documents in the source path for training. </param>
        /// <param name="useLabelFile"> Use label file for training a model. </param>
        internal TrainContent(string source, TrainSourceFilter sourceFilter, bool? useLabelFile)
        {
            Source = source;
            SourceFilter = sourceFilter;
            UseLabelFile = useLabelFile;
        }

        /// <summary> Source path containing the training documents. </summary>
        public string Source { get; }
        /// <summary> Filter to apply to the documents in the source path for training. </summary>
        public TrainSourceFilter SourceFilter { get; set; }
        /// <summary> Use label file for training a model. </summary>
        public bool? UseLabelFile { get; set; }
    }
}
