# Alterian.JA.Api.AuthServerApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AUTHChangePassword**](AuthServerApi.md#authchangepassword) | **POST** /AUTH_ChangePassword | Set a new password for tthe specified login |
| [**AUTHCreateLogin**](AuthServerApi.md#authcreatelogin) | **POST** /AUTH_CreateLogin | Creates a login and associates it with the client |
| [**AUTHDisableLogin**](AuthServerApi.md#authdisablelogin) | **POST** /AUTH_DisableLogin | Disable the specified login |
| [**AUTHEnableLogin**](AuthServerApi.md#authenablelogin) | **POST** /AUTH_EnableLogin | Enable the specified login |
| [**AUTHExpirePassword**](AuthServerApi.md#authexpirepassword) | **POST** /AUTH_ExpirePassword | Expire the password for the specified login |
| [**AUTHGetClientLogins**](AuthServerApi.md#authgetclientlogins) | **POST** /AUTH_GetClientLogins | Get a list of logins from the authentication system which are currently assigned to the token&#39;s client |
| [**AUTHGetLoginPasswordRules**](AuthServerApi.md#authgetloginpasswordrules) | **POST** /AUTH_GetLoginPasswordRules | Request the password policy rules from the authentication system |
| [**AUTHGetLogins**](AuthServerApi.md#authgetlogins) | **POST** /AUTH_GetLogins | Get a list of logins from the authentication system which are currently assigned to the token&#39;s client and have no user associated with them |
| [**AUTHGetLoginsForUser**](AuthServerApi.md#authgetloginsforuser) | **POST** /AUTH_GetLoginsForUser | Returns back the login(s) associated with a particular userid and siteid |
| [**AUTHRenameLogin**](AuthServerApi.md#authrenamelogin) | **POST** /AUTH_RenameLogin | Rename the specified login |
| [**AUTHSetLoginUserId**](AuthServerApi.md#authsetloginuserid) | **POST** /AUTH_SetLoginUserId | Associates an auth system login with a CM user ID |
| [**AUTHUpdateLogin**](AuthServerApi.md#authupdatelogin) | **POST** /AUTH_UpdateLogin | Updates the important components of a login, use expire, etc. to expire or delete a login |

<a id="authchangepassword"></a>
# **AUTHChangePassword**
> AUTHChangePasswordDefaultResponse AUTHChangePassword (AUTHChangePasswordRequest aUTHChangePasswordRequest)

Set a new password for tthe specified login

Set a new password for tthe specified login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHChangePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHChangePasswordRequest = new AUTHChangePasswordRequest(); // AUTHChangePasswordRequest | Set a new password for tthe specified login

            try
            {
                // Set a new password for tthe specified login
                AUTHChangePasswordDefaultResponse result = apiInstance.AUTHChangePassword(aUTHChangePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHChangePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHChangePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a new password for tthe specified login
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AUTHChangePasswordWithHttpInfo(aUTHChangePasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHChangePasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHChangePasswordRequest** | [**AUTHChangePasswordRequest**](AUTHChangePasswordRequest.md) | Set a new password for tthe specified login |  |

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

<a id="authcreatelogin"></a>
# **AUTHCreateLogin**
> AUTHCreateLoginDefaultResponse AUTHCreateLogin (AUTHCreateLoginRequest aUTHCreateLoginRequest)

Creates a login and associates it with the client

Creates a login and associates it with the client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHCreateLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHCreateLoginRequest = new AUTHCreateLoginRequest(); // AUTHCreateLoginRequest | Creates a login and associates it with the client

            try
            {
                // Creates a login and associates it with the client
                AUTHCreateLoginDefaultResponse result = apiInstance.AUTHCreateLogin(aUTHCreateLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHCreateLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHCreateLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a login and associates it with the client
    ApiResponse<AUTHCreateLoginDefaultResponse> response = apiInstance.AUTHCreateLoginWithHttpInfo(aUTHCreateLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHCreateLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHCreateLoginRequest** | [**AUTHCreateLoginRequest**](AUTHCreateLoginRequest.md) | Creates a login and associates it with the client |  |

### Return type

[**AUTHCreateLoginDefaultResponse**](AUTHCreateLoginDefaultResponse.md)

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

<a id="authdisablelogin"></a>
# **AUTHDisableLogin**
> AUTHChangePasswordDefaultResponse AUTHDisableLogin (AUTHDisableLoginRequest aUTHDisableLoginRequest)

Disable the specified login

Disable the specified login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHDisableLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHDisableLoginRequest = new AUTHDisableLoginRequest(); // AUTHDisableLoginRequest | Disable the specified login

            try
            {
                // Disable the specified login
                AUTHChangePasswordDefaultResponse result = apiInstance.AUTHDisableLogin(aUTHDisableLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHDisableLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHDisableLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable the specified login
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AUTHDisableLoginWithHttpInfo(aUTHDisableLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHDisableLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHDisableLoginRequest** | [**AUTHDisableLoginRequest**](AUTHDisableLoginRequest.md) | Disable the specified login |  |

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

<a id="authenablelogin"></a>
# **AUTHEnableLogin**
> AUTHChangePasswordDefaultResponse AUTHEnableLogin (AUTHDisableLoginRequest aUTHDisableLoginRequest)

Enable the specified login

Enable the specified login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHEnableLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHDisableLoginRequest = new AUTHDisableLoginRequest(); // AUTHDisableLoginRequest | Enable the specified login

            try
            {
                // Enable the specified login
                AUTHChangePasswordDefaultResponse result = apiInstance.AUTHEnableLogin(aUTHDisableLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHEnableLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHEnableLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable the specified login
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AUTHEnableLoginWithHttpInfo(aUTHDisableLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHEnableLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHDisableLoginRequest** | [**AUTHDisableLoginRequest**](AUTHDisableLoginRequest.md) | Enable the specified login |  |

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

<a id="authexpirepassword"></a>
# **AUTHExpirePassword**
> AUTHChangePasswordDefaultResponse AUTHExpirePassword (AUTHDisableLoginRequest aUTHDisableLoginRequest)

Expire the password for the specified login

Expire the password for the specified login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHExpirePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHDisableLoginRequest = new AUTHDisableLoginRequest(); // AUTHDisableLoginRequest | Expire the password for the specified login

            try
            {
                // Expire the password for the specified login
                AUTHChangePasswordDefaultResponse result = apiInstance.AUTHExpirePassword(aUTHDisableLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHExpirePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHExpirePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Expire the password for the specified login
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AUTHExpirePasswordWithHttpInfo(aUTHDisableLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHExpirePasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHDisableLoginRequest** | [**AUTHDisableLoginRequest**](AUTHDisableLoginRequest.md) | Expire the password for the specified login |  |

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

<a id="authgetclientlogins"></a>
# **AUTHGetClientLogins**
> AUTHGetClientLoginsDefaultResponse AUTHGetClientLogins (AUTHGetClientLoginsRequest aUTHGetClientLoginsRequest)

Get a list of logins from the authentication system which are currently assigned to the token's client

Get a list of logins from the authentication system which are currently assigned to the token's client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHGetClientLoginsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHGetClientLoginsRequest = new AUTHGetClientLoginsRequest(); // AUTHGetClientLoginsRequest | Get a list of logins from the authentication system which are currently assigned to the token's client

            try
            {
                // Get a list of logins from the authentication system which are currently assigned to the token's client
                AUTHGetClientLoginsDefaultResponse result = apiInstance.AUTHGetClientLogins(aUTHGetClientLoginsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHGetClientLogins: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHGetClientLoginsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of logins from the authentication system which are currently assigned to the token's client
    ApiResponse<AUTHGetClientLoginsDefaultResponse> response = apiInstance.AUTHGetClientLoginsWithHttpInfo(aUTHGetClientLoginsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHGetClientLoginsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHGetClientLoginsRequest** | [**AUTHGetClientLoginsRequest**](AUTHGetClientLoginsRequest.md) | Get a list of logins from the authentication system which are currently assigned to the token&#39;s client |  |

### Return type

[**AUTHGetClientLoginsDefaultResponse**](AUTHGetClientLoginsDefaultResponse.md)

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

<a id="authgetloginpasswordrules"></a>
# **AUTHGetLoginPasswordRules**
> AUTHGetLoginPasswordRulesDefaultResponse AUTHGetLoginPasswordRules (AUTHGetLoginPasswordRulesRequest aUTHGetLoginPasswordRulesRequest)

Request the password policy rules from the authentication system

Request the password policy rules from the authentication system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHGetLoginPasswordRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHGetLoginPasswordRulesRequest = new AUTHGetLoginPasswordRulesRequest(); // AUTHGetLoginPasswordRulesRequest | Request the password policy rules from the authentication system

            try
            {
                // Request the password policy rules from the authentication system
                AUTHGetLoginPasswordRulesDefaultResponse result = apiInstance.AUTHGetLoginPasswordRules(aUTHGetLoginPasswordRulesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHGetLoginPasswordRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHGetLoginPasswordRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request the password policy rules from the authentication system
    ApiResponse<AUTHGetLoginPasswordRulesDefaultResponse> response = apiInstance.AUTHGetLoginPasswordRulesWithHttpInfo(aUTHGetLoginPasswordRulesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHGetLoginPasswordRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHGetLoginPasswordRulesRequest** | [**AUTHGetLoginPasswordRulesRequest**](AUTHGetLoginPasswordRulesRequest.md) | Request the password policy rules from the authentication system |  |

### Return type

[**AUTHGetLoginPasswordRulesDefaultResponse**](AUTHGetLoginPasswordRulesDefaultResponse.md)

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

<a id="authgetlogins"></a>
# **AUTHGetLogins**
> AUTHGetClientLoginsDefaultResponse AUTHGetLogins (AUTHGetLoginsRequest aUTHGetLoginsRequest)

Get a list of logins from the authentication system which are currently assigned to the token's client and have no user associated with them

Get a list of logins from the authentication system which are currently assigned to the token's client and have no user associated with them

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHGetLoginsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHGetLoginsRequest = new AUTHGetLoginsRequest(); // AUTHGetLoginsRequest | Get a list of logins from the authentication system which are currently assigned to the token's client and have no user associated with them

            try
            {
                // Get a list of logins from the authentication system which are currently assigned to the token's client and have no user associated with them
                AUTHGetClientLoginsDefaultResponse result = apiInstance.AUTHGetLogins(aUTHGetLoginsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHGetLogins: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHGetLoginsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of logins from the authentication system which are currently assigned to the token's client and have no user associated with them
    ApiResponse<AUTHGetClientLoginsDefaultResponse> response = apiInstance.AUTHGetLoginsWithHttpInfo(aUTHGetLoginsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHGetLoginsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHGetLoginsRequest** | [**AUTHGetLoginsRequest**](AUTHGetLoginsRequest.md) | Get a list of logins from the authentication system which are currently assigned to the token&#39;s client and have no user associated with them |  |

### Return type

[**AUTHGetClientLoginsDefaultResponse**](AUTHGetClientLoginsDefaultResponse.md)

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

<a id="authgetloginsforuser"></a>
# **AUTHGetLoginsForUser**
> AUTHGetClientLoginsDefaultResponse AUTHGetLoginsForUser (AUTHGetLoginsForUserRequest aUTHGetLoginsForUserRequest)

Returns back the login(s) associated with a particular userid and siteid

Returns back the login(s) associated with a particular userid and siteid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHGetLoginsForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHGetLoginsForUserRequest = new AUTHGetLoginsForUserRequest(); // AUTHGetLoginsForUserRequest | Returns back the login(s) associated with a particular userid and siteid

            try
            {
                // Returns back the login(s) associated with a particular userid and siteid
                AUTHGetClientLoginsDefaultResponse result = apiInstance.AUTHGetLoginsForUser(aUTHGetLoginsForUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHGetLoginsForUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHGetLoginsForUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back the login(s) associated with a particular userid and siteid
    ApiResponse<AUTHGetClientLoginsDefaultResponse> response = apiInstance.AUTHGetLoginsForUserWithHttpInfo(aUTHGetLoginsForUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHGetLoginsForUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHGetLoginsForUserRequest** | [**AUTHGetLoginsForUserRequest**](AUTHGetLoginsForUserRequest.md) | Returns back the login(s) associated with a particular userid and siteid |  |

### Return type

[**AUTHGetClientLoginsDefaultResponse**](AUTHGetClientLoginsDefaultResponse.md)

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

<a id="authrenamelogin"></a>
# **AUTHRenameLogin**
> AUTHChangePasswordDefaultResponse AUTHRenameLogin (AUTHRenameLoginRequest aUTHRenameLoginRequest)

Rename the specified login

Rename the specified login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHRenameLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHRenameLoginRequest = new AUTHRenameLoginRequest(); // AUTHRenameLoginRequest | Rename the specified login

            try
            {
                // Rename the specified login
                AUTHChangePasswordDefaultResponse result = apiInstance.AUTHRenameLogin(aUTHRenameLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHRenameLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHRenameLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename the specified login
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AUTHRenameLoginWithHttpInfo(aUTHRenameLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHRenameLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHRenameLoginRequest** | [**AUTHRenameLoginRequest**](AUTHRenameLoginRequest.md) | Rename the specified login |  |

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

<a id="authsetloginuserid"></a>
# **AUTHSetLoginUserId**
> AUTHChangePasswordDefaultResponse AUTHSetLoginUserId (AUTHSetLoginUserIdRequest aUTHSetLoginUserIdRequest)

Associates an auth system login with a CM user ID

Associates an auth system login with a CM user ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHSetLoginUserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHSetLoginUserIdRequest = new AUTHSetLoginUserIdRequest(); // AUTHSetLoginUserIdRequest | Associates an auth system login with a CM user ID

            try
            {
                // Associates an auth system login with a CM user ID
                AUTHChangePasswordDefaultResponse result = apiInstance.AUTHSetLoginUserId(aUTHSetLoginUserIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHSetLoginUserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHSetLoginUserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associates an auth system login with a CM user ID
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AUTHSetLoginUserIdWithHttpInfo(aUTHSetLoginUserIdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHSetLoginUserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHSetLoginUserIdRequest** | [**AUTHSetLoginUserIdRequest**](AUTHSetLoginUserIdRequest.md) | Associates an auth system login with a CM user ID |  |

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

<a id="authupdatelogin"></a>
# **AUTHUpdateLogin**
> AUTHChangePasswordDefaultResponse AUTHUpdateLogin (AUTHUpdateLoginRequest aUTHUpdateLoginRequest)

Updates the important components of a login, use expire, etc. to expire or delete a login

Updates the important components of a login, use expire, etc. to expire or delete a login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AUTHUpdateLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthServerApi(config);
            var aUTHUpdateLoginRequest = new AUTHUpdateLoginRequest(); // AUTHUpdateLoginRequest | Updates the important components of a login, use expire, etc. to expire or delete a login

            try
            {
                // Updates the important components of a login, use expire, etc. to expire or delete a login
                AUTHChangePasswordDefaultResponse result = apiInstance.AUTHUpdateLogin(aUTHUpdateLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthServerApi.AUTHUpdateLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AUTHUpdateLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the important components of a login, use expire, etc. to expire or delete a login
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AUTHUpdateLoginWithHttpInfo(aUTHUpdateLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthServerApi.AUTHUpdateLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aUTHUpdateLoginRequest** | [**AUTHUpdateLoginRequest**](AUTHUpdateLoginRequest.md) | Updates the important components of a login, use expire, etc. to expire or delete a login |  |

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

