// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace NoDocsTypeSpec.Models
{
    public static partial class NoDocsTypeSpecModelFactory
    {
        public static Thing Thing(string name = null, BinaryData requiredUnion = null, ThingRequiredLiteralString requiredLiteralString = default, ThingRequiredLiteralInt requiredLiteralInt = default, ThingRequiredLiteralFloat requiredLiteralFloat = default, bool requiredLiteralBool = default, ThingOptionalLiteralString? optionalLiteralString = null, ThingOptionalLiteralInt? optionalLiteralInt = null, ThingOptionalLiteralFloat? optionalLiteralFloat = null, bool? optionalLiteralBool = null, string requiredBadDescription = null, IEnumerable<int> optionalNullableList = null, IEnumerable<int> requiredNullableList = null)
        {
            optionalNullableList ??= new List<int>();
            requiredNullableList ??= new List<int>();

            return new Thing(
                name,
                requiredUnion,
                requiredLiteralString,
                requiredLiteralInt,
                requiredLiteralFloat,
                requiredLiteralBool,
                optionalLiteralString,
                optionalLiteralInt,
                optionalLiteralFloat,
                optionalLiteralBool,
                requiredBadDescription,
                optionalNullableList?.ToList(),
                requiredNullableList?.ToList(),
                serializedAdditionalRawData: null);
        }

        public static Extension Extension(IEnumerable<Extension> extension = null, sbyte level = default)
        {
            extension ??= new List<Extension>();

            return new Extension(extension?.ToList(), serializedAdditionalRawData: null, level);
        }

        public static ThereLevelExtension ThereLevelExtension(IEnumerable<ThereLevelExtension> extension = null, sbyte level = default)
        {
            extension ??= new List<ThereLevelExtension>();

            return new ThereLevelExtension(extension?.ToList(), serializedAdditionalRawData: null, level);
        }

        public static RoundTripModel RoundTripModel(string requiredString = null, int requiredInt = default, IEnumerable<StringFixedEnum?> requiredCollection = null, IDictionary<string, StringExtensibleEnum?> requiredDictionary = null, Thing requiredModel = null, IntExtensibleEnum? intExtensibleEnum = null, IEnumerable<IntExtensibleEnum> intExtensibleEnumCollection = null, FloatExtensibleEnum? floatExtensibleEnum = null, IEnumerable<FloatExtensibleEnum> floatExtensibleEnumCollection = null, FloatFixedEnum? floatFixedEnum = null, IEnumerable<FloatFixedEnum> floatFixedEnumCollection = null, IntFixedEnum? intFixedEnum = null, IEnumerable<IntFixedEnum> intFixedEnumCollection = null, StringFixedEnum? stringFixedEnum = null, BinaryData requiredUnknown = null, BinaryData optionalUnknown = null, IDictionary<string, BinaryData> requiredRecordUnknown = null, IDictionary<string, BinaryData> optionalRecordUnknown = null, IReadOnlyDictionary<string, BinaryData> readOnlyRequiredRecordUnknown = null, IReadOnlyDictionary<string, BinaryData> readOnlyOptionalRecordUnknown = null, ModelWithRequiredNullableProperties modelWithRequiredNullable = null, IEnumerable<BinaryData> unionList = null)
        {
            requiredCollection ??= new List<StringFixedEnum?>();
            requiredDictionary ??= new Dictionary<string, StringExtensibleEnum?>();
            intExtensibleEnumCollection ??= new List<IntExtensibleEnum>();
            floatExtensibleEnumCollection ??= new List<FloatExtensibleEnum>();
            floatFixedEnumCollection ??= new List<FloatFixedEnum>();
            intFixedEnumCollection ??= new List<IntFixedEnum>();
            requiredRecordUnknown ??= new Dictionary<string, BinaryData>();
            optionalRecordUnknown ??= new Dictionary<string, BinaryData>();
            readOnlyRequiredRecordUnknown ??= new Dictionary<string, BinaryData>();
            readOnlyOptionalRecordUnknown ??= new Dictionary<string, BinaryData>();
            unionList ??= new List<BinaryData>();

            return new RoundTripModel(
                requiredString,
                requiredInt,
                requiredCollection?.ToList(),
                requiredDictionary,
                requiredModel,
                intExtensibleEnum,
                intExtensibleEnumCollection?.ToList(),
                floatExtensibleEnum,
                floatExtensibleEnumCollection?.ToList(),
                floatFixedEnum,
                floatFixedEnumCollection?.ToList(),
                intFixedEnum,
                intFixedEnumCollection?.ToList(),
                stringFixedEnum,
                requiredUnknown,
                optionalUnknown,
                requiredRecordUnknown,
                optionalRecordUnknown,
                readOnlyRequiredRecordUnknown,
                readOnlyOptionalRecordUnknown,
                modelWithRequiredNullable,
                unionList?.ToList(),
                serializedAdditionalRawData: null);
        }
    }
}
