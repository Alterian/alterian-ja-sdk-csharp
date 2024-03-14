# Alterian.JA.Api.EmailManagerMappingApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEMMapping**](EmailManagerMappingApi.md#createemmapping) | **POST** /CreateEMMapping | Added a new @see(EMUploadMapping) into the system, returning back the ID of the new mapping.  Note that @see(EMMapping)s must be uniquely named. |
| [**CreateEMSession**](EmailManagerMappingApi.md#createemsession) | **POST** /CreateEMSession | Connects to a mapping&#39;s EM system and provides back the application details [including token and other settings] |
| [**DeleteEMMapping**](EmailManagerMappingApi.md#deleteemmapping) | **POST** /DeleteEMMapping | Deletes an @see(EMUploadMapping) from the system.  If a mapping which is currently in use is deleted, campaigns which rely upon it will cease to function. |
| [**GetEMDownloadMappings**](EmailManagerMappingApi.md#getemdownloadmappings) | **POST** /GetEMDownloadMappings | Return back a list of the @see(EMDownloadMapping)s which the token can view. |
| [**GetEMMapping**](EmailManagerMappingApi.md#getemmapping) | **POST** /GetEMMapping | Returns back a single @see(EMUploadMapping) by its ID. |
| [**GetEMMappings**](EmailManagerMappingApi.md#getemmappings) | **POST** /GetEMMappings | Return back a list of the @see(EMUploadMapping)s which the token can view. |
| [**MoveEMMapping**](EmailManagerMappingApi.md#moveemmapping) | **POST** /MoveEMMapping | Provides a way to easily move an @see(EMUploadMapping) from one folder to another.  Note that @see(EMMapping)s must be uniquely named within a folder. |
| [**RenameEMMapping**](EmailManagerMappingApi.md#renameemmapping) | **POST** /RenameEMMapping | Provides a way to easily rename an @see(EMUploadMapping).  Note that @see(EMMapping)s must be uniquely named. |
| [**UpdateEMMapping**](EmailManagerMappingApi.md#updateemmapping) | **POST** /UpdateEMMapping | Updates an @see(EMUploadMapping) so you can change the name, folder, etc.  Note that @see(EMMapping)s must be uniquely named. |

<a id="createemmapping"></a>
# **CreateEMMapping**
> CreateClientDefaultResponse CreateEMMapping (CreateEMMappingRequest createEMMappingRequest)

Added a new @see(EMUploadMapping) into the system, returning back the ID of the new mapping.  Note that @see(EMMapping)s must be uniquely named.

Added a new @see(EMUploadMapping) into the system, returning back the ID of the new mapping.  Note that @see(EMMapping)s must be uniquely named.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateEMMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var createEMMappingRequest = new CreateEMMappingRequest(); // CreateEMMappingRequest | Added a new @see(EMUploadMapping) into the system, returning back the ID of the new mapping.  Note that @see(EMMapping)s must be uniquely named.

            try
            {
                // Added a new @see(EMUploadMapping) into the system, returning back the ID of the new mapping.  Note that @see(EMMapping)s must be uniquely named.
                CreateClientDefaultResponse result = apiInstance.CreateEMMapping(createEMMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.CreateEMMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEMMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Added a new @see(EMUploadMapping) into the system, returning back the ID of the new mapping.  Note that @see(EMMapping)s must be uniquely named.
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateEMMappingWithHttpInfo(createEMMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.CreateEMMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEMMappingRequest** | [**CreateEMMappingRequest**](CreateEMMappingRequest.md) | Added a new @see(EMUploadMapping) into the system, returning back the ID of the new mapping.  Note that @see(EMMapping)s must be uniquely named. |  |

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

<a id="createemsession"></a>
# **CreateEMSession**
> CreateEMSessionDefaultResponse CreateEMSession (CreateEMSessionRequest createEMSessionRequest)

Connects to a mapping's EM system and provides back the application details [including token and other settings]

Connects to a mapping's EM system and provides back the application details [including token and other settings]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateEMSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var createEMSessionRequest = new CreateEMSessionRequest(); // CreateEMSessionRequest | Connects to a mapping's EM system and provides back the application details [including token and other settings]

            try
            {
                // Connects to a mapping's EM system and provides back the application details [including token and other settings]
                CreateEMSessionDefaultResponse result = apiInstance.CreateEMSession(createEMSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.CreateEMSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEMSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Connects to a mapping's EM system and provides back the application details [including token and other settings]
    ApiResponse<CreateEMSessionDefaultResponse> response = apiInstance.CreateEMSessionWithHttpInfo(createEMSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.CreateEMSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEMSessionRequest** | [**CreateEMSessionRequest**](CreateEMSessionRequest.md) | Connects to a mapping&#39;s EM system and provides back the application details [including token and other settings] |  |

### Return type

[**CreateEMSessionDefaultResponse**](CreateEMSessionDefaultResponse.md)

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

<a id="deleteemmapping"></a>
# **DeleteEMMapping**
> AUTHChangePasswordDefaultResponse DeleteEMMapping (DeleteEMMappingRequest deleteEMMappingRequest)

Deletes an @see(EMUploadMapping) from the system.  If a mapping which is currently in use is deleted, campaigns which rely upon it will cease to function.

Deletes an @see(EMUploadMapping) from the system.  If a mapping which is currently in use is deleted, campaigns which rely upon it will cease to function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteEMMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var deleteEMMappingRequest = new DeleteEMMappingRequest(); // DeleteEMMappingRequest | Deletes an @see(EMUploadMapping) from the system.  If a mapping which is currently in use is deleted, campaigns which rely upon it will cease to function.

            try
            {
                // Deletes an @see(EMUploadMapping) from the system.  If a mapping which is currently in use is deleted, campaigns which rely upon it will cease to function.
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteEMMapping(deleteEMMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.DeleteEMMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEMMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an @see(EMUploadMapping) from the system.  If a mapping which is currently in use is deleted, campaigns which rely upon it will cease to function.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteEMMappingWithHttpInfo(deleteEMMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.DeleteEMMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteEMMappingRequest** | [**DeleteEMMappingRequest**](DeleteEMMappingRequest.md) | Deletes an @see(EMUploadMapping) from the system.  If a mapping which is currently in use is deleted, campaigns which rely upon it will cease to function. |  |

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

<a id="getemdownloadmappings"></a>
# **GetEMDownloadMappings**
> GetEMDownloadMappingsDefaultResponse GetEMDownloadMappings (GetClientSetsRequest getClientSetsRequest)

Return back a list of the @see(EMDownloadMapping)s which the token can view.

Return back a list of the @see(EMDownloadMapping)s which the token can view.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEMDownloadMappingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | Return back a list of the @see(EMDownloadMapping)s which the token can view.

            try
            {
                // Return back a list of the @see(EMDownloadMapping)s which the token can view.
                GetEMDownloadMappingsDefaultResponse result = apiInstance.GetEMDownloadMappings(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.GetEMDownloadMappings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEMDownloadMappingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back a list of the @see(EMDownloadMapping)s which the token can view.
    ApiResponse<GetEMDownloadMappingsDefaultResponse> response = apiInstance.GetEMDownloadMappingsWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.GetEMDownloadMappingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | Return back a list of the @see(EMDownloadMapping)s which the token can view. |  |

### Return type

[**GetEMDownloadMappingsDefaultResponse**](GetEMDownloadMappingsDefaultResponse.md)

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

<a id="getemmapping"></a>
# **GetEMMapping**
> GetEMMappingDefaultResponse GetEMMapping (GetEMMappingRequest getEMMappingRequest)

Returns back a single @see(EMUploadMapping) by its ID.

Returns back a single @see(EMUploadMapping) by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEMMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var getEMMappingRequest = new GetEMMappingRequest(); // GetEMMappingRequest | Returns back a single @see(EMUploadMapping) by its ID.

            try
            {
                // Returns back a single @see(EMUploadMapping) by its ID.
                GetEMMappingDefaultResponse result = apiInstance.GetEMMapping(getEMMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.GetEMMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEMMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a single @see(EMUploadMapping) by its ID.
    ApiResponse<GetEMMappingDefaultResponse> response = apiInstance.GetEMMappingWithHttpInfo(getEMMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.GetEMMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEMMappingRequest** | [**GetEMMappingRequest**](GetEMMappingRequest.md) | Returns back a single @see(EMUploadMapping) by its ID. |  |

### Return type

[**GetEMMappingDefaultResponse**](GetEMMappingDefaultResponse.md)

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

<a id="getemmappings"></a>
# **GetEMMappings**
> GetEMMappingsDefaultResponse GetEMMappings (GetEMMappingsRequest getEMMappingsRequest)

Return back a list of the @see(EMUploadMapping)s which the token can view.

Return back a list of the @see(EMUploadMapping)s which the token can view.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEMMappingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var getEMMappingsRequest = new GetEMMappingsRequest(); // GetEMMappingsRequest | Return back a list of the @see(EMUploadMapping)s which the token can view.

            try
            {
                // Return back a list of the @see(EMUploadMapping)s which the token can view.
                GetEMMappingsDefaultResponse result = apiInstance.GetEMMappings(getEMMappingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.GetEMMappings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEMMappingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back a list of the @see(EMUploadMapping)s which the token can view.
    ApiResponse<GetEMMappingsDefaultResponse> response = apiInstance.GetEMMappingsWithHttpInfo(getEMMappingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.GetEMMappingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEMMappingsRequest** | [**GetEMMappingsRequest**](GetEMMappingsRequest.md) | Return back a list of the @see(EMUploadMapping)s which the token can view. |  |

### Return type

[**GetEMMappingsDefaultResponse**](GetEMMappingsDefaultResponse.md)

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

<a id="moveemmapping"></a>
# **MoveEMMapping**
> AUTHChangePasswordDefaultResponse MoveEMMapping (MoveEMMappingRequest moveEMMappingRequest)

Provides a way to easily move an @see(EMUploadMapping) from one folder to another.  Note that @see(EMMapping)s must be uniquely named within a folder.

Provides a way to easily move an @see(EMUploadMapping) from one folder to another.  Note that @see(EMMapping)s must be uniquely named within a folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class MoveEMMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var moveEMMappingRequest = new MoveEMMappingRequest(); // MoveEMMappingRequest | Provides a way to easily move an @see(EMUploadMapping) from one folder to another.  Note that @see(EMMapping)s must be uniquely named within a folder.

            try
            {
                // Provides a way to easily move an @see(EMUploadMapping) from one folder to another.  Note that @see(EMMapping)s must be uniquely named within a folder.
                AUTHChangePasswordDefaultResponse result = apiInstance.MoveEMMapping(moveEMMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.MoveEMMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveEMMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provides a way to easily move an @see(EMUploadMapping) from one folder to another.  Note that @see(EMMapping)s must be uniquely named within a folder.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.MoveEMMappingWithHttpInfo(moveEMMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.MoveEMMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moveEMMappingRequest** | [**MoveEMMappingRequest**](MoveEMMappingRequest.md) | Provides a way to easily move an @see(EMUploadMapping) from one folder to another.  Note that @see(EMMapping)s must be uniquely named within a folder. |  |

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

<a id="renameemmapping"></a>
# **RenameEMMapping**
> AUTHChangePasswordDefaultResponse RenameEMMapping (RenameEMMappingRequest renameEMMappingRequest)

Provides a way to easily rename an @see(EMUploadMapping).  Note that @see(EMMapping)s must be uniquely named.

Provides a way to easily rename an @see(EMUploadMapping).  Note that @see(EMMapping)s must be uniquely named.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class RenameEMMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var renameEMMappingRequest = new RenameEMMappingRequest(); // RenameEMMappingRequest | Provides a way to easily rename an @see(EMUploadMapping).  Note that @see(EMMapping)s must be uniquely named.

            try
            {
                // Provides a way to easily rename an @see(EMUploadMapping).  Note that @see(EMMapping)s must be uniquely named.
                AUTHChangePasswordDefaultResponse result = apiInstance.RenameEMMapping(renameEMMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.RenameEMMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameEMMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provides a way to easily rename an @see(EMUploadMapping).  Note that @see(EMMapping)s must be uniquely named.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.RenameEMMappingWithHttpInfo(renameEMMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.RenameEMMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **renameEMMappingRequest** | [**RenameEMMappingRequest**](RenameEMMappingRequest.md) | Provides a way to easily rename an @see(EMUploadMapping).  Note that @see(EMMapping)s must be uniquely named. |  |

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

<a id="updateemmapping"></a>
# **UpdateEMMapping**
> AUTHChangePasswordDefaultResponse UpdateEMMapping (CreateEMMappingRequest createEMMappingRequest)

Updates an @see(EMUploadMapping) so you can change the name, folder, etc.  Note that @see(EMMapping)s must be uniquely named.

Updates an @see(EMUploadMapping) so you can change the name, folder, etc.  Note that @see(EMMapping)s must be uniquely named.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateEMMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EmailManagerMappingApi(config);
            var createEMMappingRequest = new CreateEMMappingRequest(); // CreateEMMappingRequest | Updates an @see(EMUploadMapping) so you can change the name, folder, etc.  Note that @see(EMMapping)s must be uniquely named.

            try
            {
                // Updates an @see(EMUploadMapping) so you can change the name, folder, etc.  Note that @see(EMMapping)s must be uniquely named.
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateEMMapping(createEMMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailManagerMappingApi.UpdateEMMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEMMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an @see(EMUploadMapping) so you can change the name, folder, etc.  Note that @see(EMMapping)s must be uniquely named.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateEMMappingWithHttpInfo(createEMMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailManagerMappingApi.UpdateEMMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEMMappingRequest** | [**CreateEMMappingRequest**](CreateEMMappingRequest.md) | Updates an @see(EMUploadMapping) so you can change the name, folder, etc.  Note that @see(EMMapping)s must be uniquely named. |  |

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

