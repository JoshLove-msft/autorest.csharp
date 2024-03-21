// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;

namespace FirstTestTypeSpec.Tests
{
    public partial class EnumTestTests : FirstTestTypeSpecTestBase
    {
        public EnumTestTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task EnumTest_GetUnknownValue_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = null;
            EnumTest client = CreateFirstTestTypeSpecClient(endpoint, credential).GetEnumTestClient();

            Response response = await client.GetUnknownValueAsync(null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task EnumTest_GetUnknownValue_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = null;
            EnumTest client = CreateFirstTestTypeSpecClient(endpoint, credential).GetEnumTestClient();

            Response response = await client.GetUnknownValueAsync(null);
        }
    }
}
