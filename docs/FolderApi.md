# Alterian.JA.Api.FolderApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFolder**](FolderApi.md#createfolder) | **POST** /CreateFolder | Create a @see(Folder) |
| [**DeleteFolder**](FolderApi.md#deletefolder) | **POST** /DeleteFolder | Delete a @see(Folder) |
| [**GetFolder**](FolderApi.md#getfolder) | **POST** /GetFolder | Get a particular @see(Folder) by it&#39;s ID |
| [**GetFolders**](FolderApi.md#getfolders) | **POST** /GetFolders | Obtain a list of @see(Folder)s |
| [**MoveFolder**](FolderApi.md#movefolder) | **POST** /MoveFolder | Move a @see(Folder) from one @see(Folder) to another |
| [**RenameFolder**](FolderApi.md#renamefolder) | **POST** /RenameFolder | Rename a @see(Folder) |

<a id="createfolder"></a>
# **CreateFolder**
> CreateClientDefaultResponse CreateFolder (CreateFolderRequest createFolderRequest)

Create a @see(Folder)

Create a @see(Folder)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FolderApi(config);
            var createFolderRequest = new CreateFolderRequest(); // CreateFolderRequest | Create a @see(Folder)

            try
            {
                // Create a @see(Folder)
                CreateClientDefaultResponse result = apiInstance.CreateFolder(createFolderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.CreateFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a @see(Folder)
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateFolderWithHttpInfo(createFolderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.CreateFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFolderRequest** | [**CreateFolderRequest**](CreateFolderRequest.md) | Create a @see(Folder) |  |

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

<a id="deletefolder"></a>
# **DeleteFolder**
> AUTHChangePasswordDefaultResponse DeleteFolder (DeleteFolderRequest deleteFolderRequest)

Delete a @see(Folder)

Delete a @see(Folder)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FolderApi(config);
            var deleteFolderRequest = new DeleteFolderRequest(); // DeleteFolderRequest | Delete a @see(Folder)

            try
            {
                // Delete a @see(Folder)
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteFolder(deleteFolderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.DeleteFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a @see(Folder)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteFolderWithHttpInfo(deleteFolderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.DeleteFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteFolderRequest** | [**DeleteFolderRequest**](DeleteFolderRequest.md) | Delete a @see(Folder) |  |

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

<a id="getfolder"></a>
# **GetFolder**
> GetFolderDefaultResponse GetFolder (GetFolderRequest getFolderRequest)

Get a particular @see(Folder) by it's ID

Get a particular @see(Folder) by it's ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FolderApi(config);
            var getFolderRequest = new GetFolderRequest(); // GetFolderRequest | Get a particular @see(Folder) by it's ID

            try
            {
                // Get a particular @see(Folder) by it's ID
                GetFolderDefaultResponse result = apiInstance.GetFolder(getFolderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.GetFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a particular @see(Folder) by it's ID
    ApiResponse<GetFolderDefaultResponse> response = apiInstance.GetFolderWithHttpInfo(getFolderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.GetFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getFolderRequest** | [**GetFolderRequest**](GetFolderRequest.md) | Get a particular @see(Folder) by it&#39;s ID |  |

### Return type

[**GetFolderDefaultResponse**](GetFolderDefaultResponse.md)

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

<a id="getfolders"></a>
# **GetFolders**
> GetFoldersDefaultResponse GetFolders (GetFoldersRequest getFoldersRequest)

Obtain a list of @see(Folder)s

Obtain a list of @see(Folder)s

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetFoldersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FolderApi(config);
            var getFoldersRequest = new GetFoldersRequest(); // GetFoldersRequest | Obtain a list of @see(Folder)s

            try
            {
                // Obtain a list of @see(Folder)s
                GetFoldersDefaultResponse result = apiInstance.GetFolders(getFoldersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.GetFolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Obtain a list of @see(Folder)s
    ApiResponse<GetFoldersDefaultResponse> response = apiInstance.GetFoldersWithHttpInfo(getFoldersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.GetFoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getFoldersRequest** | [**GetFoldersRequest**](GetFoldersRequest.md) | Obtain a list of @see(Folder)s |  |

### Return type

[**GetFoldersDefaultResponse**](GetFoldersDefaultResponse.md)

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

<a id="movefolder"></a>
# **MoveFolder**
> AUTHChangePasswordDefaultResponse MoveFolder (MoveFolderRequest moveFolderRequest)

Move a @see(Folder) from one @see(Folder) to another

Move a @see(Folder) from one @see(Folder) to another

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class MoveFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FolderApi(config);
            var moveFolderRequest = new MoveFolderRequest(); // MoveFolderRequest | Move a @see(Folder) from one @see(Folder) to another

            try
            {
                // Move a @see(Folder) from one @see(Folder) to another
                AUTHChangePasswordDefaultResponse result = apiInstance.MoveFolder(moveFolderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.MoveFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Move a @see(Folder) from one @see(Folder) to another
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.MoveFolderWithHttpInfo(moveFolderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.MoveFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moveFolderRequest** | [**MoveFolderRequest**](MoveFolderRequest.md) | Move a @see(Folder) from one @see(Folder) to another |  |

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

<a id="renamefolder"></a>
# **RenameFolder**
> AUTHChangePasswordDefaultResponse RenameFolder (RenameFolderRequest renameFolderRequest)

Rename a @see(Folder)

Rename a @see(Folder)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class RenameFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FolderApi(config);
            var renameFolderRequest = new RenameFolderRequest(); // RenameFolderRequest | Rename a @see(Folder)

            try
            {
                // Rename a @see(Folder)
                AUTHChangePasswordDefaultResponse result = apiInstance.RenameFolder(renameFolderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.RenameFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename a @see(Folder)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.RenameFolderWithHttpInfo(renameFolderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.RenameFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **renameFolderRequest** | [**RenameFolderRequest**](RenameFolderRequest.md) | Rename a @see(Folder) |  |

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

