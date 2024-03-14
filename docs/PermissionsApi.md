# Alterian.JA.Api.PermissionsApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClearPermissions**](PermissionsApi.md#clearpermissions) | **POST** /ClearPermissions | Clear the permissions for the specific security ID |
| [**GetAvailablePermissions**](PermissionsApi.md#getavailablepermissions) | **POST** /GetAvailablePermissions | Gets a list of the permissions; this is a simple list and does not include permission values, etc. |
| [**GetGroupsWithPermission**](PermissionsApi.md#getgroupswithpermission) | **POST** /GetGroupsWithPermission | List the groups which have been granted the specified permission |
| [**GetPermissions**](PermissionsApi.md#getpermissions) | **POST** /GetPermissions | Given a particular item, fetch a list of permissions on that item for a given user or group. |
| [**GetPermittedUsersAndGroups**](PermissionsApi.md#getpermittedusersandgroups) | **POST** /GetPermittedUsersAndGroups | List the users and groups which have direct or indirect access to the specified item |
| [**GetResources**](PermissionsApi.md#getresources) | **POST** /GetResources | Gets a list of the resource types for permissions |
| [**GetUsersWithPermission**](PermissionsApi.md#getuserswithpermission) | **POST** /GetUsersWithPermission | List the users which have been granted the specified permission |
| [**SetPermissions**](PermissionsApi.md#setpermissions) | **POST** /SetPermissions | Set permissions for a particular item and securityID |
| [**TakeOwnershipPermission**](PermissionsApi.md#takeownershippermission) | **POST** /TakeOwnershipPermission | Change the owner of a particular item from the current owner to somebody else |

<a id="clearpermissions"></a>
# **ClearPermissions**
> AUTHChangePasswordDefaultResponse ClearPermissions (ClearPermissionsRequest clearPermissionsRequest)

Clear the permissions for the specific security ID

Clear the permissions for the specific security ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class ClearPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);
            var clearPermissionsRequest = new ClearPermissionsRequest(); // ClearPermissionsRequest | Clear the permissions for the specific security ID

            try
            {
                // Clear the permissions for the specific security ID
                AUTHChangePasswordDefaultResponse result = apiInstance.ClearPermissions(clearPermissionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.ClearPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClearPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear the permissions for the specific security ID
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.ClearPermissionsWithHttpInfo(clearPermissionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.ClearPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clearPermissionsRequest** | [**ClearPermissionsRequest**](ClearPermissionsRequest.md) | Clear the permissions for the specific security ID |  |

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

<a id="getavailablepermissions"></a>
# **GetAvailablePermissions**
> GetAvailablePermissionsDefaultResponse GetAvailablePermissions ()

Gets a list of the permissions; this is a simple list and does not include permission values, etc.

Gets a list of the permissions; this is a simple list and does not include permission values, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetAvailablePermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);

            try
            {
                // Gets a list of the permissions; this is a simple list and does not include permission values, etc.
                GetAvailablePermissionsDefaultResponse result = apiInstance.GetAvailablePermissions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetAvailablePermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvailablePermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of the permissions; this is a simple list and does not include permission values, etc.
    ApiResponse<GetAvailablePermissionsDefaultResponse> response = apiInstance.GetAvailablePermissionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.GetAvailablePermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetAvailablePermissionsDefaultResponse**](GetAvailablePermissionsDefaultResponse.md)

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

<a id="getgroupswithpermission"></a>
# **GetGroupsWithPermission**
> GetGroupsWithPermissionDefaultResponse GetGroupsWithPermission (GetGroupsWithPermissionRequest getGroupsWithPermissionRequest)

List the groups which have been granted the specified permission

List the groups which have been granted the specified permission

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetGroupsWithPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);
            var getGroupsWithPermissionRequest = new GetGroupsWithPermissionRequest(); // GetGroupsWithPermissionRequest | List the groups which have been granted the specified permission

            try
            {
                // List the groups which have been granted the specified permission
                GetGroupsWithPermissionDefaultResponse result = apiInstance.GetGroupsWithPermission(getGroupsWithPermissionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetGroupsWithPermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsWithPermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the groups which have been granted the specified permission
    ApiResponse<GetGroupsWithPermissionDefaultResponse> response = apiInstance.GetGroupsWithPermissionWithHttpInfo(getGroupsWithPermissionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.GetGroupsWithPermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getGroupsWithPermissionRequest** | [**GetGroupsWithPermissionRequest**](GetGroupsWithPermissionRequest.md) | List the groups which have been granted the specified permission |  |

### Return type

[**GetGroupsWithPermissionDefaultResponse**](GetGroupsWithPermissionDefaultResponse.md)

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

<a id="getpermissions"></a>
# **GetPermissions**
> GetPermissionsDefaultResponse GetPermissions (GetPermissionsRequest getPermissionsRequest)

Given a particular item, fetch a list of permissions on that item for a given user or group.

Given a particular item, fetch a list of permissions on that item for a given user or group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);
            var getPermissionsRequest = new GetPermissionsRequest(); // GetPermissionsRequest | Given a particular item, fetch a list of permissions on that item for a given user or group.

            try
            {
                // Given a particular item, fetch a list of permissions on that item for a given user or group.
                GetPermissionsDefaultResponse result = apiInstance.GetPermissions(getPermissionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Given a particular item, fetch a list of permissions on that item for a given user or group.
    ApiResponse<GetPermissionsDefaultResponse> response = apiInstance.GetPermissionsWithHttpInfo(getPermissionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.GetPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPermissionsRequest** | [**GetPermissionsRequest**](GetPermissionsRequest.md) | Given a particular item, fetch a list of permissions on that item for a given user or group. |  |

### Return type

[**GetPermissionsDefaultResponse**](GetPermissionsDefaultResponse.md)

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

<a id="getpermittedusersandgroups"></a>
# **GetPermittedUsersAndGroups**
> GetGroupsWithPermissionDefaultResponse GetPermittedUsersAndGroups (GetPermittedUsersAndGroupsRequest getPermittedUsersAndGroupsRequest)

List the users and groups which have direct or indirect access to the specified item

List the users and groups which have direct or indirect access to the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetPermittedUsersAndGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);
            var getPermittedUsersAndGroupsRequest = new GetPermittedUsersAndGroupsRequest(); // GetPermittedUsersAndGroupsRequest | List the users and groups which have direct or indirect access to the specified item

            try
            {
                // List the users and groups which have direct or indirect access to the specified item
                GetGroupsWithPermissionDefaultResponse result = apiInstance.GetPermittedUsersAndGroups(getPermittedUsersAndGroupsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetPermittedUsersAndGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPermittedUsersAndGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the users and groups which have direct or indirect access to the specified item
    ApiResponse<GetGroupsWithPermissionDefaultResponse> response = apiInstance.GetPermittedUsersAndGroupsWithHttpInfo(getPermittedUsersAndGroupsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.GetPermittedUsersAndGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPermittedUsersAndGroupsRequest** | [**GetPermittedUsersAndGroupsRequest**](GetPermittedUsersAndGroupsRequest.md) | List the users and groups which have direct or indirect access to the specified item |  |

### Return type

[**GetGroupsWithPermissionDefaultResponse**](GetGroupsWithPermissionDefaultResponse.md)

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

<a id="getresources"></a>
# **GetResources**
> GetResourcesDefaultResponse GetResources ()

Gets a list of the resource types for permissions

Gets a list of the resource types for permissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);

            try
            {
                // Gets a list of the resource types for permissions
                GetResourcesDefaultResponse result = apiInstance.GetResources();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetResources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of the resource types for permissions
    ApiResponse<GetResourcesDefaultResponse> response = apiInstance.GetResourcesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.GetResourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetResourcesDefaultResponse**](GetResourcesDefaultResponse.md)

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

<a id="getuserswithpermission"></a>
# **GetUsersWithPermission**
> GetGroupsWithPermissionDefaultResponse GetUsersWithPermission (GetUsersWithPermissionRequest getUsersWithPermissionRequest)

List the users which have been granted the specified permission

List the users which have been granted the specified permission

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetUsersWithPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);
            var getUsersWithPermissionRequest = new GetUsersWithPermissionRequest(); // GetUsersWithPermissionRequest | List the users which have been granted the specified permission

            try
            {
                // List the users which have been granted the specified permission
                GetGroupsWithPermissionDefaultResponse result = apiInstance.GetUsersWithPermission(getUsersWithPermissionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetUsersWithPermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithPermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the users which have been granted the specified permission
    ApiResponse<GetGroupsWithPermissionDefaultResponse> response = apiInstance.GetUsersWithPermissionWithHttpInfo(getUsersWithPermissionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.GetUsersWithPermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getUsersWithPermissionRequest** | [**GetUsersWithPermissionRequest**](GetUsersWithPermissionRequest.md) | List the users which have been granted the specified permission |  |

### Return type

[**GetGroupsWithPermissionDefaultResponse**](GetGroupsWithPermissionDefaultResponse.md)

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

<a id="setpermissions"></a>
# **SetPermissions**
> AUTHChangePasswordDefaultResponse SetPermissions (SetPermissionsRequest setPermissionsRequest)

Set permissions for a particular item and securityID

Set permissions for a particular item and securityID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class SetPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);
            var setPermissionsRequest = new SetPermissionsRequest(); // SetPermissionsRequest | Set permissions for a particular item and securityID

            try
            {
                // Set permissions for a particular item and securityID
                AUTHChangePasswordDefaultResponse result = apiInstance.SetPermissions(setPermissionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.SetPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set permissions for a particular item and securityID
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.SetPermissionsWithHttpInfo(setPermissionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.SetPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setPermissionsRequest** | [**SetPermissionsRequest**](SetPermissionsRequest.md) | Set permissions for a particular item and securityID |  |

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

<a id="takeownershippermission"></a>
# **TakeOwnershipPermission**
> AUTHChangePasswordDefaultResponse TakeOwnershipPermission (TakeOwnershipPermissionRequest takeOwnershipPermissionRequest)

Change the owner of a particular item from the current owner to somebody else

Change the owner of a particular item from the current owner to somebody else

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class TakeOwnershipPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PermissionsApi(config);
            var takeOwnershipPermissionRequest = new TakeOwnershipPermissionRequest(); // TakeOwnershipPermissionRequest | Change the owner of a particular item from the current owner to somebody else

            try
            {
                // Change the owner of a particular item from the current owner to somebody else
                AUTHChangePasswordDefaultResponse result = apiInstance.TakeOwnershipPermission(takeOwnershipPermissionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.TakeOwnershipPermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TakeOwnershipPermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change the owner of a particular item from the current owner to somebody else
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.TakeOwnershipPermissionWithHttpInfo(takeOwnershipPermissionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.TakeOwnershipPermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **takeOwnershipPermissionRequest** | [**TakeOwnershipPermissionRequest**](TakeOwnershipPermissionRequest.md) | Change the owner of a particular item from the current owner to somebody else |  |

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

