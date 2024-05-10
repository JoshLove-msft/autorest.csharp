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
    public partial class Samples_SpreadModelArray
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModelArray_GetSpreadModelArray_ShortVersion()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            Response response = client.GetSpreadModelArray(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("knownProp")[0].GetProperty("state").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModelArray_GetSpreadModelArray_ShortVersion_Async()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            Response response = await client.GetSpreadModelArrayAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("knownProp")[0].GetProperty("state").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModelArray_GetSpreadModelArray_ShortVersion_Convenience()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            Response<SpreadModelArrayRecord> response = client.GetSpreadModelArray();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModelArray_GetSpreadModelArray_ShortVersion_Convenience_Async()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            Response<SpreadModelArrayRecord> response = await client.GetSpreadModelArrayAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModelArray_GetSpreadModelArray_AllParameters()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            Response response = client.GetSpreadModelArray(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("knownProp")[0].GetProperty("state").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModelArray_GetSpreadModelArray_AllParameters_Async()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            Response response = await client.GetSpreadModelArrayAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("knownProp")[0].GetProperty("state").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModelArray_GetSpreadModelArray_AllParameters_Convenience()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            Response<SpreadModelArrayRecord> response = client.GetSpreadModelArray();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModelArray_GetSpreadModelArray_AllParameters_Convenience_Async()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            Response<SpreadModelArrayRecord> response = await client.GetSpreadModelArrayAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModelArray_Put_ShortVersion()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            using RequestContent content = RequestContent.Create(new
            {
                knownProp = new object[]
            {
new
{
state = "<state>",
}
            },
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModelArray_Put_ShortVersion_Async()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            using RequestContent content = RequestContent.Create(new
            {
                knownProp = new object[]
            {
new
{
state = "<state>",
}
            },
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModelArray_Put_ShortVersion_Convenience()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            SpreadModelArrayRecord body = new SpreadModelArrayRecord(new ModelForRecord[]
            {
new ModelForRecord("<state>")
            });
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModelArray_Put_ShortVersion_Convenience_Async()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            SpreadModelArrayRecord body = new SpreadModelArrayRecord(new ModelForRecord[]
            {
new ModelForRecord("<state>")
            });
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModelArray_Put_AllParameters()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            using RequestContent content = RequestContent.Create(new
            {
                knownProp = new object[]
            {
new
{
state = "<state>",
}
            },
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModelArray_Put_AllParameters_Async()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            using RequestContent content = RequestContent.Create(new
            {
                knownProp = new object[]
            {
new
{
state = "<state>",
}
            },
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadModelArray_Put_AllParameters_Convenience()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            SpreadModelArrayRecord body = new SpreadModelArrayRecord(new ModelForRecord[]
            {
new ModelForRecord("<state>")
            });
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadModelArray_Put_AllParameters_Convenience_Async()
        {
            SpreadModelArray client = new AdditionalPropertiesClient().GetSpreadModelArrayClient();

            SpreadModelArrayRecord body = new SpreadModelArrayRecord(new ModelForRecord[]
            {
new ModelForRecord("<state>")
            });
            Response response = await client.PutAsync(body);
        }
    }
}