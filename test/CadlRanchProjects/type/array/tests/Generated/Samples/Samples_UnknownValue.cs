// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type._Array;

namespace _Type._Array.Samples
{
    public partial class Samples_UnknownValue
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetUnknownValue_ShortVersion()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response response = client.GetUnknownValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetUnknownValue_ShortVersion_Async()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response response = await client.GetUnknownValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetUnknownValue_ShortVersion_Convenience()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<BinaryData>> response = client.GetUnknownValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetUnknownValue_ShortVersion_Convenience_Async()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<BinaryData>> response = await client.GetUnknownValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetUnknownValue_AllParameters()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response response = client.GetUnknownValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetUnknownValue_AllParameters_Async()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response response = await client.GetUnknownValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetUnknownValue_AllParameters_Convenience()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<BinaryData>> response = client.GetUnknownValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetUnknownValue_AllParameters_Convenience_Async()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<BinaryData>> response = await client.GetUnknownValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_ShortVersion()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new object[]
            {
new object()
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_ShortVersion_Async()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new object[]
            {
new object()
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_ShortVersion_Convenience()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response response = client.Put(new BinaryData[]
            {
BinaryData.FromObjectAsJson(new object())
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_ShortVersion_Convenience_Async()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response response = await client.PutAsync(new BinaryData[]
            {
BinaryData.FromObjectAsJson(new object())
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new object[]
            {
new object()
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new object[]
            {
new object()
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response response = client.Put(new BinaryData[]
            {
BinaryData.FromObjectAsJson(new object())
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            UnknownValue client = new ArrayClient().GetUnknownValueClient(apiVersion: "1.0.0");

            Response response = await client.PutAsync(new BinaryData[]
            {
BinaryData.FromObjectAsJson(new object())
            });
        }
    }
}
