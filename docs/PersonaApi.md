# Alterian.JA.Api.PersonaApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePersona**](PersonaApi.md#createpersona) | **POST** /CreatePersona | Creates a @see(Persona) |
| [**DeletePersona**](PersonaApi.md#deletepersona) | **POST** /DeletePersona | Deletes a persona from the system |
| [**GetPersona**](PersonaApi.md#getpersona) | **POST** /GetPersona | Returns back a single @see(Persona) |
| [**GetPersonas**](PersonaApi.md#getpersonas) | **POST** /GetPersonas | Returns back a list of @see(Persona) |
| [**UpdatePersona**](PersonaApi.md#updatepersona) | **POST** /UpdatePersona | Updates an @see(Persona) |

<a id="createpersona"></a>
# **CreatePersona**
> CreateClientDefaultResponse CreatePersona (CreatePersonaRequest createPersonaRequest)

Creates a @see(Persona)

Creates a @see(Persona)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreatePersonaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PersonaApi(config);
            var createPersonaRequest = new CreatePersonaRequest(); // CreatePersonaRequest | Creates a @see(Persona)

            try
            {
                // Creates a @see(Persona)
                CreateClientDefaultResponse result = apiInstance.CreatePersona(createPersonaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonaApi.CreatePersona: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePersonaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a @see(Persona)
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreatePersonaWithHttpInfo(createPersonaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonaApi.CreatePersonaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPersonaRequest** | [**CreatePersonaRequest**](CreatePersonaRequest.md) | Creates a @see(Persona) |  |

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

<a id="deletepersona"></a>
# **DeletePersona**
> AUTHChangePasswordDefaultResponse DeletePersona (DeletePersonaRequest deletePersonaRequest)

Deletes a persona from the system

Deletes a persona from the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeletePersonaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PersonaApi(config);
            var deletePersonaRequest = new DeletePersonaRequest(); // DeletePersonaRequest | Deletes a persona from the system

            try
            {
                // Deletes a persona from the system
                AUTHChangePasswordDefaultResponse result = apiInstance.DeletePersona(deletePersonaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonaApi.DeletePersona: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePersonaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a persona from the system
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeletePersonaWithHttpInfo(deletePersonaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonaApi.DeletePersonaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deletePersonaRequest** | [**DeletePersonaRequest**](DeletePersonaRequest.md) | Deletes a persona from the system |  |

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

<a id="getpersona"></a>
# **GetPersona**
> GetPersonaDefaultResponse GetPersona (GetPersonaRequest getPersonaRequest)

Returns back a single @see(Persona)

Returns back a single @see(Persona)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetPersonaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PersonaApi(config);
            var getPersonaRequest = new GetPersonaRequest(); // GetPersonaRequest | Returns back a single @see(Persona)

            try
            {
                // Returns back a single @see(Persona)
                GetPersonaDefaultResponse result = apiInstance.GetPersona(getPersonaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonaApi.GetPersona: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPersonaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a single @see(Persona)
    ApiResponse<GetPersonaDefaultResponse> response = apiInstance.GetPersonaWithHttpInfo(getPersonaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonaApi.GetPersonaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPersonaRequest** | [**GetPersonaRequest**](GetPersonaRequest.md) | Returns back a single @see(Persona) |  |

### Return type

[**GetPersonaDefaultResponse**](GetPersonaDefaultResponse.md)

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

<a id="getpersonas"></a>
# **GetPersonas**
> GetPersonasDefaultResponse GetPersonas (GetPersonasRequest getPersonasRequest)

Returns back a list of @see(Persona)

Returns back a list of @see(Persona)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetPersonasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PersonaApi(config);
            var getPersonasRequest = new GetPersonasRequest(); // GetPersonasRequest | Returns back a list of @see(Persona)

            try
            {
                // Returns back a list of @see(Persona)
                GetPersonasDefaultResponse result = apiInstance.GetPersonas(getPersonasRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonaApi.GetPersonas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPersonasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a list of @see(Persona)
    ApiResponse<GetPersonasDefaultResponse> response = apiInstance.GetPersonasWithHttpInfo(getPersonasRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonaApi.GetPersonasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPersonasRequest** | [**GetPersonasRequest**](GetPersonasRequest.md) | Returns back a list of @see(Persona) |  |

### Return type

[**GetPersonasDefaultResponse**](GetPersonasDefaultResponse.md)

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

<a id="updatepersona"></a>
# **UpdatePersona**
> AUTHChangePasswordDefaultResponse UpdatePersona (CreatePersonaRequest createPersonaRequest)

Updates an @see(Persona)

Updates an @see(Persona)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdatePersonaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PersonaApi(config);
            var createPersonaRequest = new CreatePersonaRequest(); // CreatePersonaRequest | Updates an @see(Persona)

            try
            {
                // Updates an @see(Persona)
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdatePersona(createPersonaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonaApi.UpdatePersona: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePersonaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an @see(Persona)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdatePersonaWithHttpInfo(createPersonaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonaApi.UpdatePersonaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPersonaRequest** | [**CreatePersonaRequest**](CreatePersonaRequest.md) | Updates an @see(Persona) |  |

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

