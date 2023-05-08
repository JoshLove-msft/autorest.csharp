// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace httpInfrastructure_LowLevel.Samples
{
    public class Samples_HttpRedirectsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head300()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Head300();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head300_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Head300(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head300_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Head300Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head300_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Head300Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get300()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Get300();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get300_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Get300(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get300_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Get300Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get300_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Get300Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head301()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Head301();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head301_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Head301(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head301_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Head301Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head301_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Head301Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get301()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Get301();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get301_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Get301(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get301_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Get301Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get301_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Get301Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put301()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Put301(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put301_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Put301(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put301_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Put301Async(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put301_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Put301Async(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head302()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Head302();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head302_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Head302(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head302_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Head302Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head302_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Head302Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get302()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Get302();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get302_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Get302(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get302_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Get302Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get302_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Get302Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Patch302()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Patch302(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Patch302_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Patch302(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Patch302_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Patch302Async(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Patch302_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Patch302Async(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Post303()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Post303(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Post303_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Post303(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Post303_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Post303Async(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Post303_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Post303Async(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head307()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Head307();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Head307_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Head307(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head307_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Head307Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Head307_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Head307Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get307()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Get307();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get307_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Get307(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get307_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Get307Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get307_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Get307Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Options307()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Options307();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Options307_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = client.Options307(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Options307_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Options307Async();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Options307_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            Response response = await client.Options307Async(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put307()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Put307(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put307_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Put307(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put307_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Put307Async(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put307_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Put307Async(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Patch307()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Patch307(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Patch307_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Patch307(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Patch307_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Patch307Async(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Patch307_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Patch307Async(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Post307()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Post307(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Post307_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Post307(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Post307_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Post307Async(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Post307_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Post307Async(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete307()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Delete307(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete307_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = client.Delete307(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete307_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Delete307Async(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete307_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new HttpRedirectsClient(credential);

            var data = true;

            Response response = await client.Delete307Async(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }
    }
}