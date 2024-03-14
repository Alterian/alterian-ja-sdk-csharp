# Alterian.JA.Api.ProcessesApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetProcessApplications**](ProcessesApi.md#getprocessapplications) | **POST** /GetProcessApplications | List all the applications that operate together to form the complete system. This list cannot be modified |
| [**GetProcessEntries**](ProcessesApi.md#getprocessentries) | **POST** /GetProcessEntries | Get the list of where each @see(ALProcessApplication) is currently located and it&#39;s last activity |
| [**UpdateProcessEntry**](ProcessesApi.md#updateprocessentry) | **POST** /UpdateProcessEntry | Modify the location or settings of a particular instance of a @see(ALProcessApplication) |

<a id="getprocessapplications"></a>
# **GetProcessApplications**
> GetProcessApplicationsDefaultResponse GetProcessApplications (GetClientSetsRequest getClientSetsRequest)

List all the applications that operate together to form the complete system. This list cannot be modified

List all the applications that operate together to form the complete system. This list cannot be modified

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetProcessApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ProcessesApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | List all the applications that operate together to form the complete system. This list cannot be modified

            try
            {
                // List all the applications that operate together to form the complete system. This list cannot be modified
                GetProcessApplicationsDefaultResponse result = apiInstance.GetProcessApplications(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessesApi.GetProcessApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProcessApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all the applications that operate together to form the complete system. This list cannot be modified
    ApiResponse<GetProcessApplicationsDefaultResponse> response = apiInstance.GetProcessApplicationsWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessesApi.GetProcessApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | List all the applications that operate together to form the complete system. This list cannot be modified |  |

### Return type

[**GetProcessApplicationsDefaultResponse**](GetProcessApplicationsDefaultResponse.md)

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

<a id="getprocessentries"></a>
# **GetProcessEntries**
> GetProcessEntriesDefaultResponse GetProcessEntries (GetProcessEntriesRequest getProcessEntriesRequest)

Get the list of where each @see(ALProcessApplication) is currently located and it's last activity

Get the list of where each @see(ALProcessApplication) is currently located and it's last activity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetProcessEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ProcessesApi(config);
            var getProcessEntriesRequest = new GetProcessEntriesRequest(); // GetProcessEntriesRequest | Get the list of where each @see(ALProcessApplication) is currently located and it's last activity

            try
            {
                // Get the list of where each @see(ALProcessApplication) is currently located and it's last activity
                GetProcessEntriesDefaultResponse result = apiInstance.GetProcessEntries(getProcessEntriesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessesApi.GetProcessEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProcessEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of where each @see(ALProcessApplication) is currently located and it's last activity
    ApiResponse<GetProcessEntriesDefaultResponse> response = apiInstance.GetProcessEntriesWithHttpInfo(getProcessEntriesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessesApi.GetProcessEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getProcessEntriesRequest** | [**GetProcessEntriesRequest**](GetProcessEntriesRequest.md) | Get the list of where each @see(ALProcessApplication) is currently located and it&#39;s last activity |  |

### Return type

[**GetProcessEntriesDefaultResponse**](GetProcessEntriesDefaultResponse.md)

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

<a id="updateprocessentry"></a>
# **UpdateProcessEntry**
> AUTHChangePasswordDefaultResponse UpdateProcessEntry (UpdateProcessEntryRequest updateProcessEntryRequest)

Modify the location or settings of a particular instance of a @see(ALProcessApplication)

Modify the location or settings of a particular instance of a @see(ALProcessApplication)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateProcessEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ProcessesApi(config);
            var updateProcessEntryRequest = new UpdateProcessEntryRequest(); // UpdateProcessEntryRequest | Modify the location or settings of a particular instance of a @see(ALProcessApplication)

            try
            {
                // Modify the location or settings of a particular instance of a @see(ALProcessApplication)
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateProcessEntry(updateProcessEntryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessesApi.UpdateProcessEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProcessEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify the location or settings of a particular instance of a @see(ALProcessApplication)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateProcessEntryWithHttpInfo(updateProcessEntryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessesApi.UpdateProcessEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateProcessEntryRequest** | [**UpdateProcessEntryRequest**](UpdateProcessEntryRequest.md) | Modify the location or settings of a particular instance of a @see(ALProcessApplication) |  |

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

