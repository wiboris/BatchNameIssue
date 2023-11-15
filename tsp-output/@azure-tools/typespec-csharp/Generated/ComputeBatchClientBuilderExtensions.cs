// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Compute.Batch;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="BatchClient"/> to client builder. </summary>
    public static partial class ComputeBatchClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="BatchClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        public static IAzureClientBuilder<BatchClient, BatchClientOptions> AddBatchClient<TBuilder>(this TBuilder builder)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<BatchClient, BatchClientOptions>((options) => new BatchClient(options));
        }

        /// <summary> Registers a <see cref="BatchClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<BatchClient, BatchClientOptions> AddBatchClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<BatchClient, BatchClientOptions>(configuration);
        }
    }
}
