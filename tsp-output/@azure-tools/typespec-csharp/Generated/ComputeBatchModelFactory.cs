// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.Compute.Batch
{
    /// <summary> Model factory for models. </summary>
    public static partial class ComputeBatchModelFactory
    {
        /// <summary> Initializes a new instance of BatchApplication. </summary>
        /// <param name="id"> A string that uniquely identifies the application within the Account. </param>
        /// <param name="displayName"> The display name for the application. </param>
        /// <param name="versions"> The list of available versions of the application. </param>
        /// <returns> A new <see cref="Batch.BatchApplication"/> instance for mocking. </returns>
        public static BatchApplication BatchApplication(string id = null, string displayName = null, IEnumerable<string> versions = null)
        {
            versions ??= new List<string>();

            return new BatchApplication(id, displayName, versions?.ToList());
        }

        /// <summary> Initializes a new instance of BatchPool. </summary>
        /// <param name="id"> A string that uniquely identifies the Pool within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case). </param>
        /// <param name="displayName"> The display name for the Pool. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="url"> The URL of the Pool. </param>
        /// <returns> A new <see cref="Batch.BatchPool"/> instance for mocking. </returns>
        public static BatchPool BatchPool(string id = null, string displayName = null, string url = null)
        {
            return new BatchPool(id, displayName, url);
        }
    }
}