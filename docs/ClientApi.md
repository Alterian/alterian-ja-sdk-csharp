# Alterian.JA.Api.ClientApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateClient**](ClientApi.md#createclient) | **POST** /CreateClient | Create a new @see(ALClient), with it&#39;s own unique database and set of users. |
| [**CreateClientEx**](ClientApi.md#createclientex) | **POST** /CreateClientEx | Create a new @see(ALClient), with it&#39;s own unique database and set of users.             Additionally creates an example user / group with relevant permissions to design campaign factory campaigns. |
| [**DeleteClient**](ClientApi.md#deleteclient) | **POST** /DeleteClient | Deletes a @see(ALClient).  Removes the client&#39;s database.  Note that the client must be disabled with @see(DisableClient) before calling this. |
| [**DisableClient**](ClientApi.md#disableclient) | **POST** /DisableClient | Mark an individual @see(ALClient) as disabled. Disabled clients will not allow users to log on, documents will not be processed etc. |
| [**EnableClient**](ClientApi.md#enableclient) | **POST** /EnableClient | Mark an individual @see(ALClient) as enabled. Enabled clients allow users to log on, documents will be processed etc. |
| [**GetClientSettings**](ClientApi.md#getclientsettings) | **POST** /GetClientSettings | Returns the settings for the specified Client |
| [**GetClients**](ClientApi.md#getclients) | **POST** /GetClients | Return a list of clients that match the supplied (optional) filters. |
| [**GetCurrentClient**](ClientApi.md#getcurrentclient) | **POST** /GetCurrentClient | Returns back the client for the current token |
| [**UpdateClientSettings**](ClientApi.md#updateclientsettings) | **POST** /UpdateClientSettings | Updates the settings for the specified client. Warning: This API deletes any settings not included in the update request |

<a id="createclient"></a>
# **CreateClient**
> CreateClientDefaultResponse CreateClient (CreateClientRequest createClientRequest)

Create a new @see(ALClient), with it's own unique database and set of users.

Create a new @see(ALClient), with it's own unique database and set of users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var createClientRequest = new CreateClientRequest(); // CreateClientRequest | Create a new @see(ALClient), with it's own unique database and set of users.

            try
            {
                // Create a new @see(ALClient), with it's own unique database and set of users.
                CreateClientDefaultResponse result = apiInstance.CreateClient(createClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.CreateClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new @see(ALClient), with it's own unique database and set of users.
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateClientWithHttpInfo(createClientRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.CreateClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createClientRequest** | [**CreateClientRequest**](CreateClientRequest.md) | Create a new @see(ALClient), with it&#39;s own unique database and set of users. |  |

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

<a id="createclientex"></a>
# **CreateClientEx**
> CreateClientDefaultResponse CreateClientEx (CreateClientRequest createClientRequest)

Create a new @see(ALClient), with it's own unique database and set of users.             Additionally creates an example user / group with relevant permissions to design campaign factory campaigns.

Create a new @see(ALClient), with it's own unique database and set of users.             Additionally creates an example user / group with relevant permissions to design campaign factory campaigns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateClientExExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var createClientRequest = new CreateClientRequest(); // CreateClientRequest | Create a new @see(ALClient), with it's own unique database and set of users.             Additionally creates an example user / group with relevant permissions to design campaign factory campaigns.

            try
            {
                // Create a new @see(ALClient), with it's own unique database and set of users.             Additionally creates an example user / group with relevant permissions to design campaign factory campaigns.
                CreateClientDefaultResponse result = apiInstance.CreateClientEx(createClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.CreateClientEx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateClientExWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new @see(ALClient), with it's own unique database and set of users.             Additionally creates an example user / group with relevant permissions to design campaign factory campaigns.
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateClientExWithHttpInfo(createClientRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.CreateClientExWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createClientRequest** | [**CreateClientRequest**](CreateClientRequest.md) | Create a new @see(ALClient), with it&#39;s own unique database and set of users.             Additionally creates an example user / group with relevant permissions to design campaign factory campaigns. |  |

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

<a id="deleteclient"></a>
# **DeleteClient**
> AUTHChangePasswordDefaultResponse DeleteClient (DeleteClientRequest deleteClientRequest)

Deletes a @see(ALClient).  Removes the client's database.  Note that the client must be disabled with @see(DisableClient) before calling this.

Deletes a @see(ALClient).  Removes the client's database.  Note that the client must be disabled with @see(DisableClient) before calling this.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var deleteClientRequest = new DeleteClientRequest(); // DeleteClientRequest | Deletes a @see(ALClient).  Removes the client's database.  Note that the client must be disabled with @see(DisableClient) before calling this.

            try
            {
                // Deletes a @see(ALClient).  Removes the client's database.  Note that the client must be disabled with @see(DisableClient) before calling this.
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteClient(deleteClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.DeleteClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a @see(ALClient).  Removes the client's database.  Note that the client must be disabled with @see(DisableClient) before calling this.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteClientWithHttpInfo(deleteClientRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.DeleteClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteClientRequest** | [**DeleteClientRequest**](DeleteClientRequest.md) | Deletes a @see(ALClient).  Removes the client&#39;s database.  Note that the client must be disabled with @see(DisableClient) before calling this. |  |

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

<a id="disableclient"></a>
# **DisableClient**
> AUTHChangePasswordDefaultResponse DisableClient (DisableClientRequest disableClientRequest)

Mark an individual @see(ALClient) as disabled. Disabled clients will not allow users to log on, documents will not be processed etc.

Mark an individual @see(ALClient) as disabled. Disabled clients will not allow users to log on, documents will not be processed etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DisableClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var disableClientRequest = new DisableClientRequest(); // DisableClientRequest | Mark an individual @see(ALClient) as disabled. Disabled clients will not allow users to log on, documents will not be processed etc.

            try
            {
                // Mark an individual @see(ALClient) as disabled. Disabled clients will not allow users to log on, documents will not be processed etc.
                AUTHChangePasswordDefaultResponse result = apiInstance.DisableClient(disableClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.DisableClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark an individual @see(ALClient) as disabled. Disabled clients will not allow users to log on, documents will not be processed etc.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DisableClientWithHttpInfo(disableClientRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.DisableClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **disableClientRequest** | [**DisableClientRequest**](DisableClientRequest.md) | Mark an individual @see(ALClient) as disabled. Disabled clients will not allow users to log on, documents will not be processed etc. |  |

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

<a id="enableclient"></a>
# **EnableClient**
> AUTHChangePasswordDefaultResponse EnableClient (DisableClientRequest disableClientRequest)

Mark an individual @see(ALClient) as enabled. Enabled clients allow users to log on, documents will be processed etc.

Mark an individual @see(ALClient) as enabled. Enabled clients allow users to log on, documents will be processed etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EnableClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var disableClientRequest = new DisableClientRequest(); // DisableClientRequest | Mark an individual @see(ALClient) as enabled. Enabled clients allow users to log on, documents will be processed etc.

            try
            {
                // Mark an individual @see(ALClient) as enabled. Enabled clients allow users to log on, documents will be processed etc.
                AUTHChangePasswordDefaultResponse result = apiInstance.EnableClient(disableClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.EnableClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark an individual @see(ALClient) as enabled. Enabled clients allow users to log on, documents will be processed etc.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EnableClientWithHttpInfo(disableClientRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.EnableClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **disableClientRequest** | [**DisableClientRequest**](DisableClientRequest.md) | Mark an individual @see(ALClient) as enabled. Enabled clients allow users to log on, documents will be processed etc. |  |

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

<a id="getclientsettings"></a>
# **GetClientSettings**
> GetClientSettingsDefaultResponse GetClientSettings (GetClientSettingsRequest getClientSettingsRequest)

Returns the settings for the specified Client

Returns the settings for the specified Client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetClientSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var getClientSettingsRequest = new GetClientSettingsRequest(); // GetClientSettingsRequest | Returns the settings for the specified Client

            try
            {
                // Returns the settings for the specified Client
                GetClientSettingsDefaultResponse result = apiInstance.GetClientSettings(getClientSettingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.GetClientSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the settings for the specified Client
    ApiResponse<GetClientSettingsDefaultResponse> response = apiInstance.GetClientSettingsWithHttpInfo(getClientSettingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.GetClientSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSettingsRequest** | [**GetClientSettingsRequest**](GetClientSettingsRequest.md) | Returns the settings for the specified Client |  |

### Return type

[**GetClientSettingsDefaultResponse**](GetClientSettingsDefaultResponse.md)

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

<a id="getclients"></a>
# **GetClients**
> GetBrandsDefaultResponse GetClients (GetClientsRequest getClientsRequest)

Return a list of clients that match the supplied (optional) filters.

Return a list of clients that match the supplied (optional) filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var getClientsRequest = new GetClientsRequest(); // GetClientsRequest | Return a list of clients that match the supplied (optional) filters.

            try
            {
                // Return a list of clients that match the supplied (optional) filters.
                GetBrandsDefaultResponse result = apiInstance.GetClients(getClientsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.GetClients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return a list of clients that match the supplied (optional) filters.
    ApiResponse<GetBrandsDefaultResponse> response = apiInstance.GetClientsWithHttpInfo(getClientsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.GetClientsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientsRequest** | [**GetClientsRequest**](GetClientsRequest.md) | Return a list of clients that match the supplied (optional) filters. |  |

### Return type

[**GetBrandsDefaultResponse**](GetBrandsDefaultResponse.md)

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

<a id="getcurrentclient"></a>
# **GetCurrentClient**
> GetCurrentClientDefaultResponse GetCurrentClient ()

Returns back the client for the current token

Returns back the client for the current token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetCurrentClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);

            try
            {
                // Returns back the client for the current token
                GetCurrentClientDefaultResponse result = apiInstance.GetCurrentClient();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.GetCurrentClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back the client for the current token
    ApiResponse<GetCurrentClientDefaultResponse> response = apiInstance.GetCurrentClientWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.GetCurrentClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetCurrentClientDefaultResponse**](GetCurrentClientDefaultResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateclientsettings"></a>
# **UpdateClientSettings**
> AUTHChangePasswordDefaultResponse UpdateClientSettings (UpdateClientSettingsRequest updateClientSettingsRequest)

Updates the settings for the specified client. Warning: This API deletes any settings not included in the update request

Updates the settings for the specified client. Warning: This API deletes any settings not included in the update request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateClientSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ClientApi(config);
            var updateClientSettingsRequest = new UpdateClientSettingsRequest(); // UpdateClientSettingsRequest | Updates the settings for the specified client. Warning: This API deletes any settings not included in the update request

            try
            {
                // Updates the settings for the specified client. Warning: This API deletes any settings not included in the update request
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateClientSettings(updateClientSettingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientApi.UpdateClientSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateClientSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the settings for the specified client. Warning: This API deletes any settings not included in the update request
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateClientSettingsWithHttpInfo(updateClientSettingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientApi.UpdateClientSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateClientSettingsRequest** | [**UpdateClientSettingsRequest**](UpdateClientSettingsRequest.md) | Updates the settings for the specified client. Warning: This API deletes any settings not included in the update request |  |

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

