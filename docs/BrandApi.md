# Alterian.JA.Api.BrandApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddLoginImpersonation**](BrandApi.md#addloginimpersonation) | **POST** /AddLoginImpersonation | Allow a login to use the impersonation feature of GetBrandToken |
| [**AddUserToBrands**](BrandApi.md#addusertobrands) | **POST** /AddUserToBrands | Replicates a user from the brand associated with the current token to all brands in BrandIds to which the token has access |
| [**GetBrandToken**](BrandApi.md#getbrandtoken) | **POST** /GetBrandToken | Returns back a token used to access the brand provided. |
| [**GetBrands**](BrandApi.md#getbrands) | **POST** /GetBrands | Returns back a list of brands which this login can access |
| [**GetLoginBrandDefault**](BrandApi.md#getloginbranddefault) | **POST** /GetLoginBrandDefault | Returns back the brand default for the specified login |
| [**GetLoginUserMapping**](BrandApi.md#getloginusermapping) | **POST** /GetLoginUserMapping | Look in the system for a login\\user mapping which matches the search criteria.  Note, if you do not provide either the login id or user id, it will return back the mapping for the token&#39;s login |
| [**GetTokenDetails**](BrandApi.md#gettokendetails) | **POST** /GetTokenDetails | Request details about a token. |
| [**RemoveLoginBrandDefault**](BrandApi.md#removeloginbranddefault) | **POST** /RemoveLoginBrandDefault | Removes a login brand default |
| [**RemoveLoginImpersonation**](BrandApi.md#removeloginimpersonation) | **POST** /RemoveLoginImpersonation | Stop allowing a login from using the impersonation feature of GetBrandToken |
| [**RemoveLoginUserMapping**](BrandApi.md#removeloginusermapping) | **POST** /RemoveLoginUserMapping | Remove a login\\user mapping |
| [**SetLoginBrandDefault**](BrandApi.md#setloginbranddefault) | **POST** /SetLoginBrandDefault | Sets a login&#39;s brand to the default brand specified |
| [**SetLoginUserMapping**](BrandApi.md#setloginusermapping) | **POST** /SetLoginUserMapping | Sets the login\\user mapping |

<a id="addloginimpersonation"></a>
# **AddLoginImpersonation**
> AUTHChangePasswordDefaultResponse AddLoginImpersonation (AddLoginImpersonationRequest addLoginImpersonationRequest)

Allow a login to use the impersonation feature of GetBrandToken

Allow a login to use the impersonation feature of GetBrandToken

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AddLoginImpersonationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var addLoginImpersonationRequest = new AddLoginImpersonationRequest(); // AddLoginImpersonationRequest | Allow a login to use the impersonation feature of GetBrandToken

            try
            {
                // Allow a login to use the impersonation feature of GetBrandToken
                AUTHChangePasswordDefaultResponse result = apiInstance.AddLoginImpersonation(addLoginImpersonationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.AddLoginImpersonation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLoginImpersonationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allow a login to use the impersonation feature of GetBrandToken
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AddLoginImpersonationWithHttpInfo(addLoginImpersonationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.AddLoginImpersonationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addLoginImpersonationRequest** | [**AddLoginImpersonationRequest**](AddLoginImpersonationRequest.md) | Allow a login to use the impersonation feature of GetBrandToken |  |

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

<a id="addusertobrands"></a>
# **AddUserToBrands**
> AUTHChangePasswordDefaultResponse AddUserToBrands (AddUserToBrandsRequest addUserToBrandsRequest)

Replicates a user from the brand associated with the current token to all brands in BrandIds to which the token has access

Replicates a user from the brand associated with the current token to all brands in BrandIds to which the token has access

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AddUserToBrandsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var addUserToBrandsRequest = new AddUserToBrandsRequest(); // AddUserToBrandsRequest | Replicates a user from the brand associated with the current token to all brands in BrandIds to which the token has access

            try
            {
                // Replicates a user from the brand associated with the current token to all brands in BrandIds to which the token has access
                AUTHChangePasswordDefaultResponse result = apiInstance.AddUserToBrands(addUserToBrandsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.AddUserToBrands: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddUserToBrandsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replicates a user from the brand associated with the current token to all brands in BrandIds to which the token has access
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.AddUserToBrandsWithHttpInfo(addUserToBrandsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.AddUserToBrandsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addUserToBrandsRequest** | [**AddUserToBrandsRequest**](AddUserToBrandsRequest.md) | Replicates a user from the brand associated with the current token to all brands in BrandIds to which the token has access |  |

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

<a id="getbrandtoken"></a>
# **GetBrandToken**
> AUTHCreateLoginDefaultResponse GetBrandToken (GetBrandTokenRequest getBrandTokenRequest)

Returns back a token used to access the brand provided.

Returns back a token used to access the brand provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetBrandTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var getBrandTokenRequest = new GetBrandTokenRequest(); // GetBrandTokenRequest | Returns back a token used to access the brand provided.

            try
            {
                // Returns back a token used to access the brand provided.
                AUTHCreateLoginDefaultResponse result = apiInstance.GetBrandToken(getBrandTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.GetBrandToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a token used to access the brand provided.
    ApiResponse<AUTHCreateLoginDefaultResponse> response = apiInstance.GetBrandTokenWithHttpInfo(getBrandTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.GetBrandTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getBrandTokenRequest** | [**GetBrandTokenRequest**](GetBrandTokenRequest.md) | Returns back a token used to access the brand provided. |  |

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

<a id="getbrands"></a>
# **GetBrands**
> GetBrandsDefaultResponse GetBrands (GetBrandsRequest getBrandsRequest)

Returns back a list of brands which this login can access

Returns back a list of brands which this login can access

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetBrandsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var getBrandsRequest = new GetBrandsRequest(); // GetBrandsRequest | Returns back a list of brands which this login can access

            try
            {
                // Returns back a list of brands which this login can access
                GetBrandsDefaultResponse result = apiInstance.GetBrands(getBrandsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.GetBrands: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a list of brands which this login can access
    ApiResponse<GetBrandsDefaultResponse> response = apiInstance.GetBrandsWithHttpInfo(getBrandsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.GetBrandsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getBrandsRequest** | [**GetBrandsRequest**](GetBrandsRequest.md) | Returns back a list of brands which this login can access |  |

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

<a id="getloginbranddefault"></a>
# **GetLoginBrandDefault**
> GetLoginBrandDefaultDefaultResponse GetLoginBrandDefault (GetLoginBrandDefaultRequest getLoginBrandDefaultRequest)

Returns back the brand default for the specified login

Returns back the brand default for the specified login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetLoginBrandDefaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var getLoginBrandDefaultRequest = new GetLoginBrandDefaultRequest(); // GetLoginBrandDefaultRequest | Returns back the brand default for the specified login

            try
            {
                // Returns back the brand default for the specified login
                GetLoginBrandDefaultDefaultResponse result = apiInstance.GetLoginBrandDefault(getLoginBrandDefaultRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.GetLoginBrandDefault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoginBrandDefaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back the brand default for the specified login
    ApiResponse<GetLoginBrandDefaultDefaultResponse> response = apiInstance.GetLoginBrandDefaultWithHttpInfo(getLoginBrandDefaultRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.GetLoginBrandDefaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getLoginBrandDefaultRequest** | [**GetLoginBrandDefaultRequest**](GetLoginBrandDefaultRequest.md) | Returns back the brand default for the specified login |  |

### Return type

[**GetLoginBrandDefaultDefaultResponse**](GetLoginBrandDefaultDefaultResponse.md)

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

<a id="getloginusermapping"></a>
# **GetLoginUserMapping**
> GetLoginUserMappingDefaultResponse GetLoginUserMapping (GetLoginUserMappingRequest getLoginUserMappingRequest)

Look in the system for a login\\user mapping which matches the search criteria.  Note, if you do not provide either the login id or user id, it will return back the mapping for the token's login

Look in the system for a login\\user mapping which matches the search criteria.  Note, if you do not provide either the login id or user id, it will return back the mapping for the token's login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetLoginUserMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var getLoginUserMappingRequest = new GetLoginUserMappingRequest(); // GetLoginUserMappingRequest | Look in the system for a login\\user mapping which matches the search criteria.  Note, if you do not provide either the login id or user id, it will return back the mapping for the token's login

            try
            {
                // Look in the system for a login\\user mapping which matches the search criteria.  Note, if you do not provide either the login id or user id, it will return back the mapping for the token's login
                GetLoginUserMappingDefaultResponse result = apiInstance.GetLoginUserMapping(getLoginUserMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.GetLoginUserMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoginUserMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Look in the system for a login\\user mapping which matches the search criteria.  Note, if you do not provide either the login id or user id, it will return back the mapping for the token's login
    ApiResponse<GetLoginUserMappingDefaultResponse> response = apiInstance.GetLoginUserMappingWithHttpInfo(getLoginUserMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.GetLoginUserMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getLoginUserMappingRequest** | [**GetLoginUserMappingRequest**](GetLoginUserMappingRequest.md) | Look in the system for a login\\user mapping which matches the search criteria.  Note, if you do not provide either the login id or user id, it will return back the mapping for the token&#39;s login |  |

### Return type

[**GetLoginUserMappingDefaultResponse**](GetLoginUserMappingDefaultResponse.md)

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

<a id="gettokendetails"></a>
# **GetTokenDetails**
> GetTokenDetailsDefaultResponse GetTokenDetails ()

Request details about a token.

Request details about a token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetTokenDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);

            try
            {
                // Request details about a token.
                GetTokenDetailsDefaultResponse result = apiInstance.GetTokenDetails();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.GetTokenDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTokenDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request details about a token.
    ApiResponse<GetTokenDetailsDefaultResponse> response = apiInstance.GetTokenDetailsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.GetTokenDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetTokenDetailsDefaultResponse**](GetTokenDetailsDefaultResponse.md)

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

<a id="removeloginbranddefault"></a>
# **RemoveLoginBrandDefault**
> AUTHChangePasswordDefaultResponse RemoveLoginBrandDefault (RemoveLoginBrandDefaultRequest removeLoginBrandDefaultRequest)

Removes a login brand default

Removes a login brand default

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class RemoveLoginBrandDefaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var removeLoginBrandDefaultRequest = new RemoveLoginBrandDefaultRequest(); // RemoveLoginBrandDefaultRequest | Removes a login brand default

            try
            {
                // Removes a login brand default
                AUTHChangePasswordDefaultResponse result = apiInstance.RemoveLoginBrandDefault(removeLoginBrandDefaultRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.RemoveLoginBrandDefault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveLoginBrandDefaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a login brand default
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.RemoveLoginBrandDefaultWithHttpInfo(removeLoginBrandDefaultRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.RemoveLoginBrandDefaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **removeLoginBrandDefaultRequest** | [**RemoveLoginBrandDefaultRequest**](RemoveLoginBrandDefaultRequest.md) | Removes a login brand default |  |

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

<a id="removeloginimpersonation"></a>
# **RemoveLoginImpersonation**
> AUTHChangePasswordDefaultResponse RemoveLoginImpersonation (RemoveLoginImpersonationRequest removeLoginImpersonationRequest)

Stop allowing a login from using the impersonation feature of GetBrandToken

Stop allowing a login from using the impersonation feature of GetBrandToken

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class RemoveLoginImpersonationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var removeLoginImpersonationRequest = new RemoveLoginImpersonationRequest(); // RemoveLoginImpersonationRequest | Stop allowing a login from using the impersonation feature of GetBrandToken

            try
            {
                // Stop allowing a login from using the impersonation feature of GetBrandToken
                AUTHChangePasswordDefaultResponse result = apiInstance.RemoveLoginImpersonation(removeLoginImpersonationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.RemoveLoginImpersonation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveLoginImpersonationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stop allowing a login from using the impersonation feature of GetBrandToken
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.RemoveLoginImpersonationWithHttpInfo(removeLoginImpersonationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.RemoveLoginImpersonationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **removeLoginImpersonationRequest** | [**RemoveLoginImpersonationRequest**](RemoveLoginImpersonationRequest.md) | Stop allowing a login from using the impersonation feature of GetBrandToken |  |

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

<a id="removeloginusermapping"></a>
# **RemoveLoginUserMapping**
> AUTHChangePasswordDefaultResponse RemoveLoginUserMapping (RemoveLoginUserMappingRequest removeLoginUserMappingRequest)

Remove a login\\user mapping

Remove a login\\user mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class RemoveLoginUserMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var removeLoginUserMappingRequest = new RemoveLoginUserMappingRequest(); // RemoveLoginUserMappingRequest | Remove a login\\user mapping

            try
            {
                // Remove a login\\user mapping
                AUTHChangePasswordDefaultResponse result = apiInstance.RemoveLoginUserMapping(removeLoginUserMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.RemoveLoginUserMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveLoginUserMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a login\\user mapping
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.RemoveLoginUserMappingWithHttpInfo(removeLoginUserMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.RemoveLoginUserMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **removeLoginUserMappingRequest** | [**RemoveLoginUserMappingRequest**](RemoveLoginUserMappingRequest.md) | Remove a login\\user mapping |  |

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

<a id="setloginbranddefault"></a>
# **SetLoginBrandDefault**
> AUTHChangePasswordDefaultResponse SetLoginBrandDefault (SetLoginBrandDefaultRequest setLoginBrandDefaultRequest)

Sets a login's brand to the default brand specified

Sets a login's brand to the default brand specified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class SetLoginBrandDefaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var setLoginBrandDefaultRequest = new SetLoginBrandDefaultRequest(); // SetLoginBrandDefaultRequest | Sets a login's brand to the default brand specified

            try
            {
                // Sets a login's brand to the default brand specified
                AUTHChangePasswordDefaultResponse result = apiInstance.SetLoginBrandDefault(setLoginBrandDefaultRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.SetLoginBrandDefault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetLoginBrandDefaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets a login's brand to the default brand specified
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.SetLoginBrandDefaultWithHttpInfo(setLoginBrandDefaultRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.SetLoginBrandDefaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setLoginBrandDefaultRequest** | [**SetLoginBrandDefaultRequest**](SetLoginBrandDefaultRequest.md) | Sets a login&#39;s brand to the default brand specified |  |

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

<a id="setloginusermapping"></a>
# **SetLoginUserMapping**
> AUTHChangePasswordDefaultResponse SetLoginUserMapping (SetLoginUserMappingRequest setLoginUserMappingRequest)

Sets the login\\user mapping

Sets the login\\user mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class SetLoginUserMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new BrandApi(config);
            var setLoginUserMappingRequest = new SetLoginUserMappingRequest(); // SetLoginUserMappingRequest | Sets the login\\user mapping

            try
            {
                // Sets the login\\user mapping
                AUTHChangePasswordDefaultResponse result = apiInstance.SetLoginUserMapping(setLoginUserMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandApi.SetLoginUserMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetLoginUserMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the login\\user mapping
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.SetLoginUserMappingWithHttpInfo(setLoginUserMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandApi.SetLoginUserMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setLoginUserMappingRequest** | [**SetLoginUserMappingRequest**](SetLoginUserMappingRequest.md) | Sets the login\\user mapping |  |

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

