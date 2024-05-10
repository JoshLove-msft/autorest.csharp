// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Property.AdditionalProperties.Models;

namespace _Type.Property.AdditionalProperties.Samples
{
    public partial class Samples_SpreadRecordNonDiscriminatedUnion2
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordNonDiscriminatedUnion2_GetSpreadRecordNonDiscriminatedUnion2_ShortVersion()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            Response response = client.GetSpreadRecordNonDiscriminatedUnion2(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordNonDiscriminatedUnion2_GetSpreadRecordNonDiscriminatedUnion2_ShortVersion_Async()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            Response response = await client.GetSpreadRecordNonDiscriminatedUnion2Async(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordNonDiscriminatedUnion2_GetSpreadRecordNonDiscriminatedUnion2_ShortVersion_Convenience()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            Response<SpreadRecordForNonDiscriminatedUnion2> response = client.GetSpreadRecordNonDiscriminatedUnion2();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordNonDiscriminatedUnion2_GetSpreadRecordNonDiscriminatedUnion2_ShortVersion_Convenience_Async()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            Response<SpreadRecordForNonDiscriminatedUnion2> response = await client.GetSpreadRecordNonDiscriminatedUnion2Async();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordNonDiscriminatedUnion2_GetSpreadRecordNonDiscriminatedUnion2_AllParameters()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            Response response = client.GetSpreadRecordNonDiscriminatedUnion2(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordNonDiscriminatedUnion2_GetSpreadRecordNonDiscriminatedUnion2_AllParameters_Async()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            Response response = await client.GetSpreadRecordNonDiscriminatedUnion2Async(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordNonDiscriminatedUnion2_GetSpreadRecordNonDiscriminatedUnion2_AllParameters_Convenience()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            Response<SpreadRecordForNonDiscriminatedUnion2> response = client.GetSpreadRecordNonDiscriminatedUnion2();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordNonDiscriminatedUnion2_GetSpreadRecordNonDiscriminatedUnion2_AllParameters_Convenience_Async()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            Response<SpreadRecordForNonDiscriminatedUnion2> response = await client.GetSpreadRecordNonDiscriminatedUnion2Async();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordNonDiscriminatedUnion2_Put_ShortVersion()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordNonDiscriminatedUnion2_Put_ShortVersion_Async()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordNonDiscriminatedUnion2_Put_ShortVersion_Convenience()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            SpreadRecordForNonDiscriminatedUnion2 body = new SpreadRecordForNonDiscriminatedUnion2("<name>");
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordNonDiscriminatedUnion2_Put_ShortVersion_Convenience_Async()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            SpreadRecordForNonDiscriminatedUnion2 body = new SpreadRecordForNonDiscriminatedUnion2("<name>");
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordNonDiscriminatedUnion2_Put_AllParameters()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordNonDiscriminatedUnion2_Put_AllParameters_Async()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordNonDiscriminatedUnion2_Put_AllParameters_Convenience()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            SpreadRecordForNonDiscriminatedUnion2 body = new SpreadRecordForNonDiscriminatedUnion2("<name>");
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordNonDiscriminatedUnion2_Put_AllParameters_Convenience_Async()
        {
            SpreadRecordNonDiscriminatedUnion2 client = new AdditionalPropertiesClient().GetSpreadRecordNonDiscriminatedUnion2Client();

            SpreadRecordForNonDiscriminatedUnion2 body = new SpreadRecordForNonDiscriminatedUnion2("<name>");
            Response response = await client.PutAsync(body);
        }
    }
}