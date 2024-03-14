# Alterian.JA.Api.OpportunityMatricesApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBusinessGoal**](OpportunityMatricesApi.md#createbusinessgoal) | **POST** /CreateBusinessGoal | Create a Business Goal |
| [**CreateInitiative**](OpportunityMatricesApi.md#createinitiative) | **POST** /CreateInitiative | Create a Business Initiative |
| [**CreateOpportunity**](OpportunityMatricesApi.md#createopportunity) | **POST** /CreateOpportunity | Create an opportunity |
| [**DeleteBusinessGoal**](OpportunityMatricesApi.md#deletebusinessgoal) | **POST** /DeleteBusinessGoal | Delete a Business Goal |
| [**DeleteInitiative**](OpportunityMatricesApi.md#deleteinitiative) | **POST** /DeleteInitiative | Delete a Business Initiative |
| [**DeleteOpportunity**](OpportunityMatricesApi.md#deleteopportunity) | **POST** /DeleteOpportunity | Delete an opportunity |
| [**GetBusinessGoals**](OpportunityMatricesApi.md#getbusinessgoals) | **POST** /GetBusinessGoals | Get the list of Business Goal |
| [**GetEventStreamInitiatives**](OpportunityMatricesApi.md#geteventstreaminitiatives) | **POST** /GetEventStreamInitiatives | Get initiatives for an event stream |
| [**GetInitiatives**](OpportunityMatricesApi.md#getinitiatives) | **POST** /GetInitiatives | Get all current initiatives |
| [**GetOpportunities**](OpportunityMatricesApi.md#getopportunities) | **POST** /GetOpportunities | Get the list of opportunities |
| [**GetOpportunityMatrix**](OpportunityMatricesApi.md#getopportunitymatrix) | **POST** /GetOpportunityMatrix | Gets abbreviated details of all campaigns that are currently plotted on the opportunity matrix |
| [**UpdateBusinessGoal**](OpportunityMatricesApi.md#updatebusinessgoal) | **POST** /UpdateBusinessGoal | Update a Business Goal |
| [**UpdateInitiative**](OpportunityMatricesApi.md#updateinitiative) | **POST** /UpdateInitiative | Update a Business Initiative |
| [**UpdateOpportunity**](OpportunityMatricesApi.md#updateopportunity) | **POST** /UpdateOpportunity | Update an Opportunity |
| [**UpdateOpportunityMatrix**](OpportunityMatricesApi.md#updateopportunitymatrix) | **POST** /UpdateOpportunityMatrix | Store all the details for every campaign that&#39;s now plotted on the opportunity matrix. |

<a id="createbusinessgoal"></a>
# **CreateBusinessGoal**
> CreateClientDefaultResponse CreateBusinessGoal (CreateBusinessGoalRequest createBusinessGoalRequest)

Create a Business Goal

Create a Business Goal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateBusinessGoalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var createBusinessGoalRequest = new CreateBusinessGoalRequest(); // CreateBusinessGoalRequest | Create a Business Goal

            try
            {
                // Create a Business Goal
                CreateClientDefaultResponse result = apiInstance.CreateBusinessGoal(createBusinessGoalRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.CreateBusinessGoal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBusinessGoalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Business Goal
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateBusinessGoalWithHttpInfo(createBusinessGoalRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.CreateBusinessGoalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createBusinessGoalRequest** | [**CreateBusinessGoalRequest**](CreateBusinessGoalRequest.md) | Create a Business Goal |  |

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

<a id="createinitiative"></a>
# **CreateInitiative**
> CreateClientDefaultResponse CreateInitiative (CreateInitiativeRequest createInitiativeRequest)

Create a Business Initiative

Create a Business Initiative

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateInitiativeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var createInitiativeRequest = new CreateInitiativeRequest(); // CreateInitiativeRequest | Create a Business Initiative

            try
            {
                // Create a Business Initiative
                CreateClientDefaultResponse result = apiInstance.CreateInitiative(createInitiativeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.CreateInitiative: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInitiativeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Business Initiative
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateInitiativeWithHttpInfo(createInitiativeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.CreateInitiativeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createInitiativeRequest** | [**CreateInitiativeRequest**](CreateInitiativeRequest.md) | Create a Business Initiative |  |

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

<a id="createopportunity"></a>
# **CreateOpportunity**
> CreateClientDefaultResponse CreateOpportunity (CreateOpportunityRequest createOpportunityRequest)

Create an opportunity

Create an opportunity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateOpportunityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var createOpportunityRequest = new CreateOpportunityRequest(); // CreateOpportunityRequest | Create an opportunity

            try
            {
                // Create an opportunity
                CreateClientDefaultResponse result = apiInstance.CreateOpportunity(createOpportunityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.CreateOpportunity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOpportunityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an opportunity
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateOpportunityWithHttpInfo(createOpportunityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.CreateOpportunityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOpportunityRequest** | [**CreateOpportunityRequest**](CreateOpportunityRequest.md) | Create an opportunity |  |

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

<a id="deletebusinessgoal"></a>
# **DeleteBusinessGoal**
> AUTHChangePasswordDefaultResponse DeleteBusinessGoal (DeleteBusinessGoalRequest deleteBusinessGoalRequest)

Delete a Business Goal

Delete a Business Goal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteBusinessGoalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var deleteBusinessGoalRequest = new DeleteBusinessGoalRequest(); // DeleteBusinessGoalRequest | Delete a Business Goal

            try
            {
                // Delete a Business Goal
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteBusinessGoal(deleteBusinessGoalRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.DeleteBusinessGoal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBusinessGoalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Business Goal
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteBusinessGoalWithHttpInfo(deleteBusinessGoalRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.DeleteBusinessGoalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteBusinessGoalRequest** | [**DeleteBusinessGoalRequest**](DeleteBusinessGoalRequest.md) | Delete a Business Goal |  |

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

<a id="deleteinitiative"></a>
# **DeleteInitiative**
> AUTHChangePasswordDefaultResponse DeleteInitiative (DeleteInitiativeRequest deleteInitiativeRequest)

Delete a Business Initiative

Delete a Business Initiative

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteInitiativeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var deleteInitiativeRequest = new DeleteInitiativeRequest(); // DeleteInitiativeRequest | Delete a Business Initiative

            try
            {
                // Delete a Business Initiative
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteInitiative(deleteInitiativeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.DeleteInitiative: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInitiativeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Business Initiative
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteInitiativeWithHttpInfo(deleteInitiativeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.DeleteInitiativeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteInitiativeRequest** | [**DeleteInitiativeRequest**](DeleteInitiativeRequest.md) | Delete a Business Initiative |  |

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

<a id="deleteopportunity"></a>
# **DeleteOpportunity**
> AUTHChangePasswordDefaultResponse DeleteOpportunity (DeleteOpportunityRequest deleteOpportunityRequest)

Delete an opportunity

Delete an opportunity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteOpportunityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var deleteOpportunityRequest = new DeleteOpportunityRequest(); // DeleteOpportunityRequest | Delete an opportunity

            try
            {
                // Delete an opportunity
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteOpportunity(deleteOpportunityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.DeleteOpportunity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOpportunityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an opportunity
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteOpportunityWithHttpInfo(deleteOpportunityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.DeleteOpportunityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteOpportunityRequest** | [**DeleteOpportunityRequest**](DeleteOpportunityRequest.md) | Delete an opportunity |  |

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

<a id="getbusinessgoals"></a>
# **GetBusinessGoals**
> GetBusinessGoalsDefaultResponse GetBusinessGoals ()

Get the list of Business Goal

Get the list of Business Goal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetBusinessGoalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);

            try
            {
                // Get the list of Business Goal
                GetBusinessGoalsDefaultResponse result = apiInstance.GetBusinessGoals();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.GetBusinessGoals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBusinessGoalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of Business Goal
    ApiResponse<GetBusinessGoalsDefaultResponse> response = apiInstance.GetBusinessGoalsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.GetBusinessGoalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetBusinessGoalsDefaultResponse**](GetBusinessGoalsDefaultResponse.md)

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

<a id="geteventstreaminitiatives"></a>
# **GetEventStreamInitiatives**
> GetEventStreamInitiativesDefaultResponse GetEventStreamInitiatives (GetEventStreamInitiativesRequest getEventStreamInitiativesRequest)

Get initiatives for an event stream

Get initiatives for an event stream

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamInitiativesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var getEventStreamInitiativesRequest = new GetEventStreamInitiativesRequest(); // GetEventStreamInitiativesRequest | Get initiatives for an event stream

            try
            {
                // Get initiatives for an event stream
                GetEventStreamInitiativesDefaultResponse result = apiInstance.GetEventStreamInitiatives(getEventStreamInitiativesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.GetEventStreamInitiatives: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamInitiativesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get initiatives for an event stream
    ApiResponse<GetEventStreamInitiativesDefaultResponse> response = apiInstance.GetEventStreamInitiativesWithHttpInfo(getEventStreamInitiativesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.GetEventStreamInitiativesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventStreamInitiativesRequest** | [**GetEventStreamInitiativesRequest**](GetEventStreamInitiativesRequest.md) | Get initiatives for an event stream |  |

### Return type

[**GetEventStreamInitiativesDefaultResponse**](GetEventStreamInitiativesDefaultResponse.md)

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

<a id="getinitiatives"></a>
# **GetInitiatives**
> GetEventStreamInitiativesDefaultResponse GetInitiatives ()

Get all current initiatives

Get all current initiatives

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetInitiativesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);

            try
            {
                // Get all current initiatives
                GetEventStreamInitiativesDefaultResponse result = apiInstance.GetInitiatives();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.GetInitiatives: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInitiativesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all current initiatives
    ApiResponse<GetEventStreamInitiativesDefaultResponse> response = apiInstance.GetInitiativesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.GetInitiativesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetEventStreamInitiativesDefaultResponse**](GetEventStreamInitiativesDefaultResponse.md)

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

<a id="getopportunities"></a>
# **GetOpportunities**
> GetOpportunitiesDefaultResponse GetOpportunities ()

Get the list of opportunities

Get the list of opportunities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetOpportunitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);

            try
            {
                // Get the list of opportunities
                GetOpportunitiesDefaultResponse result = apiInstance.GetOpportunities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.GetOpportunities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOpportunitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of opportunities
    ApiResponse<GetOpportunitiesDefaultResponse> response = apiInstance.GetOpportunitiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.GetOpportunitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetOpportunitiesDefaultResponse**](GetOpportunitiesDefaultResponse.md)

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

<a id="getopportunitymatrix"></a>
# **GetOpportunityMatrix**
> GetOpportunityMatrixDefaultResponse GetOpportunityMatrix ()

Gets abbreviated details of all campaigns that are currently plotted on the opportunity matrix

Gets abbreviated details of all campaigns that are currently plotted on the opportunity matrix

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetOpportunityMatrixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);

            try
            {
                // Gets abbreviated details of all campaigns that are currently plotted on the opportunity matrix
                GetOpportunityMatrixDefaultResponse result = apiInstance.GetOpportunityMatrix();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.GetOpportunityMatrix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOpportunityMatrixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets abbreviated details of all campaigns that are currently plotted on the opportunity matrix
    ApiResponse<GetOpportunityMatrixDefaultResponse> response = apiInstance.GetOpportunityMatrixWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.GetOpportunityMatrixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetOpportunityMatrixDefaultResponse**](GetOpportunityMatrixDefaultResponse.md)

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

<a id="updatebusinessgoal"></a>
# **UpdateBusinessGoal**
> AUTHChangePasswordDefaultResponse UpdateBusinessGoal (CreateBusinessGoalRequest createBusinessGoalRequest)

Update a Business Goal

Update a Business Goal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateBusinessGoalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var createBusinessGoalRequest = new CreateBusinessGoalRequest(); // CreateBusinessGoalRequest | Update a Business Goal

            try
            {
                // Update a Business Goal
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateBusinessGoal(createBusinessGoalRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.UpdateBusinessGoal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBusinessGoalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Business Goal
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateBusinessGoalWithHttpInfo(createBusinessGoalRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.UpdateBusinessGoalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createBusinessGoalRequest** | [**CreateBusinessGoalRequest**](CreateBusinessGoalRequest.md) | Update a Business Goal |  |

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

<a id="updateinitiative"></a>
# **UpdateInitiative**
> AUTHChangePasswordDefaultResponse UpdateInitiative (CreateInitiativeRequest createInitiativeRequest)

Update a Business Initiative

Update a Business Initiative

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateInitiativeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var createInitiativeRequest = new CreateInitiativeRequest(); // CreateInitiativeRequest | Update a Business Initiative

            try
            {
                // Update a Business Initiative
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateInitiative(createInitiativeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.UpdateInitiative: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInitiativeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Business Initiative
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateInitiativeWithHttpInfo(createInitiativeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.UpdateInitiativeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createInitiativeRequest** | [**CreateInitiativeRequest**](CreateInitiativeRequest.md) | Update a Business Initiative |  |

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

<a id="updateopportunity"></a>
# **UpdateOpportunity**
> AUTHChangePasswordDefaultResponse UpdateOpportunity (CreateOpportunityRequest createOpportunityRequest)

Update an Opportunity

Update an Opportunity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateOpportunityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var createOpportunityRequest = new CreateOpportunityRequest(); // CreateOpportunityRequest | Update an Opportunity

            try
            {
                // Update an Opportunity
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateOpportunity(createOpportunityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.UpdateOpportunity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOpportunityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an Opportunity
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateOpportunityWithHttpInfo(createOpportunityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.UpdateOpportunityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOpportunityRequest** | [**CreateOpportunityRequest**](CreateOpportunityRequest.md) | Update an Opportunity |  |

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

<a id="updateopportunitymatrix"></a>
# **UpdateOpportunityMatrix**
> AUTHChangePasswordDefaultResponse UpdateOpportunityMatrix (UpdateOpportunityMatrixRequest updateOpportunityMatrixRequest)

Store all the details for every campaign that's now plotted on the opportunity matrix.

Store all the details for every campaign that's now plotted on the opportunity matrix.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateOpportunityMatrixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new OpportunityMatricesApi(config);
            var updateOpportunityMatrixRequest = new UpdateOpportunityMatrixRequest(); // UpdateOpportunityMatrixRequest | Store all the details for every campaign that's now plotted on the opportunity matrix.

            try
            {
                // Store all the details for every campaign that's now plotted on the opportunity matrix.
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateOpportunityMatrix(updateOpportunityMatrixRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpportunityMatricesApi.UpdateOpportunityMatrix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOpportunityMatrixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Store all the details for every campaign that's now plotted on the opportunity matrix.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateOpportunityMatrixWithHttpInfo(updateOpportunityMatrixRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OpportunityMatricesApi.UpdateOpportunityMatrixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateOpportunityMatrixRequest** | [**UpdateOpportunityMatrixRequest**](UpdateOpportunityMatrixRequest.md) | Store all the details for every campaign that&#39;s now plotted on the opportunity matrix. |  |

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

