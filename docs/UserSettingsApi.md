# Alterian.JA.Api.UserSettingsApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetUserSetting**](UserSettingsApi.md#getusersetting) | **POST** /GetUserSetting | Returns back a value for a user setting |
| [**SetUserSetting**](UserSettingsApi.md#setusersetting) | **POST** /SetUserSetting | Sets a user setting to the provided value |

<a id="getusersetting"></a>
# **GetUserSetting**
> GetDataSourceEngineUserNameDefaultResponse GetUserSetting (GetUserSettingRequest getUserSettingRequest)

Returns back a value for a user setting

Returns back a value for a user setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetUserSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UserSettingsApi(config);
            var getUserSettingRequest = new GetUserSettingRequest(); // GetUserSettingRequest | Returns back a value for a user setting

            try
            {
                // Returns back a value for a user setting
                GetDataSourceEngineUserNameDefaultResponse result = apiInstance.GetUserSetting(getUserSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSettingsApi.GetUserSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a value for a user setting
    ApiResponse<GetDataSourceEngineUserNameDefaultResponse> response = apiInstance.GetUserSettingWithHttpInfo(getUserSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSettingsApi.GetUserSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getUserSettingRequest** | [**GetUserSettingRequest**](GetUserSettingRequest.md) | Returns back a value for a user setting |  |

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

<a id="setusersetting"></a>
# **SetUserSetting**
> AUTHChangePasswordDefaultResponse SetUserSetting (SetUserSettingRequest setUserSettingRequest)

Sets a user setting to the provided value

Sets a user setting to the provided value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class SetUserSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new UserSettingsApi(config);
            var setUserSettingRequest = new SetUserSettingRequest(); // SetUserSettingRequest | Sets a user setting to the provided value

            try
            {
                // Sets a user setting to the provided value
                AUTHChangePasswordDefaultResponse result = apiInstance.SetUserSetting(setUserSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSettingsApi.SetUserSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetUserSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets a user setting to the provided value
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.SetUserSettingWithHttpInfo(setUserSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSettingsApi.SetUserSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setUserSettingRequest** | [**SetUserSettingRequest**](SetUserSettingRequest.md) | Sets a user setting to the provided value |  |

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

