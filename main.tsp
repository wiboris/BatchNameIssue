import "@typespec/rest";
import "@typespec/versioning";
import "@typespec/http";
import "@azure-tools/typespec-azure-core";
import "@typespec/rest";
import "@azure-tools/typespec-client-generator-core";

using TypeSpec.Reflection;
using TypeSpec.Http;
using TypeSpec.Rest;
using TypeSpec.Versioning;
using Azure.Core;
using Azure.Core.Traits;
using Azure.ClientGenerator.Core;

@service({
    title: "Azure Batch",
})
@versioned(Azure.Batch.Versions)
@doc("Azure Batch provides Cloud-scale job scheduling and compute management.")
namespace Azure.Batch;

@doc("The Azure Batch service version.")
enum Versions {
    @doc("API Version 2023-05-01.17.0")
    @useDependency(Azure.Core.Versions.v1_0_Preview_2)
    `2023-05-01.17.0`,
}

interface Applications {
    @doc("Gets information about the specified Application.")
    @route("/applications/{applicationId}")
    @get
    getApplication is RpcOperation<
      {
        @doc("The ID of the Application")
        @path
        applicationId: string;
      },
      BatchApplication,
      {},
      BatchError
    >;
}

interface Pools {
    @doc("Gets information about the specified Pool.")
    @route("/pools/{poolId}")
    @get
    getPool is RpcOperation<
         {
            @doc("The ID of the Pool to get.")
            @path
            poolId: string;
        },
      BatchPool,
      {},
      BatchError
    >;

}
@doc("Contains information about an application in an Azure Batch Account.")
model BatchApplication {
  @doc("A string that uniquely identifies the application within the Account.")
  id: string;

  @doc("The display name for the application.")
  displayName: string;

  @doc("The list of available versions of the application.")
  versions: string[];
}

@doc("A Pool in the Azure Batch service.")
model BatchPool {
    @doc("A string that uniquely identifies the Pool within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case).")
    @visibility("read")
    id?: string;

    @doc("The display name for the Pool. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.")
    @visibility("read")
    displayName?: string;

    @doc("The URL of the Pool.")
    @visibility("read")
    url?: string;
}

@doc("An error response received from the Azure Batch service.")
@error
model BatchError {
    @doc("An identifier for the error. Codes are invariant and are intended to be consumed programmatically.")
    code: string;

    @doc("A message describing the error, intended to be suitable for display in a user interface.")
    message?: ErrorMessage;

    @doc("A collection of key-value pairs containing additional details about the error.")
    values?: BatchErrorDetail[];
}

@doc("An error message received in an Azure Batch error response.")
model ErrorMessage {
    @doc("The language code of the error message.")
    lang?: string;

    @doc("The text of the message.")
    value?: string;
}

@doc("An item of additional information included in an Azure Batch error response.")
model BatchErrorDetail {
    @doc("An identifier specifying the meaning of the Value property.")
    key?: string;

    @doc("The additional information included with the error response.")
    value?: string;
}
