// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using Parameters.BodyOptionality.Models;

namespace Parameters.BodyOptionality.Samples
{
    public partial class Samples_OptionalExplicit
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalExplicit_Set_ShortVersion()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            using RequestContent content = null;
            Response response = client.Set(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalExplicit_Set_ShortVersion_Async()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            using RequestContent content = null;
            Response response = await client.SetAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalExplicit_Set_ShortVersion_Convenience()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            Response response = client.Set();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalExplicit_Set_ShortVersion_Convenience_Async()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            Response response = await client.SetAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalExplicit_Set_AllParameters()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.Set(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalExplicit_Set_AllParameters_Async()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.SetAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalExplicit_Set_AllParameters_Convenience()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            BodyModel body = new BodyModel("<name>");
            Response response = client.Set(body: body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalExplicit_Set_AllParameters_Convenience_Async()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            BodyModel body = new BodyModel("<name>");
            Response response = await client.SetAsync(body: body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalExplicit_Omit_ShortVersion()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            using RequestContent content = null;
            Response response = client.Omit(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalExplicit_Omit_ShortVersion_Async()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            using RequestContent content = null;
            Response response = await client.OmitAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalExplicit_Omit_ShortVersion_Convenience()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            Response response = client.Omit();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalExplicit_Omit_ShortVersion_Convenience_Async()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            Response response = await client.OmitAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalExplicit_Omit_AllParameters()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.Omit(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalExplicit_Omit_AllParameters_Async()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.OmitAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalExplicit_Omit_AllParameters_Convenience()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            BodyModel body = new BodyModel("<name>");
            Response response = client.Omit(body: body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalExplicit_Omit_AllParameters_Convenience_Async()
        {
            OptionalExplicit client = new BodyOptionalityClient().GetOptionalExplicitClient();

            BodyModel body = new BodyModel("<name>");
            Response response = await client.OmitAsync(body: body);
        }
    }
}
