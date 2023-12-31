// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Compute.Batch;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Compute.Batch.Samples
{
    public partial class Samples_BatchClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetApplication_ShortVersion()
        {
            BatchClient client = new BatchClient();

            Response response = client.GetApplication("<applicationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("versions")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetApplication_ShortVersion_Async()
        {
            BatchClient client = new BatchClient();

            Response response = await client.GetApplicationAsync("<applicationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("versions")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetApplication_ShortVersion_Convenience()
        {
            BatchClient client = new BatchClient();

            Response<BatchApplication> response = client.GetApplication("<applicationId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetApplication_ShortVersion_Convenience_Async()
        {
            BatchClient client = new BatchClient();

            Response<BatchApplication> response = await client.GetApplicationAsync("<applicationId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetApplication_AllParameters()
        {
            BatchClient client = new BatchClient();

            Response response = client.GetApplication("<applicationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("versions")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetApplication_AllParameters_Async()
        {
            BatchClient client = new BatchClient();

            Response response = await client.GetApplicationAsync("<applicationId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("versions")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetApplication_AllParameters_Convenience()
        {
            BatchClient client = new BatchClient();

            Response<BatchApplication> response = client.GetApplication("<applicationId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetApplication_AllParameters_Convenience_Async()
        {
            BatchClient client = new BatchClient();

            Response<BatchApplication> response = await client.GetApplicationAsync("<applicationId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPool_ShortVersion()
        {
            BatchClient client = new BatchClient();

            Response response = client.GetPool("<poolId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPool_ShortVersion_Async()
        {
            BatchClient client = new BatchClient();

            Response response = await client.GetPoolAsync("<poolId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPool_ShortVersion_Convenience()
        {
            BatchClient client = new BatchClient();

            Response<BatchPool> response = client.GetPool("<poolId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPool_ShortVersion_Convenience_Async()
        {
            BatchClient client = new BatchClient();

            Response<BatchPool> response = await client.GetPoolAsync("<poolId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPool_AllParameters()
        {
            BatchClient client = new BatchClient();

            Response response = client.GetPool("<poolId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("url").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPool_AllParameters_Async()
        {
            BatchClient client = new BatchClient();

            Response response = await client.GetPoolAsync("<poolId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("url").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPool_AllParameters_Convenience()
        {
            BatchClient client = new BatchClient();

            Response<BatchPool> response = client.GetPool("<poolId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPool_AllParameters_Convenience_Async()
        {
            BatchClient client = new BatchClient();

            Response<BatchPool> response = await client.GetPoolAsync("<poolId>");
        }
    }
}
