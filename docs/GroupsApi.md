# Alterian.JA.Api.GroupsApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CopyGroup**](GroupsApi.md#copygroup) | **POST** /CopyGroup | Copy a group from one folder to another |
| [**CreateGroup**](GroupsApi.md#creategroup) | **POST** /CreateGroup | Create a group |
| [**DeleteGroup**](GroupsApi.md#deletegroup) | **POST** /DeleteGroup | Delete a group |
| [**GetGroup**](GroupsApi.md#getgroup) | **POST** /GetGroup | Get a group object |
| [**GetGroupMembers**](GroupsApi.md#getgroupmembers) | **POST** /GetGroupMembers | Get the members of a particular group |
| [**GetGroups**](GroupsApi.md#getgroups) | **POST** /GetGroups | List groups in the client |
| [**UpdateGroup**](GroupsApi.md#updategroup) | **POST** /UpdateGroup | Update a group |

<a id="copygroup"></a>
# **CopyGroup**
> CreateClientDefaultResponse CopyGroup (CopyGroupRequest copyGroupRequest)

Copy a group from one folder to another

Copy a group from one folder to another

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CopyGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new GroupsApi(config);
            var copyGroupRequest = new CopyGroupRequest(); // CopyGroupRequest | Copy a group from one folder to another

            try
            {
                // Copy a group from one folder to another
                CreateClientDefaultResponse result = apiInstance.CopyGroup(copyGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CopyGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopyGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy a group from one folder to another
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CopyGroupWithHttpInfo(copyGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CopyGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **copyGroupRequest** | [**CopyGroupRequest**](CopyGroupRequest.md) | Copy a group from one folder to another |  |

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

<a id="creategroup"></a>
# **CreateGroup**
> CreateClientDefaultResponse CreateGroup (CreateGroupRequest createGroupRequest)

Create a group

Create a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new GroupsApi(config);
            var createGroupRequest = new CreateGroupRequest(); // CreateGroupRequest | Create a group

            try
            {
                // Create a group
                CreateClientDefaultResponse result = apiInstance.CreateGroup(createGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a group
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateGroupWithHttpInfo(createGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CreateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGroupRequest** | [**CreateGroupRequest**](CreateGroupRequest.md) | Create a group |  |

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

<a id="deletegroup"></a>
# **DeleteGroup**
> AUTHChangePasswordDefaultResponse DeleteGroup (DeleteGroupRequest deleteGroupRequest)

Delete a group

Delete a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new GroupsApi(config);
            var deleteGroupRequest = new DeleteGroupRequest(); // DeleteGroupRequest | Delete a group

            try
            {
                // Delete a group
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteGroup(deleteGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a group
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteGroupWithHttpInfo(deleteGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteGroupRequest** | [**DeleteGroupRequest**](DeleteGroupRequest.md) | Delete a group |  |

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

<a id="getgroup"></a>
# **GetGroup**
> GetGroupDefaultResponse GetGroup (GetGroupRequest getGroupRequest)

Get a group object

Get a group object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new GroupsApi(config);
            var getGroupRequest = new GetGroupRequest(); // GetGroupRequest | Get a group object

            try
            {
                // Get a group object
                GetGroupDefaultResponse result = apiInstance.GetGroup(getGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a group object
    ApiResponse<GetGroupDefaultResponse> response = apiInstance.GetGroupWithHttpInfo(getGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getGroupRequest** | [**GetGroupRequest**](GetGroupRequest.md) | Get a group object |  |

### Return type

[**GetGroupDefaultResponse**](GetGroupDefaultResponse.md)

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

<a id="getgroupmembers"></a>
# **GetGroupMembers**
> GetGroupMembersDefaultResponse GetGroupMembers (GetGroupMembersRequest getGroupMembersRequest)

Get the members of a particular group

Get the members of a particular group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetGroupMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new GroupsApi(config);
            var getGroupMembersRequest = new GetGroupMembersRequest(); // GetGroupMembersRequest | Get the members of a particular group

            try
            {
                // Get the members of a particular group
                GetGroupMembersDefaultResponse result = apiInstance.GetGroupMembers(getGroupMembersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the members of a particular group
    ApiResponse<GetGroupMembersDefaultResponse> response = apiInstance.GetGroupMembersWithHttpInfo(getGroupMembersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getGroupMembersRequest** | [**GetGroupMembersRequest**](GetGroupMembersRequest.md) | Get the members of a particular group |  |

### Return type

[**GetGroupMembersDefaultResponse**](GetGroupMembersDefaultResponse.md)

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

<a id="getgroups"></a>
# **GetGroups**
> GetGroupsDefaultResponse GetGroups (GetGroupsRequest getGroupsRequest)

List groups in the client

List groups in the client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new GroupsApi(config);
            var getGroupsRequest = new GetGroupsRequest(); // GetGroupsRequest | List groups in the client

            try
            {
                // List groups in the client
                GetGroupsDefaultResponse result = apiInstance.GetGroups(getGroupsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List groups in the client
    ApiResponse<GetGroupsDefaultResponse> response = apiInstance.GetGroupsWithHttpInfo(getGroupsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getGroupsRequest** | [**GetGroupsRequest**](GetGroupsRequest.md) | List groups in the client |  |

### Return type

[**GetGroupsDefaultResponse**](GetGroupsDefaultResponse.md)

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

<a id="updategroup"></a>
# **UpdateGroup**
> AUTHChangePasswordDefaultResponse UpdateGroup (CreateGroupRequest createGroupRequest)

Update a group

Update a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new GroupsApi(config);
            var createGroupRequest = new CreateGroupRequest(); // CreateGroupRequest | Update a group

            try
            {
                // Update a group
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateGroup(createGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a group
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateGroupWithHttpInfo(createGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UpdateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGroupRequest** | [**CreateGroupRequest**](CreateGroupRequest.md) | Update a group |  |

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

