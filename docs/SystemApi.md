# Alterian.JA.Api.SystemApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSystemIdentifier**](SystemApi.md#getsystemidentifier) | **POST** /GetSystemIdentifier | Returns back the system identifier for this CM system |
| [**GetSystemSettings**](SystemApi.md#getsystemsettings) | **POST** /GetSystemSettings | Returns the system settings that are common to all clients |
| [**UpdateSystemSetting**](SystemApi.md#updatesystemsetting) | **POST** /UpdateSystemSetting | Updates one of the system settings (those that are common to all clients) |

<a id="getsystemidentifier"></a>
# **GetSystemIdentifier**
> GetDataSourceEngineUserNameDefaultResponse GetSystemIdentifier ()

Returns back the system identifier for this CM system

Returns back the system identifier for this CM system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetSystemIdentifierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SystemApi(config);

            try
            {
                // Returns back the system identifier for this CM system
                GetDataSourceEngineUserNameDefaultResponse result = apiInstance.GetSystemIdentifier();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemIdentifier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemIdentifierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back the system identifier for this CM system
    ApiResponse<GetDataSourceEngineUserNameDefaultResponse> response = apiInstance.GetSystemIdentifierWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemIdentifierWithHttpInfo: " + e.Message);
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

<a id="getsystemsettings"></a>
# **GetSystemSettings**
> GetClientSettingsDefaultResponse GetSystemSettings ()

Returns the system settings that are common to all clients

Returns the system settings that are common to all clients

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetSystemSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SystemApi(config);

            try
            {
                // Returns the system settings that are common to all clients
                GetClientSettingsDefaultResponse result = apiInstance.GetSystemSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the system settings that are common to all clients
    ApiResponse<GetClientSettingsDefaultResponse> response = apiInstance.GetSystemSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetClientSettingsDefaultResponse**](GetClientSettingsDefaultResponse.md)

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

<a id="updatesystemsetting"></a>
# **UpdateSystemSetting**
> AUTHChangePasswordDefaultResponse UpdateSystemSetting (UpdateSystemSettingRequest updateSystemSettingRequest)

Updates one of the system settings (those that are common to all clients)

Updates one of the system settings (those that are common to all clients)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateSystemSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SystemApi(config);
            var updateSystemSettingRequest = new UpdateSystemSettingRequest(); // UpdateSystemSettingRequest | Updates one of the system settings (those that are common to all clients)

            try
            {
                // Updates one of the system settings (those that are common to all clients)
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateSystemSetting(updateSystemSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.UpdateSystemSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSystemSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates one of the system settings (those that are common to all clients)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateSystemSettingWithHttpInfo(updateSystemSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.UpdateSystemSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateSystemSettingRequest** | [**UpdateSystemSettingRequest**](UpdateSystemSettingRequest.md) | Updates one of the system settings (those that are common to all clients) |  |

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

