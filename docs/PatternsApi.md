# Alterian.JA.Api.PatternsApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePattern**](PatternsApi.md#createpattern) | **POST** /CreatePattern | Creates a Pattern definition to capture settings and record where any output is located. The actual detected patterns will not be populated until tasks are run against it |
| [**CreatePatternTasks**](PatternsApi.md#createpatterntasks) | **POST** /CreatePatternTasks | Creates a task to perform an action against a pattern definition |
| [**DeletePattern**](PatternsApi.md#deletepattern) | **POST** /DeletePattern | Delete one or more pattern definitions |
| [**GetPattern**](PatternsApi.md#getpattern) | **POST** /GetPattern | Get a pattern definition |
| [**GetPatternRecords**](PatternsApi.md#getpatternrecords) | **POST** /GetPatternRecords | Get records from a pattern table |
| [**GetPatternTasks**](PatternsApi.md#getpatterntasks) | **POST** /GetPatternTasks | Check on the status of pattern tasks |
| [**GetPatterns**](PatternsApi.md#getpatterns) | **POST** /GetPatterns | Get one or more pattern definitions |
| [**GetRepeatingPatternItemScores**](PatternsApi.md#getrepeatingpatternitemscores) | **POST** /GetRepeatingPatternItemScores | Gets the scores recorded against the underlying sequence items that are composed into patterns             Currently unscored items are returned with a zero score             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified decode &#39;alias&#39; transform that has been published to the pattern             and sits along-side the sequence item data |
| [**GetRepeatingPatternItems**](PatternsApi.md#getrepeatingpatternitems) | **POST** /GetRepeatingPatternItems | Gets the underlying sequence items that can be composed into patterns along with any scores that have been used to calculate the MSI (direct or via decodes)             Initially, this will be all the distinct sequence items in the table             Once a pattern has been calculated and uploaded this will be filtered down to only those sequence items that appear in a pattern |
| [**RequestCancelPatternTasks**](PatternsApi.md#requestcancelpatterntasks) | **POST** /RequestCancelPatternTasks | Requests cancellation of all tasks for a pattern. This may take some time to be actioned if the tasks are already running |
| [**UpdatePattern**](PatternsApi.md#updatepattern) | **POST** /UpdatePattern | Updates a Pattern definition. |
| [**UpdateRepeatingPatternItemScores**](PatternsApi.md#updaterepeatingpatternitemscores) | **POST** /UpdateRepeatingPatternItemScores | Update one or more of the scores maintained against the underlying sequence item labels that are composed into patterns             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified &#39;alias&#39; transform that sits along-side the sequence item data             Only one such decode alias can be scored at a time and when scores are applied they are applied from the alias first and then overridden with any score that has been stored againt the items themselves             If the scores are to be applied against a decode then its id and version must be specified             The scores are intended to denote the relative importance of items in a sequence. The label of the item with the highest score will serve as the overall label (MSI) for the sequence             Specifying zero for a score is the only way of &#39;unscoring&#39; it at present |

<a id="createpattern"></a>
# **CreatePattern**
> CreateClientDefaultResponse CreatePattern (CreatePatternRequest createPatternRequest)

Creates a Pattern definition to capture settings and record where any output is located. The actual detected patterns will not be populated until tasks are run against it

Creates a Pattern definition to capture settings and record where any output is located. The actual detected patterns will not be populated until tasks are run against it

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreatePatternExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var createPatternRequest = new CreatePatternRequest(); // CreatePatternRequest | Creates a Pattern definition to capture settings and record where any output is located. The actual detected patterns will not be populated until tasks are run against it

            try
            {
                // Creates a Pattern definition to capture settings and record where any output is located. The actual detected patterns will not be populated until tasks are run against it
                CreateClientDefaultResponse result = apiInstance.CreatePattern(createPatternRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.CreatePattern: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePatternWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a Pattern definition to capture settings and record where any output is located. The actual detected patterns will not be populated until tasks are run against it
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreatePatternWithHttpInfo(createPatternRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.CreatePatternWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPatternRequest** | [**CreatePatternRequest**](CreatePatternRequest.md) | Creates a Pattern definition to capture settings and record where any output is located. The actual detected patterns will not be populated until tasks are run against it |  |

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

<a id="createpatterntasks"></a>
# **CreatePatternTasks**
> CreatePatternTasksDefaultResponse CreatePatternTasks (CreatePatternTasksRequest createPatternTasksRequest)

Creates a task to perform an action against a pattern definition

Creates a task to perform an action against a pattern definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreatePatternTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var createPatternTasksRequest = new CreatePatternTasksRequest(); // CreatePatternTasksRequest | Creates a task to perform an action against a pattern definition

            try
            {
                // Creates a task to perform an action against a pattern definition
                CreatePatternTasksDefaultResponse result = apiInstance.CreatePatternTasks(createPatternTasksRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.CreatePatternTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePatternTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a task to perform an action against a pattern definition
    ApiResponse<CreatePatternTasksDefaultResponse> response = apiInstance.CreatePatternTasksWithHttpInfo(createPatternTasksRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.CreatePatternTasksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPatternTasksRequest** | [**CreatePatternTasksRequest**](CreatePatternTasksRequest.md) | Creates a task to perform an action against a pattern definition |  |

### Return type

[**CreatePatternTasksDefaultResponse**](CreatePatternTasksDefaultResponse.md)

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

<a id="deletepattern"></a>
# **DeletePattern**
> AUTHChangePasswordDefaultResponse DeletePattern (DeletePatternRequest deletePatternRequest)

Delete one or more pattern definitions

Delete one or more pattern definitions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeletePatternExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var deletePatternRequest = new DeletePatternRequest(); // DeletePatternRequest | Delete one or more pattern definitions

            try
            {
                // Delete one or more pattern definitions
                AUTHChangePasswordDefaultResponse result = apiInstance.DeletePattern(deletePatternRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.DeletePattern: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePatternWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete one or more pattern definitions
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeletePatternWithHttpInfo(deletePatternRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.DeletePatternWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deletePatternRequest** | [**DeletePatternRequest**](DeletePatternRequest.md) | Delete one or more pattern definitions |  |

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

<a id="getpattern"></a>
# **GetPattern**
> GetPatternDefaultResponse GetPattern (GetPatternRequest getPatternRequest)

Get a pattern definition

Get a pattern definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetPatternExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var getPatternRequest = new GetPatternRequest(); // GetPatternRequest | Get a pattern definition

            try
            {
                // Get a pattern definition
                GetPatternDefaultResponse result = apiInstance.GetPattern(getPatternRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.GetPattern: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPatternWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a pattern definition
    ApiResponse<GetPatternDefaultResponse> response = apiInstance.GetPatternWithHttpInfo(getPatternRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.GetPatternWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPatternRequest** | [**GetPatternRequest**](GetPatternRequest.md) | Get a pattern definition |  |

### Return type

[**GetPatternDefaultResponse**](GetPatternDefaultResponse.md)

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

<a id="getpatternrecords"></a>
# **GetPatternRecords**
> GetEventRecordsDefaultResponse GetPatternRecords (GetPatternRecordsRequest getPatternRecordsRequest)

Get records from a pattern table

Get records from a pattern table

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetPatternRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var getPatternRecordsRequest = new GetPatternRecordsRequest(); // GetPatternRecordsRequest | Get records from a pattern table

            try
            {
                // Get records from a pattern table
                GetEventRecordsDefaultResponse result = apiInstance.GetPatternRecords(getPatternRecordsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.GetPatternRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPatternRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get records from a pattern table
    ApiResponse<GetEventRecordsDefaultResponse> response = apiInstance.GetPatternRecordsWithHttpInfo(getPatternRecordsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.GetPatternRecordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPatternRecordsRequest** | [**GetPatternRecordsRequest**](GetPatternRecordsRequest.md) | Get records from a pattern table |  |

### Return type

[**GetEventRecordsDefaultResponse**](GetEventRecordsDefaultResponse.md)

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

<a id="getpatterntasks"></a>
# **GetPatternTasks**
> CreatePatternTasksDefaultResponse GetPatternTasks (GetPatternTasksRequest getPatternTasksRequest)

Check on the status of pattern tasks

Check on the status of pattern tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetPatternTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var getPatternTasksRequest = new GetPatternTasksRequest(); // GetPatternTasksRequest | Check on the status of pattern tasks

            try
            {
                // Check on the status of pattern tasks
                CreatePatternTasksDefaultResponse result = apiInstance.GetPatternTasks(getPatternTasksRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.GetPatternTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPatternTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check on the status of pattern tasks
    ApiResponse<CreatePatternTasksDefaultResponse> response = apiInstance.GetPatternTasksWithHttpInfo(getPatternTasksRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.GetPatternTasksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPatternTasksRequest** | [**GetPatternTasksRequest**](GetPatternTasksRequest.md) | Check on the status of pattern tasks |  |

### Return type

[**CreatePatternTasksDefaultResponse**](CreatePatternTasksDefaultResponse.md)

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

<a id="getpatterns"></a>
# **GetPatterns**
> GetPatternsDefaultResponse GetPatterns (GetPatternsRequest getPatternsRequest)

Get one or more pattern definitions

Get one or more pattern definitions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetPatternsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var getPatternsRequest = new GetPatternsRequest(); // GetPatternsRequest | Get one or more pattern definitions

            try
            {
                // Get one or more pattern definitions
                GetPatternsDefaultResponse result = apiInstance.GetPatterns(getPatternsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.GetPatterns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPatternsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get one or more pattern definitions
    ApiResponse<GetPatternsDefaultResponse> response = apiInstance.GetPatternsWithHttpInfo(getPatternsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.GetPatternsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPatternsRequest** | [**GetPatternsRequest**](GetPatternsRequest.md) | Get one or more pattern definitions |  |

### Return type

[**GetPatternsDefaultResponse**](GetPatternsDefaultResponse.md)

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

<a id="getrepeatingpatternitemscores"></a>
# **GetRepeatingPatternItemScores**
> GetRepeatingPatternItemScoresDefaultResponse GetRepeatingPatternItemScores (GetRepeatingPatternItemScoresRequest getRepeatingPatternItemScoresRequest)

Gets the scores recorded against the underlying sequence items that are composed into patterns             Currently unscored items are returned with a zero score             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified decode 'alias' transform that has been published to the pattern             and sits along-side the sequence item data

Gets the scores recorded against the underlying sequence items that are composed into patterns             Currently unscored items are returned with a zero score             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified decode 'alias' transform that has been published to the pattern             and sits along-side the sequence item data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetRepeatingPatternItemScoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var getRepeatingPatternItemScoresRequest = new GetRepeatingPatternItemScoresRequest(); // GetRepeatingPatternItemScoresRequest | Gets the scores recorded against the underlying sequence items that are composed into patterns             Currently unscored items are returned with a zero score             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified decode 'alias' transform that has been published to the pattern             and sits along-side the sequence item data

            try
            {
                // Gets the scores recorded against the underlying sequence items that are composed into patterns             Currently unscored items are returned with a zero score             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified decode 'alias' transform that has been published to the pattern             and sits along-side the sequence item data
                GetRepeatingPatternItemScoresDefaultResponse result = apiInstance.GetRepeatingPatternItemScores(getRepeatingPatternItemScoresRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.GetRepeatingPatternItemScores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepeatingPatternItemScoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the scores recorded against the underlying sequence items that are composed into patterns             Currently unscored items are returned with a zero score             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified decode 'alias' transform that has been published to the pattern             and sits along-side the sequence item data
    ApiResponse<GetRepeatingPatternItemScoresDefaultResponse> response = apiInstance.GetRepeatingPatternItemScoresWithHttpInfo(getRepeatingPatternItemScoresRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.GetRepeatingPatternItemScoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getRepeatingPatternItemScoresRequest** | [**GetRepeatingPatternItemScoresRequest**](GetRepeatingPatternItemScoresRequest.md) | Gets the scores recorded against the underlying sequence items that are composed into patterns             Currently unscored items are returned with a zero score             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified decode &#39;alias&#39; transform that has been published to the pattern             and sits along-side the sequence item data |  |

### Return type

[**GetRepeatingPatternItemScoresDefaultResponse**](GetRepeatingPatternItemScoresDefaultResponse.md)

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

<a id="getrepeatingpatternitems"></a>
# **GetRepeatingPatternItems**
> GetEventRecordsDefaultResponse GetRepeatingPatternItems (GetRepeatingPatternItemsRequest getRepeatingPatternItemsRequest)

Gets the underlying sequence items that can be composed into patterns along with any scores that have been used to calculate the MSI (direct or via decodes)             Initially, this will be all the distinct sequence items in the table             Once a pattern has been calculated and uploaded this will be filtered down to only those sequence items that appear in a pattern

Gets the underlying sequence items that can be composed into patterns along with any scores that have been used to calculate the MSI (direct or via decodes)             Initially, this will be all the distinct sequence items in the table             Once a pattern has been calculated and uploaded this will be filtered down to only those sequence items that appear in a pattern

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetRepeatingPatternItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var getRepeatingPatternItemsRequest = new GetRepeatingPatternItemsRequest(); // GetRepeatingPatternItemsRequest | Gets the underlying sequence items that can be composed into patterns along with any scores that have been used to calculate the MSI (direct or via decodes)             Initially, this will be all the distinct sequence items in the table             Once a pattern has been calculated and uploaded this will be filtered down to only those sequence items that appear in a pattern

            try
            {
                // Gets the underlying sequence items that can be composed into patterns along with any scores that have been used to calculate the MSI (direct or via decodes)             Initially, this will be all the distinct sequence items in the table             Once a pattern has been calculated and uploaded this will be filtered down to only those sequence items that appear in a pattern
                GetEventRecordsDefaultResponse result = apiInstance.GetRepeatingPatternItems(getRepeatingPatternItemsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.GetRepeatingPatternItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepeatingPatternItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the underlying sequence items that can be composed into patterns along with any scores that have been used to calculate the MSI (direct or via decodes)             Initially, this will be all the distinct sequence items in the table             Once a pattern has been calculated and uploaded this will be filtered down to only those sequence items that appear in a pattern
    ApiResponse<GetEventRecordsDefaultResponse> response = apiInstance.GetRepeatingPatternItemsWithHttpInfo(getRepeatingPatternItemsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.GetRepeatingPatternItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getRepeatingPatternItemsRequest** | [**GetRepeatingPatternItemsRequest**](GetRepeatingPatternItemsRequest.md) | Gets the underlying sequence items that can be composed into patterns along with any scores that have been used to calculate the MSI (direct or via decodes)             Initially, this will be all the distinct sequence items in the table             Once a pattern has been calculated and uploaded this will be filtered down to only those sequence items that appear in a pattern |  |

### Return type

[**GetEventRecordsDefaultResponse**](GetEventRecordsDefaultResponse.md)

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

<a id="requestcancelpatterntasks"></a>
# **RequestCancelPatternTasks**
> AUTHChangePasswordDefaultResponse RequestCancelPatternTasks (RequestCancelPatternTasksRequest requestCancelPatternTasksRequest)

Requests cancellation of all tasks for a pattern. This may take some time to be actioned if the tasks are already running

Requests cancellation of all tasks for a pattern. This may take some time to be actioned if the tasks are already running

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class RequestCancelPatternTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var requestCancelPatternTasksRequest = new RequestCancelPatternTasksRequest(); // RequestCancelPatternTasksRequest | Requests cancellation of all tasks for a pattern. This may take some time to be actioned if the tasks are already running

            try
            {
                // Requests cancellation of all tasks for a pattern. This may take some time to be actioned if the tasks are already running
                AUTHChangePasswordDefaultResponse result = apiInstance.RequestCancelPatternTasks(requestCancelPatternTasksRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.RequestCancelPatternTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestCancelPatternTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests cancellation of all tasks for a pattern. This may take some time to be actioned if the tasks are already running
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.RequestCancelPatternTasksWithHttpInfo(requestCancelPatternTasksRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.RequestCancelPatternTasksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestCancelPatternTasksRequest** | [**RequestCancelPatternTasksRequest**](RequestCancelPatternTasksRequest.md) | Requests cancellation of all tasks for a pattern. This may take some time to be actioned if the tasks are already running |  |

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

<a id="updatepattern"></a>
# **UpdatePattern**
> AUTHChangePasswordDefaultResponse UpdatePattern (UpdatePatternRequest updatePatternRequest)

Updates a Pattern definition.

Updates a Pattern definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdatePatternExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var updatePatternRequest = new UpdatePatternRequest(); // UpdatePatternRequest | Updates a Pattern definition.

            try
            {
                // Updates a Pattern definition.
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdatePattern(updatePatternRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.UpdatePattern: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePatternWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Pattern definition.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdatePatternWithHttpInfo(updatePatternRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.UpdatePatternWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updatePatternRequest** | [**UpdatePatternRequest**](UpdatePatternRequest.md) | Updates a Pattern definition. |  |

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

<a id="updaterepeatingpatternitemscores"></a>
# **UpdateRepeatingPatternItemScores**
> AUTHChangePasswordDefaultResponse UpdateRepeatingPatternItemScores (UpdateRepeatingPatternItemScoresRequest updateRepeatingPatternItemScoresRequest)

Update one or more of the scores maintained against the underlying sequence item labels that are composed into patterns             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified 'alias' transform that sits along-side the sequence item data             Only one such decode alias can be scored at a time and when scores are applied they are applied from the alias first and then overridden with any score that has been stored againt the items themselves             If the scores are to be applied against a decode then its id and version must be specified             The scores are intended to denote the relative importance of items in a sequence. The label of the item with the highest score will serve as the overall label (MSI) for the sequence             Specifying zero for a score is the only way of 'unscoring' it at present

Update one or more of the scores maintained against the underlying sequence item labels that are composed into patterns             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified 'alias' transform that sits along-side the sequence item data             Only one such decode alias can be scored at a time and when scores are applied they are applied from the alias first and then overridden with any score that has been stored againt the items themselves             If the scores are to be applied against a decode then its id and version must be specified             The scores are intended to denote the relative importance of items in a sequence. The label of the item with the highest score will serve as the overall label (MSI) for the sequence             Specifying zero for a score is the only way of 'unscoring' it at present

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateRepeatingPatternItemScoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PatternsApi(config);
            var updateRepeatingPatternItemScoresRequest = new UpdateRepeatingPatternItemScoresRequest(); // UpdateRepeatingPatternItemScoresRequest | Update one or more of the scores maintained against the underlying sequence item labels that are composed into patterns             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified 'alias' transform that sits along-side the sequence item data             Only one such decode alias can be scored at a time and when scores are applied they are applied from the alias first and then overridden with any score that has been stored againt the items themselves             If the scores are to be applied against a decode then its id and version must be specified             The scores are intended to denote the relative importance of items in a sequence. The label of the item with the highest score will serve as the overall label (MSI) for the sequence             Specifying zero for a score is the only way of 'unscoring' it at present

            try
            {
                // Update one or more of the scores maintained against the underlying sequence item labels that are composed into patterns             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified 'alias' transform that sits along-side the sequence item data             Only one such decode alias can be scored at a time and when scores are applied they are applied from the alias first and then overridden with any score that has been stored againt the items themselves             If the scores are to be applied against a decode then its id and version must be specified             The scores are intended to denote the relative importance of items in a sequence. The label of the item with the highest score will serve as the overall label (MSI) for the sequence             Specifying zero for a score is the only way of 'unscoring' it at present
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateRepeatingPatternItemScores(updateRepeatingPatternItemScoresRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatternsApi.UpdateRepeatingPatternItemScores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRepeatingPatternItemScoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update one or more of the scores maintained against the underlying sequence item labels that are composed into patterns             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified 'alias' transform that sits along-side the sequence item data             Only one such decode alias can be scored at a time and when scores are applied they are applied from the alias first and then overridden with any score that has been stored againt the items themselves             If the scores are to be applied against a decode then its id and version must be specified             The scores are intended to denote the relative importance of items in a sequence. The label of the item with the highest score will serve as the overall label (MSI) for the sequence             Specifying zero for a score is the only way of 'unscoring' it at present
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateRepeatingPatternItemScoresWithHttpInfo(updateRepeatingPatternItemScoresRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatternsApi.UpdateRepeatingPatternItemScoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateRepeatingPatternItemScoresRequest** | [**UpdateRepeatingPatternItemScoresRequest**](UpdateRepeatingPatternItemScoresRequest.md) | Update one or more of the scores maintained against the underlying sequence item labels that are composed into patterns             Scores can either be recorded directly onto the Item labels themselves or they can be applied to the target labels (e.g. Journeys) that correspond to a specified &#39;alias&#39; transform that sits along-side the sequence item data             Only one such decode alias can be scored at a time and when scores are applied they are applied from the alias first and then overridden with any score that has been stored againt the items themselves             If the scores are to be applied against a decode then its id and version must be specified             The scores are intended to denote the relative importance of items in a sequence. The label of the item with the highest score will serve as the overall label (MSI) for the sequence             Specifying zero for a score is the only way of &#39;unscoring&#39; it at present |  |

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

