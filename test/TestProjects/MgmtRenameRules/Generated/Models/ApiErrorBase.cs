// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtRenameRules.Models
{
    /// <summary> Api error base. </summary>
    public partial class ApiErrorBase
    {
        /// <summary> Initializes a new instance of ApiErrorBase. </summary>
        internal ApiErrorBase()
        {
        }

        /// <summary> Initializes a new instance of ApiErrorBase. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="target"> The target of the particular error. </param>
        /// <param name="message"> The error message. </param>
        internal ApiErrorBase(string code, string target, string message)
        {
            Code = code;
            Target = target;
            Message = message;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The target of the particular error. </summary>
        public string Target { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
    }
}
