// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtDiscriminator.Models
{
    internal static partial class DogKindExtensions
    {
        public static string ToSerialString(this DogKind value) => value switch
        {
            DogKind.GermanShepherd => "German Shepherd",
            DogKind.GoldenRetriever => "Golden Retriever",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DogKind value.")
        };

        public static DogKind ToDogKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "German Shepherd")) return DogKind.GermanShepherd;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Golden Retriever")) return DogKind.GoldenRetriever;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DogKind value.");
        }
    }
}
