// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) TypeSpec Code Generator.

module com.azure.compute.batch {
    requires transitive com.azure.core;

    exports com.azure.compute.batch;
    exports com.azure.compute.batch.models;

    opens com.azure.compute.batch.models to
            com.azure.core,
            com.fasterxml.jackson.databind;
}
