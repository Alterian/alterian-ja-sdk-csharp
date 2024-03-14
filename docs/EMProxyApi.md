# Alterian.JA.Api.EMProxyApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EMAbortDeployment**](EMProxyApi.md#emabortdeployment) | **POST** /EM_AbortDeployment | Proxy call to EM UserManager.asmx to abort a deployment |
| [**EMAuthenticate**](EMProxyApi.md#emauthenticate) | **POST** /EM_Authenticate | Proxy call to EM Authenticate.asmx             public string AuthenticateEx(string Login, string Password, string NewPassword, bool BumpExisting, DateTime LocalTime, DMPasswordFormat PasswordFormat) |
| [**EMDeleteList**](EMProxyApi.md#emdeletelist) | **POST** /EM_DeleteList | Deletes a list |
| [**EMGetClientGroupUsers**](EMProxyApi.md#emgetclientgroupusers) | **POST** /EM_GetClientGroupUsers | Proxy call to EM UserManager.asmx             public DMUserCollection GetClientGroupUsers(string Token, DMClient Client, int GroupID) |
| [**EMGetClientGroups**](EMProxyApi.md#emgetclientgroups) | **POST** /EM_GetClientGroups | Proxy call to the EM UserManager.asmx              DMGroupCollection GetClientGroups(string Token, DMClient Client, out DMNestedGroupCollection Nested) |
| [**EMGetClientInfo**](EMProxyApi.md#emgetclientinfo) | **POST** /EM_GetClientInfo | Proxy call to EM Authenticate.asmx             public void GetClientInfo(string Token, out int ID, out string Name, out string ContentURL, out string Icon) |
| [**EMGetClientSets**](EMProxyApi.md#emgetclientsets) | **POST** /EM_GetClientSets | Proxy call to EM ClientManager.asmx             public DMClientSetCollection GetClientSets(string Token) |
| [**EMGetCreative**](EMProxyApi.md#emgetcreative) | **POST** /EM_GetCreative | Proxy call to get EM creative |
| [**EMGetCreativeFields**](EMProxyApi.md#emgetcreativefields) | **POST** /EM_GetCreativeFields | Proxy call to get EM creative fields |
| [**EMGetCreatives**](EMProxyApi.md#emgetcreatives) | **POST** /EM_GetCreatives | Proxy call to get EM creatives |
| [**EMGetEMServiceURL**](EMProxyApi.md#emgetemserviceurl) | **POST** /EM_GetEMServiceURL | Returns back the EM Service URL for the siteID requested. |
| [**EMGetEmailValidationExpression**](EMProxyApi.md#emgetemailvalidationexpression) | **POST** /EM_GetEmailValidationExpression | Return the regular expression string used to validate an email address. This is the same expression used by Email Manager. |
| [**EMGetFoldersLazy**](EMProxyApi.md#emgetfolderslazy) | **POST** /EM_GetFoldersLazy | Returns an object containing the list of folders in the specified folder, together with a string representation of the folder hierarchy. |
| [**EMGetInboundAddresses**](EMProxyApi.md#emgetinboundaddresses) | **POST** /EM_GetInboundAddresses | Proxy call to get inbound addresses |
| [**EMGetTemplateContent**](EMProxyApi.md#emgettemplatecontent) | **POST** /EM_GetTemplateContent | Proxy call to get EM template content |
| [**EMGetUsers**](EMProxyApi.md#emgetusers) | **POST** /EM_GetUsers | Proxy call to EM UserManager.asmx             public List(DMUser) GetUsers(string Token) Can use with existing EMToken or supply mapping Id for auto-login |
| [**EMIsSysAdmin**](EMProxyApi.md#emissysadmin) | **POST** /EM_IsSysAdmin | Proxy call to EM Authenticate.asmx             public bool IsSysAdmin(string Token) |
| [**EMLogOff**](EMProxyApi.md#emlogoff) | **POST** /EM_LogOff | Proxy call to EM Authenticate.asmx             public void Logout(string Token)             Logs the user associated with the token provided out of the system. |
| [**EMPauseDeployment**](EMProxyApi.md#empausedeployment) | **POST** /EM_PauseDeployment | Proxy call to EM UserManager.asmx to pause a deployment |
| [**EMPrimaryKeys**](EMProxyApi.md#emprimarykeys) | **POST** /EM_PrimaryKeys | Returns back the primary keys for a specific EM client |
| [**EMSetEMServiceURL**](EMProxyApi.md#emsetemserviceurl) | **POST** /EM_SetEMServiceURL | Sets the URL used to connect to the EM instance |
| [**EMTestEMServiceURL**](EMProxyApi.md#emtestemserviceurl) | **POST** /EM_TestEMServiceURL | Tests the EM Service URL |

<a id="emabortdeployment"></a>
# **EMAbortDeployment**
> AUTHChangePasswordDefaultResponse EMAbortDeployment (EMAbortDeploymentRequest eMAbortDeploymentRequest)

Proxy call to EM UserManager.asmx to abort a deployment

Proxy call to EM UserManager.asmx to abort a deployment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMAbortDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMAbortDeploymentRequest = new EMAbortDeploymentRequest(); // EMAbortDeploymentRequest | Proxy call to EM UserManager.asmx to abort a deployment

            try
            {
                // Proxy call to EM UserManager.asmx to abort a deployment
                AUTHChangePasswordDefaultResponse result = apiInstance.EMAbortDeployment(eMAbortDeploymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMAbortDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMAbortDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM UserManager.asmx to abort a deployment
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EMAbortDeploymentWithHttpInfo(eMAbortDeploymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMAbortDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMAbortDeploymentRequest** | [**EMAbortDeploymentRequest**](EMAbortDeploymentRequest.md) | Proxy call to EM UserManager.asmx to abort a deployment |  |

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

<a id="emauthenticate"></a>
# **EMAuthenticate**
> GetDataSourceEngineUserNameDefaultResponse EMAuthenticate (EMAuthenticateRequest eMAuthenticateRequest)

Proxy call to EM Authenticate.asmx             public string AuthenticateEx(string Login, string Password, string NewPassword, bool BumpExisting, DateTime LocalTime, DMPasswordFormat PasswordFormat)

Proxy call to EM Authenticate.asmx             public string AuthenticateEx(string Login, string Password, string NewPassword, bool BumpExisting, DateTime LocalTime, DMPasswordFormat PasswordFormat)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMAuthenticateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMAuthenticateRequest = new EMAuthenticateRequest(); // EMAuthenticateRequest | Proxy call to EM Authenticate.asmx             public string AuthenticateEx(string Login, string Password, string NewPassword, bool BumpExisting, DateTime LocalTime, DMPasswordFormat PasswordFormat)

            try
            {
                // Proxy call to EM Authenticate.asmx             public string AuthenticateEx(string Login, string Password, string NewPassword, bool BumpExisting, DateTime LocalTime, DMPasswordFormat PasswordFormat)
                GetDataSourceEngineUserNameDefaultResponse result = apiInstance.EMAuthenticate(eMAuthenticateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMAuthenticate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMAuthenticateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM Authenticate.asmx             public string AuthenticateEx(string Login, string Password, string NewPassword, bool BumpExisting, DateTime LocalTime, DMPasswordFormat PasswordFormat)
    ApiResponse<GetDataSourceEngineUserNameDefaultResponse> response = apiInstance.EMAuthenticateWithHttpInfo(eMAuthenticateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMAuthenticateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMAuthenticateRequest** | [**EMAuthenticateRequest**](EMAuthenticateRequest.md) | Proxy call to EM Authenticate.asmx             public string AuthenticateEx(string Login, string Password, string NewPassword, bool BumpExisting, DateTime LocalTime, DMPasswordFormat PasswordFormat) |  |

### Return type

[**GetDataSourceEngineUserNameDefaultResponse**](GetDataSourceEngineUserNameDefaultResponse.md)

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

<a id="emdeletelist"></a>
# **EMDeleteList**
> AUTHChangePasswordDefaultResponse EMDeleteList (EMDeleteListRequest eMDeleteListRequest)

Deletes a list

Deletes a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMDeleteListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMDeleteListRequest = new EMDeleteListRequest(); // EMDeleteListRequest | Deletes a list

            try
            {
                // Deletes a list
                AUTHChangePasswordDefaultResponse result = apiInstance.EMDeleteList(eMDeleteListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMDeleteList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMDeleteListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a list
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EMDeleteListWithHttpInfo(eMDeleteListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMDeleteListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMDeleteListRequest** | [**EMDeleteListRequest**](EMDeleteListRequest.md) | Deletes a list |  |

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

<a id="emgetclientgroupusers"></a>
# **EMGetClientGroupUsers**
> EMGetClientGroupUsersDefaultResponse EMGetClientGroupUsers (EMGetClientGroupUsersRequest eMGetClientGroupUsersRequest)

Proxy call to EM UserManager.asmx             public DMUserCollection GetClientGroupUsers(string Token, DMClient Client, int GroupID)

Proxy call to EM UserManager.asmx             public DMUserCollection GetClientGroupUsers(string Token, DMClient Client, int GroupID)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetClientGroupUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetClientGroupUsersRequest = new EMGetClientGroupUsersRequest(); // EMGetClientGroupUsersRequest | Proxy call to EM UserManager.asmx             public DMUserCollection GetClientGroupUsers(string Token, DMClient Client, int GroupID)

            try
            {
                // Proxy call to EM UserManager.asmx             public DMUserCollection GetClientGroupUsers(string Token, DMClient Client, int GroupID)
                EMGetClientGroupUsersDefaultResponse result = apiInstance.EMGetClientGroupUsers(eMGetClientGroupUsersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetClientGroupUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetClientGroupUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM UserManager.asmx             public DMUserCollection GetClientGroupUsers(string Token, DMClient Client, int GroupID)
    ApiResponse<EMGetClientGroupUsersDefaultResponse> response = apiInstance.EMGetClientGroupUsersWithHttpInfo(eMGetClientGroupUsersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetClientGroupUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetClientGroupUsersRequest** | [**EMGetClientGroupUsersRequest**](EMGetClientGroupUsersRequest.md) | Proxy call to EM UserManager.asmx             public DMUserCollection GetClientGroupUsers(string Token, DMClient Client, int GroupID) |  |

### Return type

[**EMGetClientGroupUsersDefaultResponse**](EMGetClientGroupUsersDefaultResponse.md)

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

<a id="emgetclientgroups"></a>
# **EMGetClientGroups**
> EMGetClientGroupsDefaultResponse EMGetClientGroups (EMGetClientGroupsRequest eMGetClientGroupsRequest)

Proxy call to the EM UserManager.asmx              DMGroupCollection GetClientGroups(string Token, DMClient Client, out DMNestedGroupCollection Nested)

Proxy call to the EM UserManager.asmx              DMGroupCollection GetClientGroups(string Token, DMClient Client, out DMNestedGroupCollection Nested)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetClientGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetClientGroupsRequest = new EMGetClientGroupsRequest(); // EMGetClientGroupsRequest | Proxy call to the EM UserManager.asmx              DMGroupCollection GetClientGroups(string Token, DMClient Client, out DMNestedGroupCollection Nested)

            try
            {
                // Proxy call to the EM UserManager.asmx              DMGroupCollection GetClientGroups(string Token, DMClient Client, out DMNestedGroupCollection Nested)
                EMGetClientGroupsDefaultResponse result = apiInstance.EMGetClientGroups(eMGetClientGroupsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetClientGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetClientGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to the EM UserManager.asmx              DMGroupCollection GetClientGroups(string Token, DMClient Client, out DMNestedGroupCollection Nested)
    ApiResponse<EMGetClientGroupsDefaultResponse> response = apiInstance.EMGetClientGroupsWithHttpInfo(eMGetClientGroupsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetClientGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetClientGroupsRequest** | [**EMGetClientGroupsRequest**](EMGetClientGroupsRequest.md) | Proxy call to the EM UserManager.asmx              DMGroupCollection GetClientGroups(string Token, DMClient Client, out DMNestedGroupCollection Nested) |  |

### Return type

[**EMGetClientGroupsDefaultResponse**](EMGetClientGroupsDefaultResponse.md)

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

<a id="emgetclientinfo"></a>
# **EMGetClientInfo**
> EMGetClientInfoDefaultResponse EMGetClientInfo (EMGetClientInfoRequest eMGetClientInfoRequest)

Proxy call to EM Authenticate.asmx             public void GetClientInfo(string Token, out int ID, out string Name, out string ContentURL, out string Icon)

Proxy call to EM Authenticate.asmx             public void GetClientInfo(string Token, out int ID, out string Name, out string ContentURL, out string Icon)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetClientInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetClientInfoRequest = new EMGetClientInfoRequest(); // EMGetClientInfoRequest | Proxy call to EM Authenticate.asmx             public void GetClientInfo(string Token, out int ID, out string Name, out string ContentURL, out string Icon)

            try
            {
                // Proxy call to EM Authenticate.asmx             public void GetClientInfo(string Token, out int ID, out string Name, out string ContentURL, out string Icon)
                EMGetClientInfoDefaultResponse result = apiInstance.EMGetClientInfo(eMGetClientInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetClientInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetClientInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM Authenticate.asmx             public void GetClientInfo(string Token, out int ID, out string Name, out string ContentURL, out string Icon)
    ApiResponse<EMGetClientInfoDefaultResponse> response = apiInstance.EMGetClientInfoWithHttpInfo(eMGetClientInfoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetClientInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetClientInfoRequest** | [**EMGetClientInfoRequest**](EMGetClientInfoRequest.md) | Proxy call to EM Authenticate.asmx             public void GetClientInfo(string Token, out int ID, out string Name, out string ContentURL, out string Icon) |  |

### Return type

[**EMGetClientInfoDefaultResponse**](EMGetClientInfoDefaultResponse.md)

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

<a id="emgetclientsets"></a>
# **EMGetClientSets**
> EMGetClientSetsDefaultResponse EMGetClientSets (EMGetClientSetsRequest eMGetClientSetsRequest)

Proxy call to EM ClientManager.asmx             public DMClientSetCollection GetClientSets(string Token)

Proxy call to EM ClientManager.asmx             public DMClientSetCollection GetClientSets(string Token)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetClientSetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetClientSetsRequest = new EMGetClientSetsRequest(); // EMGetClientSetsRequest | Proxy call to EM ClientManager.asmx             public DMClientSetCollection GetClientSets(string Token)

            try
            {
                // Proxy call to EM ClientManager.asmx             public DMClientSetCollection GetClientSets(string Token)
                EMGetClientSetsDefaultResponse result = apiInstance.EMGetClientSets(eMGetClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetClientSets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetClientSetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM ClientManager.asmx             public DMClientSetCollection GetClientSets(string Token)
    ApiResponse<EMGetClientSetsDefaultResponse> response = apiInstance.EMGetClientSetsWithHttpInfo(eMGetClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetClientSetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetClientSetsRequest** | [**EMGetClientSetsRequest**](EMGetClientSetsRequest.md) | Proxy call to EM ClientManager.asmx             public DMClientSetCollection GetClientSets(string Token) |  |

### Return type

[**EMGetClientSetsDefaultResponse**](EMGetClientSetsDefaultResponse.md)

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

<a id="emgetcreative"></a>
# **EMGetCreative**
> EMGetCreativeDefaultResponse EMGetCreative (EMGetCreativeRequest eMGetCreativeRequest)

Proxy call to get EM creative

Proxy call to get EM creative

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetCreativeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetCreativeRequest = new EMGetCreativeRequest(); // EMGetCreativeRequest | Proxy call to get EM creative

            try
            {
                // Proxy call to get EM creative
                EMGetCreativeDefaultResponse result = apiInstance.EMGetCreative(eMGetCreativeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetCreative: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetCreativeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to get EM creative
    ApiResponse<EMGetCreativeDefaultResponse> response = apiInstance.EMGetCreativeWithHttpInfo(eMGetCreativeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetCreativeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetCreativeRequest** | [**EMGetCreativeRequest**](EMGetCreativeRequest.md) | Proxy call to get EM creative |  |

### Return type

[**EMGetCreativeDefaultResponse**](EMGetCreativeDefaultResponse.md)

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

<a id="emgetcreativefields"></a>
# **EMGetCreativeFields**
> EMGetCreativeFieldsDefaultResponse EMGetCreativeFields (EMGetCreativeRequest eMGetCreativeRequest)

Proxy call to get EM creative fields

Proxy call to get EM creative fields

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetCreativeFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetCreativeRequest = new EMGetCreativeRequest(); // EMGetCreativeRequest | Proxy call to get EM creative fields

            try
            {
                // Proxy call to get EM creative fields
                EMGetCreativeFieldsDefaultResponse result = apiInstance.EMGetCreativeFields(eMGetCreativeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetCreativeFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetCreativeFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to get EM creative fields
    ApiResponse<EMGetCreativeFieldsDefaultResponse> response = apiInstance.EMGetCreativeFieldsWithHttpInfo(eMGetCreativeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetCreativeFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetCreativeRequest** | [**EMGetCreativeRequest**](EMGetCreativeRequest.md) | Proxy call to get EM creative fields |  |

### Return type

[**EMGetCreativeFieldsDefaultResponse**](EMGetCreativeFieldsDefaultResponse.md)

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

<a id="emgetcreatives"></a>
# **EMGetCreatives**
> EMGetCreativesDefaultResponse EMGetCreatives (EMGetCreativesRequest eMGetCreativesRequest)

Proxy call to get EM creatives

Proxy call to get EM creatives

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetCreativesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetCreativesRequest = new EMGetCreativesRequest(); // EMGetCreativesRequest | Proxy call to get EM creatives

            try
            {
                // Proxy call to get EM creatives
                EMGetCreativesDefaultResponse result = apiInstance.EMGetCreatives(eMGetCreativesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetCreatives: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetCreativesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to get EM creatives
    ApiResponse<EMGetCreativesDefaultResponse> response = apiInstance.EMGetCreativesWithHttpInfo(eMGetCreativesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetCreativesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetCreativesRequest** | [**EMGetCreativesRequest**](EMGetCreativesRequest.md) | Proxy call to get EM creatives |  |

### Return type

[**EMGetCreativesDefaultResponse**](EMGetCreativesDefaultResponse.md)

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

<a id="emgetemserviceurl"></a>
# **EMGetEMServiceURL**
> GetDataSourceEngineUserNameDefaultResponse EMGetEMServiceURL (EMGetEMServiceURLRequest eMGetEMServiceURLRequest)

Returns back the EM Service URL for the siteID requested.

Returns back the EM Service URL for the siteID requested.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetEMServiceURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetEMServiceURLRequest = new EMGetEMServiceURLRequest(); // EMGetEMServiceURLRequest | Returns back the EM Service URL for the siteID requested.

            try
            {
                // Returns back the EM Service URL for the siteID requested.
                GetDataSourceEngineUserNameDefaultResponse result = apiInstance.EMGetEMServiceURL(eMGetEMServiceURLRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetEMServiceURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetEMServiceURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back the EM Service URL for the siteID requested.
    ApiResponse<GetDataSourceEngineUserNameDefaultResponse> response = apiInstance.EMGetEMServiceURLWithHttpInfo(eMGetEMServiceURLRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetEMServiceURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetEMServiceURLRequest** | [**EMGetEMServiceURLRequest**](EMGetEMServiceURLRequest.md) | Returns back the EM Service URL for the siteID requested. |  |

### Return type

[**GetDataSourceEngineUserNameDefaultResponse**](GetDataSourceEngineUserNameDefaultResponse.md)

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

<a id="emgetemailvalidationexpression"></a>
# **EMGetEmailValidationExpression**
> GetDataSourceEngineUserNameDefaultResponse EMGetEmailValidationExpression ()

Return the regular expression string used to validate an email address. This is the same expression used by Email Manager.

Return the regular expression string used to validate an email address. This is the same expression used by Email Manager.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetEmailValidationExpressionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);

            try
            {
                // Return the regular expression string used to validate an email address. This is the same expression used by Email Manager.
                GetDataSourceEngineUserNameDefaultResponse result = apiInstance.EMGetEmailValidationExpression();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetEmailValidationExpression: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetEmailValidationExpressionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return the regular expression string used to validate an email address. This is the same expression used by Email Manager.
    ApiResponse<GetDataSourceEngineUserNameDefaultResponse> response = apiInstance.EMGetEmailValidationExpressionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetEmailValidationExpressionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetDataSourceEngineUserNameDefaultResponse**](GetDataSourceEngineUserNameDefaultResponse.md)

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

<a id="emgetfolderslazy"></a>
# **EMGetFoldersLazy**
> EMGetFoldersLazyDefaultResponse EMGetFoldersLazy (EMGetFoldersLazyRequest eMGetFoldersLazyRequest)

Returns an object containing the list of folders in the specified folder, together with a string representation of the folder hierarchy.

Returns an object containing the list of folders in the specified folder, together with a string representation of the folder hierarchy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetFoldersLazyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetFoldersLazyRequest = new EMGetFoldersLazyRequest(); // EMGetFoldersLazyRequest | Returns an object containing the list of folders in the specified folder, together with a string representation of the folder hierarchy.

            try
            {
                // Returns an object containing the list of folders in the specified folder, together with a string representation of the folder hierarchy.
                EMGetFoldersLazyDefaultResponse result = apiInstance.EMGetFoldersLazy(eMGetFoldersLazyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetFoldersLazy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetFoldersLazyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns an object containing the list of folders in the specified folder, together with a string representation of the folder hierarchy.
    ApiResponse<EMGetFoldersLazyDefaultResponse> response = apiInstance.EMGetFoldersLazyWithHttpInfo(eMGetFoldersLazyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetFoldersLazyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetFoldersLazyRequest** | [**EMGetFoldersLazyRequest**](EMGetFoldersLazyRequest.md) | Returns an object containing the list of folders in the specified folder, together with a string representation of the folder hierarchy. |  |

### Return type

[**EMGetFoldersLazyDefaultResponse**](EMGetFoldersLazyDefaultResponse.md)

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

<a id="emgetinboundaddresses"></a>
# **EMGetInboundAddresses**
> EMGetInboundAddressesDefaultResponse EMGetInboundAddresses (EMGetInboundAddressesRequest eMGetInboundAddressesRequest)

Proxy call to get inbound addresses

Proxy call to get inbound addresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetInboundAddressesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetInboundAddressesRequest = new EMGetInboundAddressesRequest(); // EMGetInboundAddressesRequest | Proxy call to get inbound addresses

            try
            {
                // Proxy call to get inbound addresses
                EMGetInboundAddressesDefaultResponse result = apiInstance.EMGetInboundAddresses(eMGetInboundAddressesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetInboundAddresses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetInboundAddressesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to get inbound addresses
    ApiResponse<EMGetInboundAddressesDefaultResponse> response = apiInstance.EMGetInboundAddressesWithHttpInfo(eMGetInboundAddressesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetInboundAddressesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetInboundAddressesRequest** | [**EMGetInboundAddressesRequest**](EMGetInboundAddressesRequest.md) | Proxy call to get inbound addresses |  |

### Return type

[**EMGetInboundAddressesDefaultResponse**](EMGetInboundAddressesDefaultResponse.md)

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

<a id="emgettemplatecontent"></a>
# **EMGetTemplateContent**
> GetDataSourceEngineUserNameDefaultResponse EMGetTemplateContent (EMGetTemplateContentRequest eMGetTemplateContentRequest)

Proxy call to get EM template content

Proxy call to get EM template content

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetTemplateContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetTemplateContentRequest = new EMGetTemplateContentRequest(); // EMGetTemplateContentRequest | Proxy call to get EM template content

            try
            {
                // Proxy call to get EM template content
                GetDataSourceEngineUserNameDefaultResponse result = apiInstance.EMGetTemplateContent(eMGetTemplateContentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetTemplateContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetTemplateContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to get EM template content
    ApiResponse<GetDataSourceEngineUserNameDefaultResponse> response = apiInstance.EMGetTemplateContentWithHttpInfo(eMGetTemplateContentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetTemplateContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetTemplateContentRequest** | [**EMGetTemplateContentRequest**](EMGetTemplateContentRequest.md) | Proxy call to get EM template content |  |

### Return type

[**GetDataSourceEngineUserNameDefaultResponse**](GetDataSourceEngineUserNameDefaultResponse.md)

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

<a id="emgetusers"></a>
# **EMGetUsers**
> EMGetClientGroupUsersDefaultResponse EMGetUsers (EMGetUsersRequest eMGetUsersRequest)

Proxy call to EM UserManager.asmx             public List(DMUser) GetUsers(string Token) Can use with existing EMToken or supply mapping Id for auto-login

Proxy call to EM UserManager.asmx             public List(DMUser) GetUsers(string Token) Can use with existing EMToken or supply mapping Id for auto-login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMGetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetUsersRequest = new EMGetUsersRequest(); // EMGetUsersRequest | Proxy call to EM UserManager.asmx             public List(DMUser) GetUsers(string Token) Can use with existing EMToken or supply mapping Id for auto-login

            try
            {
                // Proxy call to EM UserManager.asmx             public List(DMUser) GetUsers(string Token) Can use with existing EMToken or supply mapping Id for auto-login
                EMGetClientGroupUsersDefaultResponse result = apiInstance.EMGetUsers(eMGetUsersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMGetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMGetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM UserManager.asmx             public List(DMUser) GetUsers(string Token) Can use with existing EMToken or supply mapping Id for auto-login
    ApiResponse<EMGetClientGroupUsersDefaultResponse> response = apiInstance.EMGetUsersWithHttpInfo(eMGetUsersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMGetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetUsersRequest** | [**EMGetUsersRequest**](EMGetUsersRequest.md) | Proxy call to EM UserManager.asmx             public List(DMUser) GetUsers(string Token) Can use with existing EMToken or supply mapping Id for auto-login |  |

### Return type

[**EMGetClientGroupUsersDefaultResponse**](EMGetClientGroupUsersDefaultResponse.md)

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

<a id="emissysadmin"></a>
# **EMIsSysAdmin**
> AUTHChangePasswordDefaultResponse EMIsSysAdmin (EMGetClientInfoRequest eMGetClientInfoRequest)

Proxy call to EM Authenticate.asmx             public bool IsSysAdmin(string Token)

Proxy call to EM Authenticate.asmx             public bool IsSysAdmin(string Token)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMIsSysAdminExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMGetClientInfoRequest = new EMGetClientInfoRequest(); // EMGetClientInfoRequest | Proxy call to EM Authenticate.asmx             public bool IsSysAdmin(string Token)

            try
            {
                // Proxy call to EM Authenticate.asmx             public bool IsSysAdmin(string Token)
                AUTHChangePasswordDefaultResponse result = apiInstance.EMIsSysAdmin(eMGetClientInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMIsSysAdmin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMIsSysAdminWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM Authenticate.asmx             public bool IsSysAdmin(string Token)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EMIsSysAdminWithHttpInfo(eMGetClientInfoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMIsSysAdminWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMGetClientInfoRequest** | [**EMGetClientInfoRequest**](EMGetClientInfoRequest.md) | Proxy call to EM Authenticate.asmx             public bool IsSysAdmin(string Token) |  |

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

<a id="emlogoff"></a>
# **EMLogOff**
> AUTHChangePasswordDefaultResponse EMLogOff (EMLogOffRequest eMLogOffRequest)

Proxy call to EM Authenticate.asmx             public void Logout(string Token)             Logs the user associated with the token provided out of the system.

Proxy call to EM Authenticate.asmx             public void Logout(string Token)             Logs the user associated with the token provided out of the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMLogOffExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMLogOffRequest = new EMLogOffRequest(); // EMLogOffRequest | Proxy call to EM Authenticate.asmx             public void Logout(string Token)             Logs the user associated with the token provided out of the system.

            try
            {
                // Proxy call to EM Authenticate.asmx             public void Logout(string Token)             Logs the user associated with the token provided out of the system.
                AUTHChangePasswordDefaultResponse result = apiInstance.EMLogOff(eMLogOffRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMLogOff: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMLogOffWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM Authenticate.asmx             public void Logout(string Token)             Logs the user associated with the token provided out of the system.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EMLogOffWithHttpInfo(eMLogOffRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMLogOffWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMLogOffRequest** | [**EMLogOffRequest**](EMLogOffRequest.md) | Proxy call to EM Authenticate.asmx             public void Logout(string Token)             Logs the user associated with the token provided out of the system. |  |

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

<a id="empausedeployment"></a>
# **EMPauseDeployment**
> AUTHChangePasswordDefaultResponse EMPauseDeployment (EMPauseDeploymentRequest eMPauseDeploymentRequest)

Proxy call to EM UserManager.asmx to pause a deployment

Proxy call to EM UserManager.asmx to pause a deployment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMPauseDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMPauseDeploymentRequest = new EMPauseDeploymentRequest(); // EMPauseDeploymentRequest | Proxy call to EM UserManager.asmx to pause a deployment

            try
            {
                // Proxy call to EM UserManager.asmx to pause a deployment
                AUTHChangePasswordDefaultResponse result = apiInstance.EMPauseDeployment(eMPauseDeploymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMPauseDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMPauseDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Proxy call to EM UserManager.asmx to pause a deployment
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EMPauseDeploymentWithHttpInfo(eMPauseDeploymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMPauseDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMPauseDeploymentRequest** | [**EMPauseDeploymentRequest**](EMPauseDeploymentRequest.md) | Proxy call to EM UserManager.asmx to pause a deployment |  |

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

<a id="emprimarykeys"></a>
# **EMPrimaryKeys**
> EMPrimaryKeysDefaultResponse EMPrimaryKeys (EMPrimaryKeysRequest eMPrimaryKeysRequest)

Returns back the primary keys for a specific EM client

Returns back the primary keys for a specific EM client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMPrimaryKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMPrimaryKeysRequest = new EMPrimaryKeysRequest(); // EMPrimaryKeysRequest | Returns back the primary keys for a specific EM client

            try
            {
                // Returns back the primary keys for a specific EM client
                EMPrimaryKeysDefaultResponse result = apiInstance.EMPrimaryKeys(eMPrimaryKeysRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMPrimaryKeys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMPrimaryKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back the primary keys for a specific EM client
    ApiResponse<EMPrimaryKeysDefaultResponse> response = apiInstance.EMPrimaryKeysWithHttpInfo(eMPrimaryKeysRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMPrimaryKeysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMPrimaryKeysRequest** | [**EMPrimaryKeysRequest**](EMPrimaryKeysRequest.md) | Returns back the primary keys for a specific EM client |  |

### Return type

[**EMPrimaryKeysDefaultResponse**](EMPrimaryKeysDefaultResponse.md)

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

<a id="emsetemserviceurl"></a>
# **EMSetEMServiceURL**
> AUTHChangePasswordDefaultResponse EMSetEMServiceURL (EMSetEMServiceURLRequest eMSetEMServiceURLRequest)

Sets the URL used to connect to the EM instance

Sets the URL used to connect to the EM instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMSetEMServiceURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMSetEMServiceURLRequest = new EMSetEMServiceURLRequest(); // EMSetEMServiceURLRequest | Sets the URL used to connect to the EM instance

            try
            {
                // Sets the URL used to connect to the EM instance
                AUTHChangePasswordDefaultResponse result = apiInstance.EMSetEMServiceURL(eMSetEMServiceURLRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMSetEMServiceURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMSetEMServiceURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the URL used to connect to the EM instance
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EMSetEMServiceURLWithHttpInfo(eMSetEMServiceURLRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMSetEMServiceURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMSetEMServiceURLRequest** | [**EMSetEMServiceURLRequest**](EMSetEMServiceURLRequest.md) | Sets the URL used to connect to the EM instance |  |

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

<a id="emtestemserviceurl"></a>
# **EMTestEMServiceURL**
> AUTHChangePasswordDefaultResponse EMTestEMServiceURL (EMTestEMServiceURLRequest eMTestEMServiceURLRequest)

Tests the EM Service URL

Tests the EM Service URL

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EMTestEMServiceURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EMProxyApi(config);
            var eMTestEMServiceURLRequest = new EMTestEMServiceURLRequest(); // EMTestEMServiceURLRequest | Tests the EM Service URL

            try
            {
                // Tests the EM Service URL
                AUTHChangePasswordDefaultResponse result = apiInstance.EMTestEMServiceURL(eMTestEMServiceURLRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EMProxyApi.EMTestEMServiceURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EMTestEMServiceURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tests the EM Service URL
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EMTestEMServiceURLWithHttpInfo(eMTestEMServiceURLRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EMProxyApi.EMTestEMServiceURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eMTestEMServiceURLRequest** | [**EMTestEMServiceURLRequest**](EMTestEMServiceURLRequest.md) | Tests the EM Service URL |  |

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

