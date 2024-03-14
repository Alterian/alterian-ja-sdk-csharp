# Alterian.JA.Api.TemplateBuilderApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebSpoon**](TemplateBuilderApi.md#createwebspoon) | **POST** /CreateWebSpoon | Creates an instance of Template Builder which will be unique to this system, the brand and user which calls the method. |
| [**DeleteWebSpoon**](TemplateBuilderApi.md#deletewebspoon) | **POST** /DeleteWebSpoon | Removes a Template Builder instance |
| [**GetWebSpoonAvailable**](TemplateBuilderApi.md#getwebspoonavailable) | **POST** /GetWebSpoonAvailable | Check to make sure Template Builder is available |
| [**GetWebSpoonLoginUrl**](TemplateBuilderApi.md#getwebspoonloginurl) | **POST** /GetWebSpoonLoginUrl | Get a URL valid for redirecting to the Template Builder instance; note, this will return nothing if the operational status is not \&quot;UP\&quot; |
| [**ListWebSpoon**](TemplateBuilderApi.md#listwebspoon) | **POST** /ListWebSpoon | Returns back the Template Builder instances which have been created for this system, brand and user (unique to that combination) |

<a id="createwebspoon"></a>
# **CreateWebSpoon**
> CreateWebSpoonDefaultResponse CreateWebSpoon (CreateWebSpoonRequest createWebSpoonRequest)

Creates an instance of Template Builder which will be unique to this system, the brand and user which calls the method.

Creates an instance of Template Builder which will be unique to this system, the brand and user which calls the method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateWebSpoonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TemplateBuilderApi(config);
            var createWebSpoonRequest = new CreateWebSpoonRequest(); // CreateWebSpoonRequest | Creates an instance of Template Builder which will be unique to this system, the brand and user which calls the method.

            try
            {
                // Creates an instance of Template Builder which will be unique to this system, the brand and user which calls the method.
                CreateWebSpoonDefaultResponse result = apiInstance.CreateWebSpoon(createWebSpoonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateBuilderApi.CreateWebSpoon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWebSpoonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an instance of Template Builder which will be unique to this system, the brand and user which calls the method.
    ApiResponse<CreateWebSpoonDefaultResponse> response = apiInstance.CreateWebSpoonWithHttpInfo(createWebSpoonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateBuilderApi.CreateWebSpoonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createWebSpoonRequest** | [**CreateWebSpoonRequest**](CreateWebSpoonRequest.md) | Creates an instance of Template Builder which will be unique to this system, the brand and user which calls the method. |  |

### Return type

[**CreateWebSpoonDefaultResponse**](CreateWebSpoonDefaultResponse.md)

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

<a id="deletewebspoon"></a>
# **DeleteWebSpoon**
> AUTHChangePasswordDefaultResponse DeleteWebSpoon (DeleteWebSpoonRequest deleteWebSpoonRequest)

Removes a Template Builder instance

Removes a Template Builder instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteWebSpoonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TemplateBuilderApi(config);
            var deleteWebSpoonRequest = new DeleteWebSpoonRequest(); // DeleteWebSpoonRequest | Removes a Template Builder instance

            try
            {
                // Removes a Template Builder instance
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteWebSpoon(deleteWebSpoonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateBuilderApi.DeleteWebSpoon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebSpoonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a Template Builder instance
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteWebSpoonWithHttpInfo(deleteWebSpoonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateBuilderApi.DeleteWebSpoonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteWebSpoonRequest** | [**DeleteWebSpoonRequest**](DeleteWebSpoonRequest.md) | Removes a Template Builder instance |  |

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

<a id="getwebspoonavailable"></a>
# **GetWebSpoonAvailable**
> AUTHChangePasswordDefaultResponse GetWebSpoonAvailable ()

Check to make sure Template Builder is available

Check to make sure Template Builder is available

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetWebSpoonAvailableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TemplateBuilderApi(config);

            try
            {
                // Check to make sure Template Builder is available
                AUTHChangePasswordDefaultResponse result = apiInstance.GetWebSpoonAvailable();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateBuilderApi.GetWebSpoonAvailable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebSpoonAvailableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check to make sure Template Builder is available
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.GetWebSpoonAvailableWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateBuilderApi.GetWebSpoonAvailableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AUTHChangePasswordDefaultResponse**](AUTHChangePasswordDefaultResponse.md)

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

<a id="getwebspoonloginurl"></a>
# **GetWebSpoonLoginUrl**
> GetDataSourceEngineUserNameDefaultResponse GetWebSpoonLoginUrl (GetWebSpoonLoginUrlRequest getWebSpoonLoginUrlRequest)

Get a URL valid for redirecting to the Template Builder instance; note, this will return nothing if the operational status is not \"UP\"

Get a URL valid for redirecting to the Template Builder instance; note, this will return nothing if the operational status is not \"UP\"

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetWebSpoonLoginUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TemplateBuilderApi(config);
            var getWebSpoonLoginUrlRequest = new GetWebSpoonLoginUrlRequest(); // GetWebSpoonLoginUrlRequest | Get a URL valid for redirecting to the Template Builder instance; note, this will return nothing if the operational status is not \"UP\"

            try
            {
                // Get a URL valid for redirecting to the Template Builder instance; note, this will return nothing if the operational status is not \"UP\"
                GetDataSourceEngineUserNameDefaultResponse result = apiInstance.GetWebSpoonLoginUrl(getWebSpoonLoginUrlRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateBuilderApi.GetWebSpoonLoginUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebSpoonLoginUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a URL valid for redirecting to the Template Builder instance; note, this will return nothing if the operational status is not \"UP\"
    ApiResponse<GetDataSourceEngineUserNameDefaultResponse> response = apiInstance.GetWebSpoonLoginUrlWithHttpInfo(getWebSpoonLoginUrlRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateBuilderApi.GetWebSpoonLoginUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getWebSpoonLoginUrlRequest** | [**GetWebSpoonLoginUrlRequest**](GetWebSpoonLoginUrlRequest.md) | Get a URL valid for redirecting to the Template Builder instance; note, this will return nothing if the operational status is not \&quot;UP\&quot; |  |

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

<a id="listwebspoon"></a>
# **ListWebSpoon**
> ListWebSpoonDefaultResponse ListWebSpoon (ListWebSpoonRequest listWebSpoonRequest)

Returns back the Template Builder instances which have been created for this system, brand and user (unique to that combination)

Returns back the Template Builder instances which have been created for this system, brand and user (unique to that combination)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class ListWebSpoonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TemplateBuilderApi(config);
            var listWebSpoonRequest = new ListWebSpoonRequest(); // ListWebSpoonRequest | Returns back the Template Builder instances which have been created for this system, brand and user (unique to that combination)

            try
            {
                // Returns back the Template Builder instances which have been created for this system, brand and user (unique to that combination)
                ListWebSpoonDefaultResponse result = apiInstance.ListWebSpoon(listWebSpoonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateBuilderApi.ListWebSpoon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWebSpoonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back the Template Builder instances which have been created for this system, brand and user (unique to that combination)
    ApiResponse<ListWebSpoonDefaultResponse> response = apiInstance.ListWebSpoonWithHttpInfo(listWebSpoonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateBuilderApi.ListWebSpoonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listWebSpoonRequest** | [**ListWebSpoonRequest**](ListWebSpoonRequest.md) | Returns back the Template Builder instances which have been created for this system, brand and user (unique to that combination) |  |

### Return type

[**ListWebSpoonDefaultResponse**](ListWebSpoonDefaultResponse.md)

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

