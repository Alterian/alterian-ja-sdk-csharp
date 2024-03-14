# Alterian.JA.Api.UsersApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CopyUser**](UsersApi.md#copyuser) | **POST** /CopyUser | Copy a user |
| [**CreateUser**](UsersApi.md#createuser) | **POST** /CreateUser | Add a new user to the specified @see(ALClient) |
| [**DeleteUser**](UsersApi.md#deleteuser) | **POST** /DeleteUser | Delete a user |
| [**DeleteUserReassignAssets**](UsersApi.md#deleteuserreassignassets) | **POST** /DeleteUserReassignAssets | Deletes a user and reassigns their documents, files and folders to another user |
| [**GetCultures**](UsersApi.md#getcultures) | **POST** /GetCultures | Get a list of cultures [for use with the @see(ALUser) ] |
| [**GetCurrentUser**](UsersApi.md#getcurrentuser) | **POST** /GetCurrentUser | Return back the current user [based upon their token] |
| [**GetTimeZones**](UsersApi.md#gettimezones) | **POST** /GetTimeZones | Get a list of the timezones [for use with the @see(ALUser) ] |
| [**GetUser**](UsersApi.md#getuser) | **POST** /GetUser | Given a UserID, get the rest of the details for that user. |
| [**GetUsers**](UsersApi.md#getusers) | **POST** /GetUsers | List the users within the current @see(ALClient), optionally filtering the set returned. |
| [**GetUsersForClient**](UsersApi.md#getusersforclient) | **POST** /GetUsersForClient | List the users within the specified client, optionally filtering the set returned. |
| [**UpdateUser**](UsersApi.md#updateuser) | **POST** /UpdateUser | Given an existing @see(ALUser) object save it to the database             Note that the object will normally have been retrieved by @see(GetUser), and that only fields which are set will be updated in the database |

<a id="copyuser"></a>
# **CopyUser**
> CreateClientDefaultResponse CopyUser (CopyUserRequest copyUserRequest)

Copy a user

Copy a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CopyUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var copyUserRequest = new CopyUserRequest(); // CopyUserRequest | Copy a user

            try
            {
                // Copy a user
                CreateClientDefaultResponse result = apiInstance.CopyUser(copyUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CopyUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopyUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy a user
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CopyUserWithHttpInfo(copyUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.CopyUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **copyUserRequest** | [**CopyUserRequest**](CopyUserRequest.md) | Copy a user |  |

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

<a id="createuser"></a>
# **CreateUser**
> CreateClientDefaultResponse CreateUser (CreateUserRequest createUserRequest)

Add a new user to the specified @see(ALClient)

Add a new user to the specified @see(ALClient)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var createUserRequest = new CreateUserRequest(); // CreateUserRequest | Add a new user to the specified @see(ALClient)

            try
            {
                // Add a new user to the specified @see(ALClient)
                CreateClientDefaultResponse result = apiInstance.CreateUser(createUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new user to the specified @see(ALClient)
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateUserWithHttpInfo(createUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.CreateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createUserRequest** | [**CreateUserRequest**](CreateUserRequest.md) | Add a new user to the specified @see(ALClient) |  |

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

<a id="deleteuser"></a>
# **DeleteUser**
> AUTHChangePasswordDefaultResponse DeleteUser (DeleteUserRequest deleteUserRequest)

Delete a user

Delete a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var deleteUserRequest = new DeleteUserRequest(); // DeleteUserRequest | Delete a user

            try
            {
                // Delete a user
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteUser(deleteUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a user
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteUserWithHttpInfo(deleteUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteUserRequest** | [**DeleteUserRequest**](DeleteUserRequest.md) | Delete a user |  |

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

<a id="deleteuserreassignassets"></a>
# **DeleteUserReassignAssets**
> AUTHChangePasswordDefaultResponse DeleteUserReassignAssets (DeleteUserReassignAssetsRequest deleteUserReassignAssetsRequest)

Deletes a user and reassigns their documents, files and folders to another user

Deletes a user and reassigns their documents, files and folders to another user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteUserReassignAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var deleteUserReassignAssetsRequest = new DeleteUserReassignAssetsRequest(); // DeleteUserReassignAssetsRequest | Deletes a user and reassigns their documents, files and folders to another user

            try
            {
                // Deletes a user and reassigns their documents, files and folders to another user
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteUserReassignAssets(deleteUserReassignAssetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserReassignAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserReassignAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a user and reassigns their documents, files and folders to another user
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteUserReassignAssetsWithHttpInfo(deleteUserReassignAssetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteUserReassignAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteUserReassignAssetsRequest** | [**DeleteUserReassignAssetsRequest**](DeleteUserReassignAssetsRequest.md) | Deletes a user and reassigns their documents, files and folders to another user |  |

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

<a id="getcultures"></a>
# **GetCultures**
> GetCulturesDefaultResponse GetCultures (GetClientSetsRequest getClientSetsRequest)

Get a list of cultures [for use with the @see(ALUser) ]

Get a list of cultures [for use with the @see(ALUser) ]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetCulturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | Get a list of cultures [for use with the @see(ALUser) ]

            try
            {
                // Get a list of cultures [for use with the @see(ALUser) ]
                GetCulturesDefaultResponse result = apiInstance.GetCultures(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetCultures: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCulturesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of cultures [for use with the @see(ALUser) ]
    ApiResponse<GetCulturesDefaultResponse> response = apiInstance.GetCulturesWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetCulturesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | Get a list of cultures [for use with the @see(ALUser) ] |  |

### Return type

[**GetCulturesDefaultResponse**](GetCulturesDefaultResponse.md)

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

<a id="getcurrentuser"></a>
# **GetCurrentUser**
> GetCurrentUserDefaultResponse GetCurrentUser (GetCurrentUserRequest getCurrentUserRequest)

Return back the current user [based upon their token]

Return back the current user [based upon their token]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetCurrentUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var getCurrentUserRequest = new GetCurrentUserRequest(); // GetCurrentUserRequest | Return back the current user [based upon their token]

            try
            {
                // Return back the current user [based upon their token]
                GetCurrentUserDefaultResponse result = apiInstance.GetCurrentUser(getCurrentUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetCurrentUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back the current user [based upon their token]
    ApiResponse<GetCurrentUserDefaultResponse> response = apiInstance.GetCurrentUserWithHttpInfo(getCurrentUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetCurrentUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getCurrentUserRequest** | [**GetCurrentUserRequest**](GetCurrentUserRequest.md) | Return back the current user [based upon their token] |  |

### Return type

[**GetCurrentUserDefaultResponse**](GetCurrentUserDefaultResponse.md)

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

<a id="gettimezones"></a>
# **GetTimeZones**
> GetTimeZonesDefaultResponse GetTimeZones (GetClientSetsRequest getClientSetsRequest)

Get a list of the timezones [for use with the @see(ALUser) ]

Get a list of the timezones [for use with the @see(ALUser) ]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetTimeZonesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | Get a list of the timezones [for use with the @see(ALUser) ]

            try
            {
                // Get a list of the timezones [for use with the @see(ALUser) ]
                GetTimeZonesDefaultResponse result = apiInstance.GetTimeZones(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetTimeZones: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTimeZonesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of the timezones [for use with the @see(ALUser) ]
    ApiResponse<GetTimeZonesDefaultResponse> response = apiInstance.GetTimeZonesWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetTimeZonesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | Get a list of the timezones [for use with the @see(ALUser) ] |  |

### Return type

[**GetTimeZonesDefaultResponse**](GetTimeZonesDefaultResponse.md)

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

<a id="getuser"></a>
# **GetUser**
> GetCurrentUserDefaultResponse GetUser (GetUserRequest getUserRequest)

Given a UserID, get the rest of the details for that user.

Given a UserID, get the rest of the details for that user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var getUserRequest = new GetUserRequest(); // GetUserRequest | Given a UserID, get the rest of the details for that user.

            try
            {
                // Given a UserID, get the rest of the details for that user.
                GetCurrentUserDefaultResponse result = apiInstance.GetUser(getUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Given a UserID, get the rest of the details for that user.
    ApiResponse<GetCurrentUserDefaultResponse> response = apiInstance.GetUserWithHttpInfo(getUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getUserRequest** | [**GetUserRequest**](GetUserRequest.md) | Given a UserID, get the rest of the details for that user. |  |

### Return type

[**GetCurrentUserDefaultResponse**](GetCurrentUserDefaultResponse.md)

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

<a id="getusers"></a>
# **GetUsers**
> GetUsersDefaultResponse GetUsers (GetUsersRequest getUsersRequest)

List the users within the current @see(ALClient), optionally filtering the set returned.

List the users within the current @see(ALClient), optionally filtering the set returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var getUsersRequest = new GetUsersRequest(); // GetUsersRequest | List the users within the current @see(ALClient), optionally filtering the set returned.

            try
            {
                // List the users within the current @see(ALClient), optionally filtering the set returned.
                GetUsersDefaultResponse result = apiInstance.GetUsers(getUsersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the users within the current @see(ALClient), optionally filtering the set returned.
    ApiResponse<GetUsersDefaultResponse> response = apiInstance.GetUsersWithHttpInfo(getUsersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getUsersRequest** | [**GetUsersRequest**](GetUsersRequest.md) | List the users within the current @see(ALClient), optionally filtering the set returned. |  |

### Return type

[**GetUsersDefaultResponse**](GetUsersDefaultResponse.md)

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

<a id="getusersforclient"></a>
# **GetUsersForClient**
> GetUsersDefaultResponse GetUsersForClient (GetUsersForClientRequest getUsersForClientRequest)

List the users within the specified client, optionally filtering the set returned.

List the users within the specified client, optionally filtering the set returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetUsersForClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var getUsersForClientRequest = new GetUsersForClientRequest(); // GetUsersForClientRequest | List the users within the specified client, optionally filtering the set returned.

            try
            {
                // List the users within the specified client, optionally filtering the set returned.
                GetUsersDefaultResponse result = apiInstance.GetUsersForClient(getUsersForClientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersForClient: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersForClientWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the users within the specified client, optionally filtering the set returned.
    ApiResponse<GetUsersDefaultResponse> response = apiInstance.GetUsersForClientWithHttpInfo(getUsersForClientRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUsersForClientWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getUsersForClientRequest** | [**GetUsersForClientRequest**](GetUsersForClientRequest.md) | List the users within the specified client, optionally filtering the set returned. |  |

### Return type

[**GetUsersDefaultResponse**](GetUsersDefaultResponse.md)

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

<a id="updateuser"></a>
# **UpdateUser**
> AUTHChangePasswordDefaultResponse UpdateUser (CreateUserRequest createUserRequest)

Given an existing @see(ALUser) object save it to the database             Note that the object will normally have been retrieved by @see(GetUser), and that only fields which are set will be updated in the database

Given an existing @see(ALUser) object save it to the database             Note that the object will normally have been retrieved by @see(GetUser), and that only fields which are set will be updated in the database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UsersApi(config);
            var createUserRequest = new CreateUserRequest(); // CreateUserRequest | Given an existing @see(ALUser) object save it to the database             Note that the object will normally have been retrieved by @see(GetUser), and that only fields which are set will be updated in the database

            try
            {
                // Given an existing @see(ALUser) object save it to the database             Note that the object will normally have been retrieved by @see(GetUser), and that only fields which are set will be updated in the database
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateUser(createUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Given an existing @see(ALUser) object save it to the database             Note that the object will normally have been retrieved by @see(GetUser), and that only fields which are set will be updated in the database
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateUserWithHttpInfo(createUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpdateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createUserRequest** | [**CreateUserRequest**](CreateUserRequest.md) | Given an existing @see(ALUser) object save it to the database             Note that the object will normally have been retrieved by @see(GetUser), and that only fields which are set will be updated in the database |  |

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

