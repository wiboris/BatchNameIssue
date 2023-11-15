// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) TypeSpec Code Generator.
package com.azure.compute.batch;

import com.azure.compute.batch.implementation.BatchClientImpl;
import com.azure.compute.batch.models.BatchApplication;
import com.azure.compute.batch.models.BatchPool;
import com.azure.core.annotation.Generated;
import com.azure.core.annotation.ReturnType;
import com.azure.core.annotation.ServiceClient;
import com.azure.core.annotation.ServiceMethod;
import com.azure.core.exception.ClientAuthenticationException;
import com.azure.core.exception.HttpResponseException;
import com.azure.core.exception.ResourceModifiedException;
import com.azure.core.exception.ResourceNotFoundException;
import com.azure.core.http.rest.RequestOptions;
import com.azure.core.http.rest.Response;
import com.azure.core.util.BinaryData;

/** Initializes a new instance of the synchronous BatchClient type. */
@ServiceClient(builder = BatchClientBuilder.class)
public final class BatchClient {

    @Generated private final BatchClientImpl serviceClient;

    /**
     * Initializes an instance of BatchClient class.
     *
     * @param serviceClient the service client implementation.
     */
    @Generated
    BatchClient(BatchClientImpl serviceClient) {
        this.serviceClient = serviceClient;
    }

    /**
     * Gets information about the specified Application.
     *
     * <p><strong>Response Body Schema</strong>
     *
     * <pre>{@code
     * {
     *     id: String (Required)
     *     displayName: String (Required)
     *     versions (Required): [
     *         String (Required)
     *     ]
     * }
     * }</pre>
     *
     * @param applicationId The ID of the Application.
     * @param requestOptions The options to configure the HTTP request before HTTP client sends it.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws ClientAuthenticationException thrown if the request is rejected by server on status code 401.
     * @throws ResourceNotFoundException thrown if the request is rejected by server on status code 404.
     * @throws ResourceModifiedException thrown if the request is rejected by server on status code 409.
     * @return information about the specified Application along with {@link Response}.
     */
    @Generated
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Response<BinaryData> getApplicationWithResponse(String applicationId, RequestOptions requestOptions) {
        return this.serviceClient.getApplicationWithResponse(applicationId, requestOptions);
    }

    /**
     * Gets information about the specified Pool.
     *
     * <p><strong>Response Body Schema</strong>
     *
     * <pre>{@code
     * {
     *     id: String (Optional)
     *     displayName: String (Optional)
     *     url: String (Optional)
     * }
     * }</pre>
     *
     * @param poolId The ID of the Pool to get.
     * @param requestOptions The options to configure the HTTP request before HTTP client sends it.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws ClientAuthenticationException thrown if the request is rejected by server on status code 401.
     * @throws ResourceNotFoundException thrown if the request is rejected by server on status code 404.
     * @throws ResourceModifiedException thrown if the request is rejected by server on status code 409.
     * @return information about the specified Pool along with {@link Response}.
     */
    @Generated
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Response<BinaryData> getPoolWithResponse(String poolId, RequestOptions requestOptions) {
        return this.serviceClient.getPoolWithResponse(poolId, requestOptions);
    }

    /**
     * Gets information about the specified Application.
     *
     * @param applicationId The ID of the Application.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws ClientAuthenticationException thrown if the request is rejected by server on status code 401.
     * @throws ResourceNotFoundException thrown if the request is rejected by server on status code 404.
     * @throws ResourceModifiedException thrown if the request is rejected by server on status code 409.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return information about the specified Application.
     */
    @Generated
    @ServiceMethod(returns = ReturnType.SINGLE)
    public BatchApplication getApplication(String applicationId) {
        // Generated convenience method for getApplicationWithResponse
        RequestOptions requestOptions = new RequestOptions();
        return getApplicationWithResponse(applicationId, requestOptions).getValue().toObject(BatchApplication.class);
    }

    /**
     * Gets information about the specified Pool.
     *
     * @param poolId The ID of the Pool to get.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws ClientAuthenticationException thrown if the request is rejected by server on status code 401.
     * @throws ResourceNotFoundException thrown if the request is rejected by server on status code 404.
     * @throws ResourceModifiedException thrown if the request is rejected by server on status code 409.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return information about the specified Pool.
     */
    @Generated
    @ServiceMethod(returns = ReturnType.SINGLE)
    public BatchPool getPool(String poolId) {
        // Generated convenience method for getPoolWithResponse
        RequestOptions requestOptions = new RequestOptions();
        return getPoolWithResponse(poolId, requestOptions).getValue().toObject(BatchPool.class);
    }
}