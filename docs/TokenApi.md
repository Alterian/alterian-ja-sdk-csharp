# Alterian.JA.Api.TokenApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateImpersonationToken**](TokenApi.md#createimpersonationtoken) | **POST** /CreateImpersonationToken | Using an SA token, create an impersonation token for the specific client and, optionally, user |
| [**CreateStaticToken**](TokenApi.md#createstatictoken) | **POST** /CreateStaticToken | Create a static token for API usage |
| [**DeleteStaticToken**](TokenApi.md#deletestatictoken) | **POST** /DeleteStaticToken | Remove a static token.  Any automation or other application which is using this token will cease to function. |
| [**GetTokens**](TokenApi.md#gettokens) | **POST** /GetTokens | Request a list of tokens. |
| [**UpdateStaticToken**](TokenApi.md#updatestatictoken) | **POST** /UpdateStaticToken | Change the UserID mapping for a static token |

<a id="createimpersonationtoken"></a>
# **CreateImpersonationToken**
> AUTHCreateLoginDefaultResponse CreateImpersonationToken (CreateImpersonationTokenRequest createImpersonationTokenRequest)

Using an SA token, create an impersonation token for the specific client and, optionally, user

Using an SA token, create an impersonation token for the specific client and, optionally, user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateImpersonationTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TokenApi(config);
            var createImpersonationTokenRequest = new CreateImpersonationTokenRequest(); // CreateImpersonationTokenRequest | Using an SA token, create an impersonation token for the specific client and, optionally, user

            try
            {
                // Using an SA token, create an impersonation token for the specific client and, optionally, user
                AUTHCreateLoginDefaultResponse result = apiInstance.CreateImpersonationToken(createImpersonationTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenApi.CreateImpersonationToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateImpersonationTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Using an SA token, create an impersonation token for the specific client and, optionally, user
    ApiResponse<AUTHCreateLoginDefaultResponse> response = apiInstance.CreateImpersonationTokenWithHttpInfo(createImpersonationTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenApi.CreateImpersonationTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createImpersonationTokenRequest** | [**CreateImpersonationTokenRequest**](CreateImpersonationTokenRequest.md) | Using an SA token, create an impersonation token for the specific client and, optionally, user |  |

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

<a id="createstatictoken"></a>
# **CreateStaticToken**
> AUTHCreateLoginDefaultResponse CreateStaticToken (CreateStaticTokenRequest createStaticTokenRequest)

Create a static token for API usage

Create a static token for API usage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateStaticTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TokenApi(config);
            var createStaticTokenRequest = new CreateStaticTokenRequest(); // CreateStaticTokenRequest | Create a static token for API usage

            try
            {
                // Create a static token for API usage
                AUTHCreateLoginDefaultResponse result = apiInstance.CreateStaticToken(createStaticTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenApi.CreateStaticToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateStaticTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a static token for API usage
    ApiResponse<AUTHCreateLoginDefaultResponse> response = apiInstance.CreateStaticTokenWithHttpInfo(createStaticTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenApi.CreateStaticTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createStaticTokenRequest** | [**CreateStaticTokenRequest**](CreateStaticTokenRequest.md) | Create a static token for API usage |  |

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

<a id="deletestatictoken"></a>
# **DeleteStaticToken**
> AUTHChangePasswordDefaultResponse DeleteStaticToken (DeleteStaticTokenRequest deleteStaticTokenRequest)

Remove a static token.  Any automation or other application which is using this token will cease to function.

Remove a static token.  Any automation or other application which is using this token will cease to function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteStaticTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TokenApi(config);
            var deleteStaticTokenRequest = new DeleteStaticTokenRequest(); // DeleteStaticTokenRequest | Remove a static token.  Any automation or other application which is using this token will cease to function.

            try
            {
                // Remove a static token.  Any automation or other application which is using this token will cease to function.
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteStaticToken(deleteStaticTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenApi.DeleteStaticToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStaticTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a static token.  Any automation or other application which is using this token will cease to function.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteStaticTokenWithHttpInfo(deleteStaticTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenApi.DeleteStaticTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteStaticTokenRequest** | [**DeleteStaticTokenRequest**](DeleteStaticTokenRequest.md) | Remove a static token.  Any automation or other application which is using this token will cease to function. |  |

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

<a id="gettokens"></a>
# **GetTokens**
> GetTokensDefaultResponse GetTokens (GetTokensRequest getTokensRequest)

Request a list of tokens.

Request a list of tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TokenApi(config);
            var getTokensRequest = new GetTokensRequest(); // GetTokensRequest | Request a list of tokens.

            try
            {
                // Request a list of tokens.
                GetTokensDefaultResponse result = apiInstance.GetTokens(getTokensRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenApi.GetTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request a list of tokens.
    ApiResponse<GetTokensDefaultResponse> response = apiInstance.GetTokensWithHttpInfo(getTokensRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenApi.GetTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getTokensRequest** | [**GetTokensRequest**](GetTokensRequest.md) | Request a list of tokens. |  |

### Return type

[**GetTokensDefaultResponse**](GetTokensDefaultResponse.md)

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

<a id="updatestatictoken"></a>
# **UpdateStaticToken**
> AUTHChangePasswordDefaultResponse UpdateStaticToken (UpdateStaticTokenRequest updateStaticTokenRequest)

Change the UserID mapping for a static token

Change the UserID mapping for a static token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateStaticTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TokenApi(config);
            var updateStaticTokenRequest = new UpdateStaticTokenRequest(); // UpdateStaticTokenRequest | Change the UserID mapping for a static token

            try
            {
                // Change the UserID mapping for a static token
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateStaticToken(updateStaticTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenApi.UpdateStaticToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateStaticTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change the UserID mapping for a static token
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateStaticTokenWithHttpInfo(updateStaticTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenApi.UpdateStaticTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateStaticTokenRequest** | [**UpdateStaticTokenRequest**](UpdateStaticTokenRequest.md) | Change the UserID mapping for a static token |  |

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

