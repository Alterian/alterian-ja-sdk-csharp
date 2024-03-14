# Alterian.JA.Api.ClientsetApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddClientToClientSet**](ClientsetApi.md#addclienttoclientset) | **POST** /AddClientToClientSet | Move a @see(ALClient) from it&#39;s current @see(ALClientSet) to another clientset |
| [**CreateClientSet**](ClientsetApi.md#createclientset) | **POST** /CreateClientSet | Create a new @see(ALClientSet) within the system. |
| [**DeleteClientSet**](ClientsetApi.md#deleteclientset) | **POST** /DeleteClientSet | Remove the given @see(ALClientSet) from the system. This method will fail if any @see(ALClient) exists within the clientset - i.e. the clientset must be empty before deletion |
| [**GetClientSets**](ClientsetApi.md#getclientsets) | **POST** /GetClientSets | List all the clientsets within the system |

<a id="addclienttoclientset"></a>
# **AddClientToClientSet**
> AUTHChangePasswordDefaultResponse AddClientToClientSet (AddClientToClientSetRequest addClientToClientSetRequest)

Move a @see(ALClient) from it's current @see(ALClientSet) to another clientset

Move a @see(ALClient) from it's current @see(ALClientSet) to another clientset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AddClientToClientSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientsetApi(config);
            var addClientToClientSetRequest = new AddClientToClientSetRequest(); // AddClientToClientSetRequest | Move a @see(ALClient) from it's current @see(ALClientSet) to another clientset

            try
            {
                // Move a @see(ALClient) from it's current @see(ALClientSet) to another clientset
                AUTHChangePasswordDefaultResponse result = apiInstance.AddClientToClientSet(addClientToClientSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsetApi.AddClientToClientSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddClientToClientSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Move a @see(ALClient) from it's current @see(ALClientSet) to another clientset
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AddClientToClientSetWithHttpInfo(addClientToClientSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientsetApi.AddClientToClientSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addClientToClientSetRequest** | [**AddClientToClientSetRequest**](AddClientToClientSetRequest.md) | Move a @see(ALClient) from it&#39;s current @see(ALClientSet) to another clientset |  |

### Return type

[**AUTHChangePasswordDefaultResponse**](AUTHChangePasswordDefaultResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createclientset"></a>
# **CreateClientSet**
> CreateClientDefaultResponse CreateClientSet (CreateClientSetRequest createClientSetRequest)

Create a new @see(ALClientSet) within the system.

Create a new @see(ALClientSet) within the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateClientSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientsetApi(config);
            var createClientSetRequest = new CreateClientSetRequest(); // CreateClientSetRequest | Create a new @see(ALClientSet) within the system.

            try
            {
                // Create a new @see(ALClientSet) within the system.
                CreateClientDefaultResponse result = apiInstance.CreateClientSet(createClientSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsetApi.CreateClientSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateClientSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new @see(ALClientSet) within the system.
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateClientSetWithHttpInfo(createClientSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientsetApi.CreateClientSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createClientSetRequest** | [**CreateClientSetRequest**](CreateClientSetRequest.md) | Create a new @see(ALClientSet) within the system. |  |

### Return type

[**CreateClientDefaultResponse**](CreateClientDefaultResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteclientset"></a>
# **DeleteClientSet**
> AUTHChangePasswordDefaultResponse DeleteClientSet (DeleteClientSetRequest deleteClientSetRequest)

Remove the given @see(ALClientSet) from the system. This method will fail if any @see(ALClient) exists within the clientset - i.e. the clientset must be empty before deletion

Remove the given @see(ALClientSet) from the system. This method will fail if any @see(ALClient) exists within the clientset - i.e. the clientset must be empty before deletion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteClientSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientsetApi(config);
            var deleteClientSetRequest = new DeleteClientSetRequest(); // DeleteClientSetRequest | Remove the given @see(ALClientSet) from the system. This method will fail if any @see(ALClient) exists within the clientset - i.e. the clientset must be empty before deletion

            try
            {
                // Remove the given @see(ALClientSet) from the system. This method will fail if any @see(ALClient) exists within the clientset - i.e. the clientset must be empty before deletion
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteClientSet(deleteClientSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsetApi.DeleteClientSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteClientSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove the given @see(ALClientSet) from the system. This method will fail if any @see(ALClient) exists within the clientset - i.e. the clientset must be empty before deletion
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteClientSetWithHttpInfo(deleteClientSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientsetApi.DeleteClientSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteClientSetRequest** | [**DeleteClientSetRequest**](DeleteClientSetRequest.md) | Remove the given @see(ALClientSet) from the system. This method will fail if any @see(ALClient) exists within the clientset - i.e. the clientset must be empty before deletion |  |

### Return type

[**AUTHChangePasswordDefaultResponse**](AUTHChangePasswordDefaultResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getclientsets"></a>
# **GetClientSets**
> GetClientSetsDefaultResponse GetClientSets (GetClientSetsRequest getClientSetsRequest)

List all the clientsets within the system

List all the clientsets within the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetClientSetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientsetApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | List all the clientsets within the system

            try
            {
                // List all the clientsets within the system
                GetClientSetsDefaultResponse result = apiInstance.GetClientSets(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsetApi.GetClientSets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientSetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all the clientsets within the system
    ApiResponse<GetClientSetsDefaultResponse> response = apiInstance.GetClientSetsWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientsetApi.GetClientSetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | List all the clientsets within the system |  |

### Return type

[**GetClientSetsDefaultResponse**](GetClientSetsDefaultResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

