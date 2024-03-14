# Alterian.JA.Api.LogApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadAlerts**](LogApi.md#downloadalerts) | **GET** /DownloadAlerts | Returns back an excel file containing the alert log entries for a particular client |

<a id="downloadalerts"></a>
# **DownloadAlerts**
> System.IO.Stream DownloadAlerts (int? clientId = null, int? from = null, bool? sortDesc = null, string? sortProperty = null, int? to = null)

Returns back an excel file containing the alert log entries for a particular client

Returns back an excel file containing the alert log entries for a particular client

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DownloadAlertsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LogApi(config);
            var clientId = 56;  // int? |  (optional) 
            var from = 56;  // int? |  (optional) 
            var sortDesc = true;  // bool? |  (optional) 
            var sortProperty = "sortProperty_example";  // string? |  (optional) 
            var to = 56;  // int? |  (optional) 

            try
            {
                // Returns back an excel file containing the alert log entries for a particular client
                System.IO.Stream result = apiInstance.DownloadAlerts(clientId, from, sortDesc, sortProperty, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LogApi.DownloadAlerts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadAlertsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back an excel file containing the alert log entries for a particular client
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadAlertsWithHttpInfo(clientId, from, sortDesc, sortProperty, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LogApi.DownloadAlertsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **int?** |  | [optional]  |
| **from** | **int?** |  | [optional]  |
| **sortDesc** | **bool?** |  | [optional]  |
| **sortProperty** | **string?** |  | [optional]  |
| **to** | **int?** |  | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

