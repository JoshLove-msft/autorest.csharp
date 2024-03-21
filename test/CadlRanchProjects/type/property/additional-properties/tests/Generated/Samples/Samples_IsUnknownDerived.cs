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
    public partial class Samples_IsUnknownDerived
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDerived_GetIsUnknownDerived_ShortVersion()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            Response response = client.GetIsUnknownDerived(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDerived_GetIsUnknownDerived_ShortVersion_Async()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            Response response = await client.GetIsUnknownDerivedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDerived_GetIsUnknownDerived_ShortVersion_Convenience()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            Response<IsUnknownAdditionalPropertiesDerived> response = client.GetIsUnknownDerived();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDerived_GetIsUnknownDerived_ShortVersion_Convenience_Async()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            Response<IsUnknownAdditionalPropertiesDerived> response = await client.GetIsUnknownDerivedAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDerived_GetIsUnknownDerived_AllParameters()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            Response response = client.GetIsUnknownDerived(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDerived_GetIsUnknownDerived_AllParameters_Async()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            Response response = await client.GetIsUnknownDerivedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("age").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDerived_GetIsUnknownDerived_AllParameters_Convenience()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            Response<IsUnknownAdditionalPropertiesDerived> response = client.GetIsUnknownDerived();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDerived_GetIsUnknownDerived_AllParameters_Convenience_Async()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            Response<IsUnknownAdditionalPropertiesDerived> response = await client.GetIsUnknownDerivedAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDerived_Put_ShortVersion()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDerived_Put_ShortVersion_Async()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDerived_Put_ShortVersion_Convenience()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            IsUnknownAdditionalPropertiesDerived body = new IsUnknownAdditionalPropertiesDerived("<name>", 1234);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDerived_Put_ShortVersion_Convenience_Async()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            IsUnknownAdditionalPropertiesDerived body = new IsUnknownAdditionalPropertiesDerived("<name>", 1234);
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDerived_Put_AllParameters()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                age = 123.45F,
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDerived_Put_AllParameters_Async()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                age = 123.45F,
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_IsUnknownDerived_Put_AllParameters_Convenience()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            IsUnknownAdditionalPropertiesDerived body = new IsUnknownAdditionalPropertiesDerived("<name>", 1234)
            {
                Age = 123.45F,
            };
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_IsUnknownDerived_Put_AllParameters_Convenience_Async()
        {
            IsUnknownDerived client = new AdditionalPropertiesClient().GetIsUnknownDerivedClient();

            IsUnknownAdditionalPropertiesDerived body = new IsUnknownAdditionalPropertiesDerived("<name>", 1234)
            {
                Age = 123.45F,
            };
            Response response = await client.PutAsync(body);
        }
    }
}
