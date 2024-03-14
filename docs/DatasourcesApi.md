# Alterian.JA.Api.DatasourcesApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AreDatasourceCampaignsPaused**](DatasourcesApi.md#aredatasourcecampaignspaused) | **POST** /AreDatasourceCampaignsPaused | Pausing a datasource can take a while, as the campaigns and metrics in this datasource will need to complete their current action before pausing.              The @see(PauseDatasourceCampaigns) call will return immediately, but this method should be called repeatedly until the list of ID&#39;s returned is empty.             Note that the id&#39;s returned are the list of campaigns and metrics which are still running, and can be used in @see(GetCampaign) or @see(GetMetric) to get further details about the              campaign(s)/metric(s) that are preventing the datasource from pausing. |
| [**AreDatasourceJobsComplete**](DatasourcesApi.md#aredatasourcejobscomplete) | **POST** /AreDatasourceJobsComplete | Finishing off any in-progress jobs on a datasource can take a while, as the SEV loaders and archivers in this datasource will need to complete their current action before exiting.              The @see(MarkDatasourceAsPendingDisable) call will return immediately, but this method should be called repeatedly until the list of ID&#39;s returned is empty.             Note that the id&#39;s returned are the list of active jobs which are still running |
| [**CreateDataSourceMapping**](DatasourcesApi.md#createdatasourcemapping) | **POST** /CreateDataSourceMapping | Add in a @see(DatasourceUserMapping). |
| [**CreateDatasource**](DatasourcesApi.md#createdatasource) | **POST** /CreateDatasource | Creates an engine datasource configured to point at the specified server and project. |
| [**DeleteDataSourceMapping**](DatasourcesApi.md#deletedatasourcemapping) | **POST** /DeleteDataSourceMapping | Remove a @see(DatasourceUserMapping) from the system.  Once this is done, the particular @see(ALUser) will return back to using SYSTEM as the engine User |
| [**DeleteDatasource**](DatasourcesApi.md#deletedatasource) | **POST** /DeleteDatasource | Deletes a datasource.  Please note that any document which accesses this datasource might not be able to opened.  This method will fail if there are any campaigns which are active against this datasource. |
| [**DeleteFieldTransformList**](DatasourcesApi.md#deletefieldtransformlist) | **POST** /DeleteFieldTransformList | Delete all versions of the specified transformation list |
| [**DeleteTransform**](DatasourcesApi.md#deletetransform) | **POST** /DeleteTransform | Delete all versions of the specified transform |
| [**DisableDatasource**](DatasourcesApi.md#disabledatasource) | **POST** /DisableDatasource | Marks a datasource as disabled and invisible.  Typically used as part of the load process.  Please note that once you mark a datasource as disabled, anything which relies upon it will cease to function so make sure you pause campaigns first using @see(PauseDatasourceCampaigns) and verify all campaign activity has ceased with @see(AreDatasourceCampaignsPaused) |
| [**EnableDatasource**](DatasourcesApi.md#enabledatasource) | **POST** /EnableDatasource | Marks a datasource as enabled and visible.  This makes the datasource available for immediate usage.  You can optionally ask the engine listener service to refresh this datasource upon next poll.  Useful for doing a dataload. |
| [**ExportFieldTransformList**](DatasourcesApi.md#exportfieldtransformlist) | **GET** /ExportFieldTransformList | Export a list of field transforms for use in transforming discrete values |
| [**GetDataSourceAttributes**](DatasourcesApi.md#getdatasourceattributes) | **POST** /GetDataSourceAttributes | Get a list of the attributes which can be applied to the given type of datasource. |
| [**GetDataSourceEngineUserName**](DatasourcesApi.md#getdatasourceengineusername) | **POST** /GetDataSourceEngineUserName | Given a userID and datasourceID, return back the engine user name which should be used whilst connecting |
| [**GetDataSourceItems**](DatasourcesApi.md#getdatasourceitems) | **POST** /GetDataSourceItems | Allows you to search for data source objects, inclusing datasource, database, table and columns. |
| [**GetDataSourceMappings**](DatasourcesApi.md#getdatasourcemappings) | **POST** /GetDataSourceMappings | Return back the @see(DatasourceUserMapping)s in the system |
| [**GetDataSourceTypes**](DatasourcesApi.md#getdatasourcetypes) | **POST** /GetDataSourceTypes | Return back a list of @see(ALDataSourceType) for use with @see(ALDataSource)s. |
| [**GetDataSourceUsers**](DatasourcesApi.md#getdatasourceusers) | **POST** /GetDataSourceUsers | Requests a list of users from a particular @see(ALDataSource).  This call currently only functions against an Engine @see(ALDataSource). |
| [**GetDataSources**](DatasourcesApi.md#getdatasources) | **POST** /GetDataSources | Returns back a list of @see(ALDataSource)s from the system |
| [**GetDatasource**](DatasourcesApi.md#getdatasource) | **POST** /GetDatasource | Retrieves the top level data for a datasource.  Does not fully populate the datasource.  This is useful for getting things like the project, server and last refresh date. |
| [**GetDatasourceColumn**](DatasourcesApi.md#getdatasourcecolumn) | **POST** /GetDatasourceColumn | Fetch the details of one column from the system. |
| [**GetDatasourceColumns**](DatasourcesApi.md#getdatasourcecolumns) | **POST** /GetDatasourceColumns | Fetch a list of columns from the system. |
| [**GetDatasourceDatabases**](DatasourcesApi.md#getdatasourcedatabases) | **POST** /GetDatasourceDatabases | Fetch a list of databases from the system. |
| [**GetDatasourceFieldTypes**](DatasourcesApi.md#getdatasourcefieldtypes) | **POST** /GetDatasourceFieldTypes | Fetch a list of the available types of field that are supported |
| [**GetDatasourceTables**](DatasourcesApi.md#getdatasourcetables) | **POST** /GetDatasourceTables | Fetch a list of tables from the system. |
| [**GetDecodeList**](DatasourcesApi.md#getdecodelist) | **POST** /GetDecodeList | Get a specified decode list |
| [**GetFieldTransformList**](DatasourcesApi.md#getfieldtransformlist) | **POST** /GetFieldTransformList | Get a list of field transforms for use in transforming discrete values |
| [**GetFieldTransformLists**](DatasourcesApi.md#getfieldtransformlists) | **POST** /GetFieldTransformLists | Get the basic details for all available transform lists (Name, Id, (Max) Version- but not Metadata or JSON transforms) |
| [**GetProcessStatus**](DatasourcesApi.md#getprocessstatus) | **POST** /GetProcessStatus | Gets the status of a process which was queued.  Note that once the process is finished, you may only get the status once and each call thereafter will return NotFound. |
| [**GetTransforms**](DatasourcesApi.md#gettransforms) | **POST** /GetTransforms | Get the basic details for all available transforms (Name, Id, (Max) Version, Type) and which versions have actually been published |
| [**MarkDatasourceAsPendingDisable**](DatasourcesApi.md#markdatasourceaspendingdisable) | **POST** /MarkDatasourceAsPendingDisable | Mark a data source as pending disable. This will cause any active SEV threads to exit upon their next iteration, which can take a while.              Clients should then call @see(AreDatasourceJobsComplete) to check that the datasource is idle before continuing to perform the actual disable, and can call @see(DisableDatasource) |
| [**PauseDatasourceCampaigns**](DatasourcesApi.md#pausedatasourcecampaigns) | **POST** /PauseDatasourceCampaigns | Pause the campaigns in this datasource. This will request all the campaigns that use this datasource to be paused, which can take a while.              Clients should then call @see(AreDatasourceCampaignsPaused) to check that the datasource is idle before continuing, and can call @see(ResumeDatasourceCampaigns) |
| [**RefreshDatasource**](DatasourcesApi.md#refreshdatasource) | **POST** /RefreshDatasource | Requests an immediate refresh of an engine datasource.  Call @see(GetProcessStatus) to determine when the refresh has finished or check the LastRefresh date on the datasource. |
| [**ResumeDatasourceCampaigns**](DatasourcesApi.md#resumedatasourcecampaigns) | **POST** /ResumeDatasourceCampaigns | Resume the campaigns in this datasource. This is the opposite of @see(PauseDatasourceCampaigns), and only campaigns that were paused by that method will be resumed. Campaigns that             were paused manually will not be resumed. |
| [**SaveDecodeList**](DatasourcesApi.md#savedecodelist) | **POST** /SaveDecodeList | Save a list of decodes |
| [**SaveFieldTransformList**](DatasourcesApi.md#savefieldtransformlist) | **POST** /SaveFieldTransformList | Save a list of field transforms for use in transforming discrete values |
| [**UpdateDataSourceMapping**](DatasourcesApi.md#updatedatasourcemapping) | **POST** /UpdateDataSourceMapping | Updates a @see(DatasourceUserMapping) to map it to another engine user name. |
| [**UpdateDatasource**](DatasourcesApi.md#updatedatasource) | **POST** /UpdateDatasource | Updates an @see(ALDataSource) with the data which is provided.  Please note that the only properties which are relevant are IsEnabled, IsVisible, Name, LastRefresh and attributes. |

<a id="aredatasourcecampaignspaused"></a>
# **AreDatasourceCampaignsPaused**
> AreDatasourceCampaignsPausedDefaultResponse AreDatasourceCampaignsPaused (AreDatasourceCampaignsPausedRequest areDatasourceCampaignsPausedRequest)

Pausing a datasource can take a while, as the campaigns and metrics in this datasource will need to complete their current action before pausing.              The @see(PauseDatasourceCampaigns) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of campaigns and metrics which are still running, and can be used in @see(GetCampaign) or @see(GetMetric) to get further details about the              campaign(s)/metric(s) that are preventing the datasource from pausing.

Pausing a datasource can take a while, as the campaigns and metrics in this datasource will need to complete their current action before pausing.              The @see(PauseDatasourceCampaigns) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of campaigns and metrics which are still running, and can be used in @see(GetCampaign) or @see(GetMetric) to get further details about the              campaign(s)/metric(s) that are preventing the datasource from pausing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AreDatasourceCampaignsPausedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var areDatasourceCampaignsPausedRequest = new AreDatasourceCampaignsPausedRequest(); // AreDatasourceCampaignsPausedRequest | Pausing a datasource can take a while, as the campaigns and metrics in this datasource will need to complete their current action before pausing.              The @see(PauseDatasourceCampaigns) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of campaigns and metrics which are still running, and can be used in @see(GetCampaign) or @see(GetMetric) to get further details about the              campaign(s)/metric(s) that are preventing the datasource from pausing.

            try
            {
                // Pausing a datasource can take a while, as the campaigns and metrics in this datasource will need to complete their current action before pausing.              The @see(PauseDatasourceCampaigns) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of campaigns and metrics which are still running, and can be used in @see(GetCampaign) or @see(GetMetric) to get further details about the              campaign(s)/metric(s) that are preventing the datasource from pausing.
                AreDatasourceCampaignsPausedDefaultResponse result = apiInstance.AreDatasourceCampaignsPaused(areDatasourceCampaignsPausedRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.AreDatasourceCampaignsPaused: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AreDatasourceCampaignsPausedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pausing a datasource can take a while, as the campaigns and metrics in this datasource will need to complete their current action before pausing.              The @see(PauseDatasourceCampaigns) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of campaigns and metrics which are still running, and can be used in @see(GetCampaign) or @see(GetMetric) to get further details about the              campaign(s)/metric(s) that are preventing the datasource from pausing.
    ApiResponse<AreDatasourceCampaignsPausedDefaultResponse> response = apiInstance.AreDatasourceCampaignsPausedWithHttpInfo(areDatasourceCampaignsPausedRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.AreDatasourceCampaignsPausedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areDatasourceCampaignsPausedRequest** | [**AreDatasourceCampaignsPausedRequest**](AreDatasourceCampaignsPausedRequest.md) | Pausing a datasource can take a while, as the campaigns and metrics in this datasource will need to complete their current action before pausing.              The @see(PauseDatasourceCampaigns) call will return immediately, but this method should be called repeatedly until the list of ID&#39;s returned is empty.             Note that the id&#39;s returned are the list of campaigns and metrics which are still running, and can be used in @see(GetCampaign) or @see(GetMetric) to get further details about the              campaign(s)/metric(s) that are preventing the datasource from pausing. |  |

### Return type

[**AreDatasourceCampaignsPausedDefaultResponse**](AreDatasourceCampaignsPausedDefaultResponse.md)

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

<a id="aredatasourcejobscomplete"></a>
# **AreDatasourceJobsComplete**
> AreDatasourceCampaignsPausedDefaultResponse AreDatasourceJobsComplete (AreDatasourceJobsCompleteRequest areDatasourceJobsCompleteRequest)

Finishing off any in-progress jobs on a datasource can take a while, as the SEV loaders and archivers in this datasource will need to complete their current action before exiting.              The @see(MarkDatasourceAsPendingDisable) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of active jobs which are still running

Finishing off any in-progress jobs on a datasource can take a while, as the SEV loaders and archivers in this datasource will need to complete their current action before exiting.              The @see(MarkDatasourceAsPendingDisable) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of active jobs which are still running

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class AreDatasourceJobsCompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var areDatasourceJobsCompleteRequest = new AreDatasourceJobsCompleteRequest(); // AreDatasourceJobsCompleteRequest | Finishing off any in-progress jobs on a datasource can take a while, as the SEV loaders and archivers in this datasource will need to complete their current action before exiting.              The @see(MarkDatasourceAsPendingDisable) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of active jobs which are still running

            try
            {
                // Finishing off any in-progress jobs on a datasource can take a while, as the SEV loaders and archivers in this datasource will need to complete their current action before exiting.              The @see(MarkDatasourceAsPendingDisable) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of active jobs which are still running
                AreDatasourceCampaignsPausedDefaultResponse result = apiInstance.AreDatasourceJobsComplete(areDatasourceJobsCompleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.AreDatasourceJobsComplete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AreDatasourceJobsCompleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Finishing off any in-progress jobs on a datasource can take a while, as the SEV loaders and archivers in this datasource will need to complete their current action before exiting.              The @see(MarkDatasourceAsPendingDisable) call will return immediately, but this method should be called repeatedly until the list of ID's returned is empty.             Note that the id's returned are the list of active jobs which are still running
    ApiResponse<AreDatasourceCampaignsPausedDefaultResponse> response = apiInstance.AreDatasourceJobsCompleteWithHttpInfo(areDatasourceJobsCompleteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.AreDatasourceJobsCompleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areDatasourceJobsCompleteRequest** | [**AreDatasourceJobsCompleteRequest**](AreDatasourceJobsCompleteRequest.md) | Finishing off any in-progress jobs on a datasource can take a while, as the SEV loaders and archivers in this datasource will need to complete their current action before exiting.              The @see(MarkDatasourceAsPendingDisable) call will return immediately, but this method should be called repeatedly until the list of ID&#39;s returned is empty.             Note that the id&#39;s returned are the list of active jobs which are still running |  |

### Return type

[**AreDatasourceCampaignsPausedDefaultResponse**](AreDatasourceCampaignsPausedDefaultResponse.md)

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

<a id="createdatasourcemapping"></a>
# **CreateDataSourceMapping**
> AUTHChangePasswordDefaultResponse CreateDataSourceMapping (CreateDataSourceMappingRequest createDataSourceMappingRequest)

Add in a @see(DatasourceUserMapping).

Add in a @see(DatasourceUserMapping).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateDataSourceMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var createDataSourceMappingRequest = new CreateDataSourceMappingRequest(); // CreateDataSourceMappingRequest | Add in a @see(DatasourceUserMapping).

            try
            {
                // Add in a @see(DatasourceUserMapping).
                AUTHChangePasswordDefaultResponse result = apiInstance.CreateDataSourceMapping(createDataSourceMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.CreateDataSourceMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataSourceMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add in a @see(DatasourceUserMapping).
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.CreateDataSourceMappingWithHttpInfo(createDataSourceMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.CreateDataSourceMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDataSourceMappingRequest** | [**CreateDataSourceMappingRequest**](CreateDataSourceMappingRequest.md) | Add in a @see(DatasourceUserMapping). |  |

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

<a id="createdatasource"></a>
# **CreateDatasource**
> CreateClientDefaultResponse CreateDatasource (CreateDatasourceRequest createDatasourceRequest)

Creates an engine datasource configured to point at the specified server and project.

Creates an engine datasource configured to point at the specified server and project.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateDatasourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var createDatasourceRequest = new CreateDatasourceRequest(); // CreateDatasourceRequest | Creates an engine datasource configured to point at the specified server and project.

            try
            {
                // Creates an engine datasource configured to point at the specified server and project.
                CreateClientDefaultResponse result = apiInstance.CreateDatasource(createDatasourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.CreateDatasource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDatasourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an engine datasource configured to point at the specified server and project.
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateDatasourceWithHttpInfo(createDatasourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.CreateDatasourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDatasourceRequest** | [**CreateDatasourceRequest**](CreateDatasourceRequest.md) | Creates an engine datasource configured to point at the specified server and project. |  |

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

<a id="deletedatasourcemapping"></a>
# **DeleteDataSourceMapping**
> AUTHChangePasswordDefaultResponse DeleteDataSourceMapping (CreateDataSourceMappingRequest createDataSourceMappingRequest)

Remove a @see(DatasourceUserMapping) from the system.  Once this is done, the particular @see(ALUser) will return back to using SYSTEM as the engine User

Remove a @see(DatasourceUserMapping) from the system.  Once this is done, the particular @see(ALUser) will return back to using SYSTEM as the engine User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteDataSourceMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var createDataSourceMappingRequest = new CreateDataSourceMappingRequest(); // CreateDataSourceMappingRequest | Remove a @see(DatasourceUserMapping) from the system.  Once this is done, the particular @see(ALUser) will return back to using SYSTEM as the engine User

            try
            {
                // Remove a @see(DatasourceUserMapping) from the system.  Once this is done, the particular @see(ALUser) will return back to using SYSTEM as the engine User
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteDataSourceMapping(createDataSourceMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.DeleteDataSourceMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDataSourceMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a @see(DatasourceUserMapping) from the system.  Once this is done, the particular @see(ALUser) will return back to using SYSTEM as the engine User
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteDataSourceMappingWithHttpInfo(createDataSourceMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.DeleteDataSourceMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDataSourceMappingRequest** | [**CreateDataSourceMappingRequest**](CreateDataSourceMappingRequest.md) | Remove a @see(DatasourceUserMapping) from the system.  Once this is done, the particular @see(ALUser) will return back to using SYSTEM as the engine User |  |

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

<a id="deletedatasource"></a>
# **DeleteDatasource**
> AUTHChangePasswordDefaultResponse DeleteDatasource (DeleteDatasourceRequest deleteDatasourceRequest)

Deletes a datasource.  Please note that any document which accesses this datasource might not be able to opened.  This method will fail if there are any campaigns which are active against this datasource.

Deletes a datasource.  Please note that any document which accesses this datasource might not be able to opened.  This method will fail if there are any campaigns which are active against this datasource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteDatasourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var deleteDatasourceRequest = new DeleteDatasourceRequest(); // DeleteDatasourceRequest | Deletes a datasource.  Please note that any document which accesses this datasource might not be able to opened.  This method will fail if there are any campaigns which are active against this datasource.

            try
            {
                // Deletes a datasource.  Please note that any document which accesses this datasource might not be able to opened.  This method will fail if there are any campaigns which are active against this datasource.
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteDatasource(deleteDatasourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.DeleteDatasource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDatasourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a datasource.  Please note that any document which accesses this datasource might not be able to opened.  This method will fail if there are any campaigns which are active against this datasource.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteDatasourceWithHttpInfo(deleteDatasourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.DeleteDatasourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteDatasourceRequest** | [**DeleteDatasourceRequest**](DeleteDatasourceRequest.md) | Deletes a datasource.  Please note that any document which accesses this datasource might not be able to opened.  This method will fail if there are any campaigns which are active against this datasource. |  |

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

<a id="deletefieldtransformlist"></a>
# **DeleteFieldTransformList**
> AUTHChangePasswordDefaultResponse DeleteFieldTransformList (DeleteFieldTransformListRequest deleteFieldTransformListRequest)

Delete all versions of the specified transformation list

Delete all versions of the specified transformation list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteFieldTransformListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var deleteFieldTransformListRequest = new DeleteFieldTransformListRequest(); // DeleteFieldTransformListRequest | Delete all versions of the specified transformation list

            try
            {
                // Delete all versions of the specified transformation list
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteFieldTransformList(deleteFieldTransformListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.DeleteFieldTransformList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFieldTransformListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all versions of the specified transformation list
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteFieldTransformListWithHttpInfo(deleteFieldTransformListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.DeleteFieldTransformListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteFieldTransformListRequest** | [**DeleteFieldTransformListRequest**](DeleteFieldTransformListRequest.md) | Delete all versions of the specified transformation list |  |

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

<a id="deletetransform"></a>
# **DeleteTransform**
> AUTHChangePasswordDefaultResponse DeleteTransform (DeleteTransformRequest deleteTransformRequest)

Delete all versions of the specified transform

Delete all versions of the specified transform

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteTransformExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var deleteTransformRequest = new DeleteTransformRequest(); // DeleteTransformRequest | Delete all versions of the specified transform

            try
            {
                // Delete all versions of the specified transform
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteTransform(deleteTransformRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.DeleteTransform: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransformWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all versions of the specified transform
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteTransformWithHttpInfo(deleteTransformRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.DeleteTransformWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteTransformRequest** | [**DeleteTransformRequest**](DeleteTransformRequest.md) | Delete all versions of the specified transform |  |

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

<a id="disabledatasource"></a>
# **DisableDatasource**
> AUTHChangePasswordDefaultResponse DisableDatasource (DisableDatasourceRequest disableDatasourceRequest)

Marks a datasource as disabled and invisible.  Typically used as part of the load process.  Please note that once you mark a datasource as disabled, anything which relies upon it will cease to function so make sure you pause campaigns first using @see(PauseDatasourceCampaigns) and verify all campaign activity has ceased with @see(AreDatasourceCampaignsPaused)

Marks a datasource as disabled and invisible.  Typically used as part of the load process.  Please note that once you mark a datasource as disabled, anything which relies upon it will cease to function so make sure you pause campaigns first using @see(PauseDatasourceCampaigns) and verify all campaign activity has ceased with @see(AreDatasourceCampaignsPaused)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DisableDatasourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var disableDatasourceRequest = new DisableDatasourceRequest(); // DisableDatasourceRequest | Marks a datasource as disabled and invisible.  Typically used as part of the load process.  Please note that once you mark a datasource as disabled, anything which relies upon it will cease to function so make sure you pause campaigns first using @see(PauseDatasourceCampaigns) and verify all campaign activity has ceased with @see(AreDatasourceCampaignsPaused)

            try
            {
                // Marks a datasource as disabled and invisible.  Typically used as part of the load process.  Please note that once you mark a datasource as disabled, anything which relies upon it will cease to function so make sure you pause campaigns first using @see(PauseDatasourceCampaigns) and verify all campaign activity has ceased with @see(AreDatasourceCampaignsPaused)
                AUTHChangePasswordDefaultResponse result = apiInstance.DisableDatasource(disableDatasourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.DisableDatasource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableDatasourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Marks a datasource as disabled and invisible.  Typically used as part of the load process.  Please note that once you mark a datasource as disabled, anything which relies upon it will cease to function so make sure you pause campaigns first using @see(PauseDatasourceCampaigns) and verify all campaign activity has ceased with @see(AreDatasourceCampaignsPaused)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DisableDatasourceWithHttpInfo(disableDatasourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.DisableDatasourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **disableDatasourceRequest** | [**DisableDatasourceRequest**](DisableDatasourceRequest.md) | Marks a datasource as disabled and invisible.  Typically used as part of the load process.  Please note that once you mark a datasource as disabled, anything which relies upon it will cease to function so make sure you pause campaigns first using @see(PauseDatasourceCampaigns) and verify all campaign activity has ceased with @see(AreDatasourceCampaignsPaused) |  |

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

<a id="enabledatasource"></a>
# **EnableDatasource**
> AUTHChangePasswordDefaultResponse EnableDatasource (EnableDatasourceRequest enableDatasourceRequest)

Marks a datasource as enabled and visible.  This makes the datasource available for immediate usage.  You can optionally ask the engine listener service to refresh this datasource upon next poll.  Useful for doing a dataload.

Marks a datasource as enabled and visible.  This makes the datasource available for immediate usage.  You can optionally ask the engine listener service to refresh this datasource upon next poll.  Useful for doing a dataload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class EnableDatasourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var enableDatasourceRequest = new EnableDatasourceRequest(); // EnableDatasourceRequest | Marks a datasource as enabled and visible.  This makes the datasource available for immediate usage.  You can optionally ask the engine listener service to refresh this datasource upon next poll.  Useful for doing a dataload.

            try
            {
                // Marks a datasource as enabled and visible.  This makes the datasource available for immediate usage.  You can optionally ask the engine listener service to refresh this datasource upon next poll.  Useful for doing a dataload.
                AUTHChangePasswordDefaultResponse result = apiInstance.EnableDatasource(enableDatasourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.EnableDatasource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableDatasourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Marks a datasource as enabled and visible.  This makes the datasource available for immediate usage.  You can optionally ask the engine listener service to refresh this datasource upon next poll.  Useful for doing a dataload.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.EnableDatasourceWithHttpInfo(enableDatasourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.EnableDatasourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enableDatasourceRequest** | [**EnableDatasourceRequest**](EnableDatasourceRequest.md) | Marks a datasource as enabled and visible.  This makes the datasource available for immediate usage.  You can optionally ask the engine listener service to refresh this datasource upon next poll.  Useful for doing a dataload. |  |

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

<a id="exportfieldtransformlist"></a>
# **ExportFieldTransformList**
> System.IO.Stream ExportFieldTransformList (int? id = null, int? varVersion = null)

Export a list of field transforms for use in transforming discrete values

Export a list of field transforms for use in transforming discrete values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class ExportFieldTransformListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var id = 56;  // int? |  (optional) 
            var varVersion = 56;  // int? |  (optional) 

            try
            {
                // Export a list of field transforms for use in transforming discrete values
                System.IO.Stream result = apiInstance.ExportFieldTransformList(id, varVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.ExportFieldTransformList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportFieldTransformListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export a list of field transforms for use in transforming discrete values
    ApiResponse<System.IO.Stream> response = apiInstance.ExportFieldTransformListWithHttpInfo(id, varVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.ExportFieldTransformListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** |  | [optional]  |
| **varVersion** | **int?** |  | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatasourceattributes"></a>
# **GetDataSourceAttributes**
> GetDataSourceAttributesDefaultResponse GetDataSourceAttributes (GetDataSourceAttributesRequest getDataSourceAttributesRequest)

Get a list of the attributes which can be applied to the given type of datasource.

Get a list of the attributes which can be applied to the given type of datasource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDataSourceAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDataSourceAttributesRequest = new GetDataSourceAttributesRequest(); // GetDataSourceAttributesRequest | Get a list of the attributes which can be applied to the given type of datasource.

            try
            {
                // Get a list of the attributes which can be applied to the given type of datasource.
                GetDataSourceAttributesDefaultResponse result = apiInstance.GetDataSourceAttributes(getDataSourceAttributesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDataSourceAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of the attributes which can be applied to the given type of datasource.
    ApiResponse<GetDataSourceAttributesDefaultResponse> response = apiInstance.GetDataSourceAttributesWithHttpInfo(getDataSourceAttributesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDataSourceAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDataSourceAttributesRequest** | [**GetDataSourceAttributesRequest**](GetDataSourceAttributesRequest.md) | Get a list of the attributes which can be applied to the given type of datasource. |  |

### Return type

[**GetDataSourceAttributesDefaultResponse**](GetDataSourceAttributesDefaultResponse.md)

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

<a id="getdatasourceengineusername"></a>
# **GetDataSourceEngineUserName**
> GetDataSourceEngineUserNameDefaultResponse GetDataSourceEngineUserName (GetDataSourceEngineUserNameRequest getDataSourceEngineUserNameRequest)

Given a userID and datasourceID, return back the engine user name which should be used whilst connecting

Given a userID and datasourceID, return back the engine user name which should be used whilst connecting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDataSourceEngineUserNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDataSourceEngineUserNameRequest = new GetDataSourceEngineUserNameRequest(); // GetDataSourceEngineUserNameRequest | Given a userID and datasourceID, return back the engine user name which should be used whilst connecting

            try
            {
                // Given a userID and datasourceID, return back the engine user name which should be used whilst connecting
                GetDataSourceEngineUserNameDefaultResponse result = apiInstance.GetDataSourceEngineUserName(getDataSourceEngineUserNameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDataSourceEngineUserName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceEngineUserNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Given a userID and datasourceID, return back the engine user name which should be used whilst connecting
    ApiResponse<GetDataSourceEngineUserNameDefaultResponse> response = apiInstance.GetDataSourceEngineUserNameWithHttpInfo(getDataSourceEngineUserNameRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDataSourceEngineUserNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDataSourceEngineUserNameRequest** | [**GetDataSourceEngineUserNameRequest**](GetDataSourceEngineUserNameRequest.md) | Given a userID and datasourceID, return back the engine user name which should be used whilst connecting |  |

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

<a id="getdatasourceitems"></a>
# **GetDataSourceItems**
> GetDataSourceItemsDefaultResponse GetDataSourceItems (GetDataSourceItemsRequest getDataSourceItemsRequest)

Allows you to search for data source objects, inclusing datasource, database, table and columns.

Allows you to search for data source objects, inclusing datasource, database, table and columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDataSourceItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDataSourceItemsRequest = new GetDataSourceItemsRequest(); // GetDataSourceItemsRequest | Allows you to search for data source objects, inclusing datasource, database, table and columns.

            try
            {
                // Allows you to search for data source objects, inclusing datasource, database, table and columns.
                GetDataSourceItemsDefaultResponse result = apiInstance.GetDataSourceItems(getDataSourceItemsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDataSourceItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allows you to search for data source objects, inclusing datasource, database, table and columns.
    ApiResponse<GetDataSourceItemsDefaultResponse> response = apiInstance.GetDataSourceItemsWithHttpInfo(getDataSourceItemsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDataSourceItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDataSourceItemsRequest** | [**GetDataSourceItemsRequest**](GetDataSourceItemsRequest.md) | Allows you to search for data source objects, inclusing datasource, database, table and columns. |  |

### Return type

[**GetDataSourceItemsDefaultResponse**](GetDataSourceItemsDefaultResponse.md)

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

<a id="getdatasourcemappings"></a>
# **GetDataSourceMappings**
> GetDataSourceMappingsDefaultResponse GetDataSourceMappings (GetDataSourceMappingsRequest getDataSourceMappingsRequest)

Return back the @see(DatasourceUserMapping)s in the system

Return back the @see(DatasourceUserMapping)s in the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDataSourceMappingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDataSourceMappingsRequest = new GetDataSourceMappingsRequest(); // GetDataSourceMappingsRequest | Return back the @see(DatasourceUserMapping)s in the system

            try
            {
                // Return back the @see(DatasourceUserMapping)s in the system
                GetDataSourceMappingsDefaultResponse result = apiInstance.GetDataSourceMappings(getDataSourceMappingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDataSourceMappings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceMappingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back the @see(DatasourceUserMapping)s in the system
    ApiResponse<GetDataSourceMappingsDefaultResponse> response = apiInstance.GetDataSourceMappingsWithHttpInfo(getDataSourceMappingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDataSourceMappingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDataSourceMappingsRequest** | [**GetDataSourceMappingsRequest**](GetDataSourceMappingsRequest.md) | Return back the @see(DatasourceUserMapping)s in the system |  |

### Return type

[**GetDataSourceMappingsDefaultResponse**](GetDataSourceMappingsDefaultResponse.md)

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

<a id="getdatasourcetypes"></a>
# **GetDataSourceTypes**
> GetDataSourceTypesDefaultResponse GetDataSourceTypes (GetClientSetsRequest getClientSetsRequest)

Return back a list of @see(ALDataSourceType) for use with @see(ALDataSource)s.

Return back a list of @see(ALDataSourceType) for use with @see(ALDataSource)s.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDataSourceTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | Return back a list of @see(ALDataSourceType) for use with @see(ALDataSource)s.

            try
            {
                // Return back a list of @see(ALDataSourceType) for use with @see(ALDataSource)s.
                GetDataSourceTypesDefaultResponse result = apiInstance.GetDataSourceTypes(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDataSourceTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back a list of @see(ALDataSourceType) for use with @see(ALDataSource)s.
    ApiResponse<GetDataSourceTypesDefaultResponse> response = apiInstance.GetDataSourceTypesWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDataSourceTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | Return back a list of @see(ALDataSourceType) for use with @see(ALDataSource)s. |  |

### Return type

[**GetDataSourceTypesDefaultResponse**](GetDataSourceTypesDefaultResponse.md)

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

<a id="getdatasourceusers"></a>
# **GetDataSourceUsers**
> GetDataSourceUsersDefaultResponse GetDataSourceUsers (GetDataSourceUsersRequest getDataSourceUsersRequest)

Requests a list of users from a particular @see(ALDataSource).  This call currently only functions against an Engine @see(ALDataSource).

Requests a list of users from a particular @see(ALDataSource).  This call currently only functions against an Engine @see(ALDataSource).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDataSourceUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDataSourceUsersRequest = new GetDataSourceUsersRequest(); // GetDataSourceUsersRequest | Requests a list of users from a particular @see(ALDataSource).  This call currently only functions against an Engine @see(ALDataSource).

            try
            {
                // Requests a list of users from a particular @see(ALDataSource).  This call currently only functions against an Engine @see(ALDataSource).
                GetDataSourceUsersDefaultResponse result = apiInstance.GetDataSourceUsers(getDataSourceUsersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDataSourceUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourceUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests a list of users from a particular @see(ALDataSource).  This call currently only functions against an Engine @see(ALDataSource).
    ApiResponse<GetDataSourceUsersDefaultResponse> response = apiInstance.GetDataSourceUsersWithHttpInfo(getDataSourceUsersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDataSourceUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDataSourceUsersRequest** | [**GetDataSourceUsersRequest**](GetDataSourceUsersRequest.md) | Requests a list of users from a particular @see(ALDataSource).  This call currently only functions against an Engine @see(ALDataSource). |  |

### Return type

[**GetDataSourceUsersDefaultResponse**](GetDataSourceUsersDefaultResponse.md)

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

<a id="getdatasources"></a>
# **GetDataSources**
> GetDataSourcesDefaultResponse GetDataSources (GetDataSourcesRequest getDataSourcesRequest)

Returns back a list of @see(ALDataSource)s from the system

Returns back a list of @see(ALDataSource)s from the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDataSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDataSourcesRequest = new GetDataSourcesRequest(); // GetDataSourcesRequest | Returns back a list of @see(ALDataSource)s from the system

            try
            {
                // Returns back a list of @see(ALDataSource)s from the system
                GetDataSourcesDefaultResponse result = apiInstance.GetDataSources(getDataSourcesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDataSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a list of @see(ALDataSource)s from the system
    ApiResponse<GetDataSourcesDefaultResponse> response = apiInstance.GetDataSourcesWithHttpInfo(getDataSourcesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDataSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDataSourcesRequest** | [**GetDataSourcesRequest**](GetDataSourcesRequest.md) | Returns back a list of @see(ALDataSource)s from the system |  |

### Return type

[**GetDataSourcesDefaultResponse**](GetDataSourcesDefaultResponse.md)

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

<a id="getdatasource"></a>
# **GetDatasource**
> GetDatasourceDefaultResponse GetDatasource (GetDatasourceRequest getDatasourceRequest)

Retrieves the top level data for a datasource.  Does not fully populate the datasource.  This is useful for getting things like the project, server and last refresh date.

Retrieves the top level data for a datasource.  Does not fully populate the datasource.  This is useful for getting things like the project, server and last refresh date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDatasourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDatasourceRequest = new GetDatasourceRequest(); // GetDatasourceRequest | Retrieves the top level data for a datasource.  Does not fully populate the datasource.  This is useful for getting things like the project, server and last refresh date.

            try
            {
                // Retrieves the top level data for a datasource.  Does not fully populate the datasource.  This is useful for getting things like the project, server and last refresh date.
                GetDatasourceDefaultResponse result = apiInstance.GetDatasource(getDatasourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDatasource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the top level data for a datasource.  Does not fully populate the datasource.  This is useful for getting things like the project, server and last refresh date.
    ApiResponse<GetDatasourceDefaultResponse> response = apiInstance.GetDatasourceWithHttpInfo(getDatasourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDatasourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDatasourceRequest** | [**GetDatasourceRequest**](GetDatasourceRequest.md) | Retrieves the top level data for a datasource.  Does not fully populate the datasource.  This is useful for getting things like the project, server and last refresh date. |  |

### Return type

[**GetDatasourceDefaultResponse**](GetDatasourceDefaultResponse.md)

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

<a id="getdatasourcecolumn"></a>
# **GetDatasourceColumn**
> GetDatasourceColumnDefaultResponse GetDatasourceColumn (GetDatasourceColumnRequest getDatasourceColumnRequest)

Fetch the details of one column from the system.

Fetch the details of one column from the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDatasourceColumnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDatasourceColumnRequest = new GetDatasourceColumnRequest(); // GetDatasourceColumnRequest | Fetch the details of one column from the system.

            try
            {
                // Fetch the details of one column from the system.
                GetDatasourceColumnDefaultResponse result = apiInstance.GetDatasourceColumn(getDatasourceColumnRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDatasourceColumn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasourceColumnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch the details of one column from the system.
    ApiResponse<GetDatasourceColumnDefaultResponse> response = apiInstance.GetDatasourceColumnWithHttpInfo(getDatasourceColumnRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDatasourceColumnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDatasourceColumnRequest** | [**GetDatasourceColumnRequest**](GetDatasourceColumnRequest.md) | Fetch the details of one column from the system. |  |

### Return type

[**GetDatasourceColumnDefaultResponse**](GetDatasourceColumnDefaultResponse.md)

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

<a id="getdatasourcecolumns"></a>
# **GetDatasourceColumns**
> GetDatasourceColumnsDefaultResponse GetDatasourceColumns (GetDatasourceColumnsRequest getDatasourceColumnsRequest)

Fetch a list of columns from the system.

Fetch a list of columns from the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDatasourceColumnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDatasourceColumnsRequest = new GetDatasourceColumnsRequest(); // GetDatasourceColumnsRequest | Fetch a list of columns from the system.

            try
            {
                // Fetch a list of columns from the system.
                GetDatasourceColumnsDefaultResponse result = apiInstance.GetDatasourceColumns(getDatasourceColumnsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDatasourceColumns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasourceColumnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a list of columns from the system.
    ApiResponse<GetDatasourceColumnsDefaultResponse> response = apiInstance.GetDatasourceColumnsWithHttpInfo(getDatasourceColumnsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDatasourceColumnsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDatasourceColumnsRequest** | [**GetDatasourceColumnsRequest**](GetDatasourceColumnsRequest.md) | Fetch a list of columns from the system. |  |

### Return type

[**GetDatasourceColumnsDefaultResponse**](GetDatasourceColumnsDefaultResponse.md)

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

<a id="getdatasourcedatabases"></a>
# **GetDatasourceDatabases**
> GetDatasourceDatabasesDefaultResponse GetDatasourceDatabases (GetDatasourceDatabasesRequest getDatasourceDatabasesRequest)

Fetch a list of databases from the system.

Fetch a list of databases from the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDatasourceDatabasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDatasourceDatabasesRequest = new GetDatasourceDatabasesRequest(); // GetDatasourceDatabasesRequest | Fetch a list of databases from the system.

            try
            {
                // Fetch a list of databases from the system.
                GetDatasourceDatabasesDefaultResponse result = apiInstance.GetDatasourceDatabases(getDatasourceDatabasesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDatasourceDatabases: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasourceDatabasesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a list of databases from the system.
    ApiResponse<GetDatasourceDatabasesDefaultResponse> response = apiInstance.GetDatasourceDatabasesWithHttpInfo(getDatasourceDatabasesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDatasourceDatabasesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDatasourceDatabasesRequest** | [**GetDatasourceDatabasesRequest**](GetDatasourceDatabasesRequest.md) | Fetch a list of databases from the system. |  |

### Return type

[**GetDatasourceDatabasesDefaultResponse**](GetDatasourceDatabasesDefaultResponse.md)

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

<a id="getdatasourcefieldtypes"></a>
# **GetDatasourceFieldTypes**
> GetDatasourceFieldTypesDefaultResponse GetDatasourceFieldTypes (GetClientSetsRequest getClientSetsRequest)

Fetch a list of the available types of field that are supported

Fetch a list of the available types of field that are supported

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDatasourceFieldTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | Fetch a list of the available types of field that are supported

            try
            {
                // Fetch a list of the available types of field that are supported
                GetDatasourceFieldTypesDefaultResponse result = apiInstance.GetDatasourceFieldTypes(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDatasourceFieldTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasourceFieldTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a list of the available types of field that are supported
    ApiResponse<GetDatasourceFieldTypesDefaultResponse> response = apiInstance.GetDatasourceFieldTypesWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDatasourceFieldTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | Fetch a list of the available types of field that are supported |  |

### Return type

[**GetDatasourceFieldTypesDefaultResponse**](GetDatasourceFieldTypesDefaultResponse.md)

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

<a id="getdatasourcetables"></a>
# **GetDatasourceTables**
> GetDatasourceTablesDefaultResponse GetDatasourceTables (GetDatasourceTablesRequest getDatasourceTablesRequest)

Fetch a list of tables from the system.

Fetch a list of tables from the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDatasourceTablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDatasourceTablesRequest = new GetDatasourceTablesRequest(); // GetDatasourceTablesRequest | Fetch a list of tables from the system.

            try
            {
                // Fetch a list of tables from the system.
                GetDatasourceTablesDefaultResponse result = apiInstance.GetDatasourceTables(getDatasourceTablesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDatasourceTables: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasourceTablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a list of tables from the system.
    ApiResponse<GetDatasourceTablesDefaultResponse> response = apiInstance.GetDatasourceTablesWithHttpInfo(getDatasourceTablesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDatasourceTablesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDatasourceTablesRequest** | [**GetDatasourceTablesRequest**](GetDatasourceTablesRequest.md) | Fetch a list of tables from the system. |  |

### Return type

[**GetDatasourceTablesDefaultResponse**](GetDatasourceTablesDefaultResponse.md)

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

<a id="getdecodelist"></a>
# **GetDecodeList**
> GetDecodeListDefaultResponse GetDecodeList (GetDecodeListRequest getDecodeListRequest)

Get a specified decode list

Get a specified decode list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetDecodeListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getDecodeListRequest = new GetDecodeListRequest(); // GetDecodeListRequest | Get a specified decode list

            try
            {
                // Get a specified decode list
                GetDecodeListDefaultResponse result = apiInstance.GetDecodeList(getDecodeListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetDecodeList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDecodeListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specified decode list
    ApiResponse<GetDecodeListDefaultResponse> response = apiInstance.GetDecodeListWithHttpInfo(getDecodeListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetDecodeListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getDecodeListRequest** | [**GetDecodeListRequest**](GetDecodeListRequest.md) | Get a specified decode list |  |

### Return type

[**GetDecodeListDefaultResponse**](GetDecodeListDefaultResponse.md)

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

<a id="getfieldtransformlist"></a>
# **GetFieldTransformList**
> GetFieldTransformListDefaultResponse GetFieldTransformList (GetFieldTransformListRequest getFieldTransformListRequest)

Get a list of field transforms for use in transforming discrete values

Get a list of field transforms for use in transforming discrete values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetFieldTransformListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getFieldTransformListRequest = new GetFieldTransformListRequest(); // GetFieldTransformListRequest | Get a list of field transforms for use in transforming discrete values

            try
            {
                // Get a list of field transforms for use in transforming discrete values
                GetFieldTransformListDefaultResponse result = apiInstance.GetFieldTransformList(getFieldTransformListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetFieldTransformList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFieldTransformListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of field transforms for use in transforming discrete values
    ApiResponse<GetFieldTransformListDefaultResponse> response = apiInstance.GetFieldTransformListWithHttpInfo(getFieldTransformListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetFieldTransformListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getFieldTransformListRequest** | [**GetFieldTransformListRequest**](GetFieldTransformListRequest.md) | Get a list of field transforms for use in transforming discrete values |  |

### Return type

[**GetFieldTransformListDefaultResponse**](GetFieldTransformListDefaultResponse.md)

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

<a id="getfieldtransformlists"></a>
# **GetFieldTransformLists**
> GetFieldTransformListsDefaultResponse GetFieldTransformLists (GetClientSetsRequest getClientSetsRequest)

Get the basic details for all available transform lists (Name, Id, (Max) Version- but not Metadata or JSON transforms)

Get the basic details for all available transform lists (Name, Id, (Max) Version- but not Metadata or JSON transforms)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetFieldTransformListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | Get the basic details for all available transform lists (Name, Id, (Max) Version- but not Metadata or JSON transforms)

            try
            {
                // Get the basic details for all available transform lists (Name, Id, (Max) Version- but not Metadata or JSON transforms)
                GetFieldTransformListsDefaultResponse result = apiInstance.GetFieldTransformLists(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetFieldTransformLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFieldTransformListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the basic details for all available transform lists (Name, Id, (Max) Version- but not Metadata or JSON transforms)
    ApiResponse<GetFieldTransformListsDefaultResponse> response = apiInstance.GetFieldTransformListsWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetFieldTransformListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | Get the basic details for all available transform lists (Name, Id, (Max) Version- but not Metadata or JSON transforms) |  |

### Return type

[**GetFieldTransformListsDefaultResponse**](GetFieldTransformListsDefaultResponse.md)

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

<a id="getprocessstatus"></a>
# **GetProcessStatus**
> GetProcessStatusDefaultResponse GetProcessStatus (GetProcessStatusRequest getProcessStatusRequest)

Gets the status of a process which was queued.  Note that once the process is finished, you may only get the status once and each call thereafter will return NotFound.

Gets the status of a process which was queued.  Note that once the process is finished, you may only get the status once and each call thereafter will return NotFound.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetProcessStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getProcessStatusRequest = new GetProcessStatusRequest(); // GetProcessStatusRequest | Gets the status of a process which was queued.  Note that once the process is finished, you may only get the status once and each call thereafter will return NotFound.

            try
            {
                // Gets the status of a process which was queued.  Note that once the process is finished, you may only get the status once and each call thereafter will return NotFound.
                GetProcessStatusDefaultResponse result = apiInstance.GetProcessStatus(getProcessStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetProcessStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProcessStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the status of a process which was queued.  Note that once the process is finished, you may only get the status once and each call thereafter will return NotFound.
    ApiResponse<GetProcessStatusDefaultResponse> response = apiInstance.GetProcessStatusWithHttpInfo(getProcessStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetProcessStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getProcessStatusRequest** | [**GetProcessStatusRequest**](GetProcessStatusRequest.md) | Gets the status of a process which was queued.  Note that once the process is finished, you may only get the status once and each call thereafter will return NotFound. |  |

### Return type

[**GetProcessStatusDefaultResponse**](GetProcessStatusDefaultResponse.md)

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

<a id="gettransforms"></a>
# **GetTransforms**
> GetFieldTransformListsDefaultResponse GetTransforms (GetTransformsRequest getTransformsRequest)

Get the basic details for all available transforms (Name, Id, (Max) Version, Type) and which versions have actually been published

Get the basic details for all available transforms (Name, Id, (Max) Version, Type) and which versions have actually been published

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetTransformsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var getTransformsRequest = new GetTransformsRequest(); // GetTransformsRequest | Get the basic details for all available transforms (Name, Id, (Max) Version, Type) and which versions have actually been published

            try
            {
                // Get the basic details for all available transforms (Name, Id, (Max) Version, Type) and which versions have actually been published
                GetFieldTransformListsDefaultResponse result = apiInstance.GetTransforms(getTransformsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.GetTransforms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransformsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the basic details for all available transforms (Name, Id, (Max) Version, Type) and which versions have actually been published
    ApiResponse<GetFieldTransformListsDefaultResponse> response = apiInstance.GetTransformsWithHttpInfo(getTransformsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.GetTransformsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getTransformsRequest** | [**GetTransformsRequest**](GetTransformsRequest.md) | Get the basic details for all available transforms (Name, Id, (Max) Version, Type) and which versions have actually been published |  |

### Return type

[**GetFieldTransformListsDefaultResponse**](GetFieldTransformListsDefaultResponse.md)

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

<a id="markdatasourceaspendingdisable"></a>
# **MarkDatasourceAsPendingDisable**
> AUTHChangePasswordDefaultResponse MarkDatasourceAsPendingDisable (MarkDatasourceAsPendingDisableRequest markDatasourceAsPendingDisableRequest)

Mark a data source as pending disable. This will cause any active SEV threads to exit upon their next iteration, which can take a while.              Clients should then call @see(AreDatasourceJobsComplete) to check that the datasource is idle before continuing to perform the actual disable, and can call @see(DisableDatasource)

Mark a data source as pending disable. This will cause any active SEV threads to exit upon their next iteration, which can take a while.              Clients should then call @see(AreDatasourceJobsComplete) to check that the datasource is idle before continuing to perform the actual disable, and can call @see(DisableDatasource)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class MarkDatasourceAsPendingDisableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var markDatasourceAsPendingDisableRequest = new MarkDatasourceAsPendingDisableRequest(); // MarkDatasourceAsPendingDisableRequest | Mark a data source as pending disable. This will cause any active SEV threads to exit upon their next iteration, which can take a while.              Clients should then call @see(AreDatasourceJobsComplete) to check that the datasource is idle before continuing to perform the actual disable, and can call @see(DisableDatasource)

            try
            {
                // Mark a data source as pending disable. This will cause any active SEV threads to exit upon their next iteration, which can take a while.              Clients should then call @see(AreDatasourceJobsComplete) to check that the datasource is idle before continuing to perform the actual disable, and can call @see(DisableDatasource)
                AUTHChangePasswordDefaultResponse result = apiInstance.MarkDatasourceAsPendingDisable(markDatasourceAsPendingDisableRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.MarkDatasourceAsPendingDisable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkDatasourceAsPendingDisableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark a data source as pending disable. This will cause any active SEV threads to exit upon their next iteration, which can take a while.              Clients should then call @see(AreDatasourceJobsComplete) to check that the datasource is idle before continuing to perform the actual disable, and can call @see(DisableDatasource)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.MarkDatasourceAsPendingDisableWithHttpInfo(markDatasourceAsPendingDisableRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.MarkDatasourceAsPendingDisableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **markDatasourceAsPendingDisableRequest** | [**MarkDatasourceAsPendingDisableRequest**](MarkDatasourceAsPendingDisableRequest.md) | Mark a data source as pending disable. This will cause any active SEV threads to exit upon their next iteration, which can take a while.              Clients should then call @see(AreDatasourceJobsComplete) to check that the datasource is idle before continuing to perform the actual disable, and can call @see(DisableDatasource) |  |

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

<a id="pausedatasourcecampaigns"></a>
# **PauseDatasourceCampaigns**
> CreateClientDefaultResponse PauseDatasourceCampaigns (PauseDatasourceCampaignsRequest pauseDatasourceCampaignsRequest)

Pause the campaigns in this datasource. This will request all the campaigns that use this datasource to be paused, which can take a while.              Clients should then call @see(AreDatasourceCampaignsPaused) to check that the datasource is idle before continuing, and can call @see(ResumeDatasourceCampaigns)

Pause the campaigns in this datasource. This will request all the campaigns that use this datasource to be paused, which can take a while.              Clients should then call @see(AreDatasourceCampaignsPaused) to check that the datasource is idle before continuing, and can call @see(ResumeDatasourceCampaigns)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class PauseDatasourceCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var pauseDatasourceCampaignsRequest = new PauseDatasourceCampaignsRequest(); // PauseDatasourceCampaignsRequest | Pause the campaigns in this datasource. This will request all the campaigns that use this datasource to be paused, which can take a while.              Clients should then call @see(AreDatasourceCampaignsPaused) to check that the datasource is idle before continuing, and can call @see(ResumeDatasourceCampaigns)

            try
            {
                // Pause the campaigns in this datasource. This will request all the campaigns that use this datasource to be paused, which can take a while.              Clients should then call @see(AreDatasourceCampaignsPaused) to check that the datasource is idle before continuing, and can call @see(ResumeDatasourceCampaigns)
                CreateClientDefaultResponse result = apiInstance.PauseDatasourceCampaigns(pauseDatasourceCampaignsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.PauseDatasourceCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PauseDatasourceCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pause the campaigns in this datasource. This will request all the campaigns that use this datasource to be paused, which can take a while.              Clients should then call @see(AreDatasourceCampaignsPaused) to check that the datasource is idle before continuing, and can call @see(ResumeDatasourceCampaigns)
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.PauseDatasourceCampaignsWithHttpInfo(pauseDatasourceCampaignsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.PauseDatasourceCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pauseDatasourceCampaignsRequest** | [**PauseDatasourceCampaignsRequest**](PauseDatasourceCampaignsRequest.md) | Pause the campaigns in this datasource. This will request all the campaigns that use this datasource to be paused, which can take a while.              Clients should then call @see(AreDatasourceCampaignsPaused) to check that the datasource is idle before continuing, and can call @see(ResumeDatasourceCampaigns) |  |

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

<a id="refreshdatasource"></a>
# **RefreshDatasource**
> CreateClientDefaultResponse RefreshDatasource (RefreshDatasourceRequest refreshDatasourceRequest)

Requests an immediate refresh of an engine datasource.  Call @see(GetProcessStatus) to determine when the refresh has finished or check the LastRefresh date on the datasource.

Requests an immediate refresh of an engine datasource.  Call @see(GetProcessStatus) to determine when the refresh has finished or check the LastRefresh date on the datasource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class RefreshDatasourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var refreshDatasourceRequest = new RefreshDatasourceRequest(); // RefreshDatasourceRequest | Requests an immediate refresh of an engine datasource.  Call @see(GetProcessStatus) to determine when the refresh has finished or check the LastRefresh date on the datasource.

            try
            {
                // Requests an immediate refresh of an engine datasource.  Call @see(GetProcessStatus) to determine when the refresh has finished or check the LastRefresh date on the datasource.
                CreateClientDefaultResponse result = apiInstance.RefreshDatasource(refreshDatasourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.RefreshDatasource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefreshDatasourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests an immediate refresh of an engine datasource.  Call @see(GetProcessStatus) to determine when the refresh has finished or check the LastRefresh date on the datasource.
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.RefreshDatasourceWithHttpInfo(refreshDatasourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.RefreshDatasourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshDatasourceRequest** | [**RefreshDatasourceRequest**](RefreshDatasourceRequest.md) | Requests an immediate refresh of an engine datasource.  Call @see(GetProcessStatus) to determine when the refresh has finished or check the LastRefresh date on the datasource. |  |

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

<a id="resumedatasourcecampaigns"></a>
# **ResumeDatasourceCampaigns**
> AUTHChangePasswordDefaultResponse ResumeDatasourceCampaigns (ResumeDatasourceCampaignsRequest resumeDatasourceCampaignsRequest)

Resume the campaigns in this datasource. This is the opposite of @see(PauseDatasourceCampaigns), and only campaigns that were paused by that method will be resumed. Campaigns that             were paused manually will not be resumed.

Resume the campaigns in this datasource. This is the opposite of @see(PauseDatasourceCampaigns), and only campaigns that were paused by that method will be resumed. Campaigns that             were paused manually will not be resumed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class ResumeDatasourceCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var resumeDatasourceCampaignsRequest = new ResumeDatasourceCampaignsRequest(); // ResumeDatasourceCampaignsRequest | Resume the campaigns in this datasource. This is the opposite of @see(PauseDatasourceCampaigns), and only campaigns that were paused by that method will be resumed. Campaigns that             were paused manually will not be resumed.

            try
            {
                // Resume the campaigns in this datasource. This is the opposite of @see(PauseDatasourceCampaigns), and only campaigns that were paused by that method will be resumed. Campaigns that             were paused manually will not be resumed.
                AUTHChangePasswordDefaultResponse result = apiInstance.ResumeDatasourceCampaigns(resumeDatasourceCampaignsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.ResumeDatasourceCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResumeDatasourceCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resume the campaigns in this datasource. This is the opposite of @see(PauseDatasourceCampaigns), and only campaigns that were paused by that method will be resumed. Campaigns that             were paused manually will not be resumed.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.ResumeDatasourceCampaignsWithHttpInfo(resumeDatasourceCampaignsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.ResumeDatasourceCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resumeDatasourceCampaignsRequest** | [**ResumeDatasourceCampaignsRequest**](ResumeDatasourceCampaignsRequest.md) | Resume the campaigns in this datasource. This is the opposite of @see(PauseDatasourceCampaigns), and only campaigns that were paused by that method will be resumed. Campaigns that             were paused manually will not be resumed. |  |

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

<a id="savedecodelist"></a>
# **SaveDecodeList**
> GetDecodeListDefaultResponse SaveDecodeList (SaveDecodeListRequest saveDecodeListRequest)

Save a list of decodes

Save a list of decodes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class SaveDecodeListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var saveDecodeListRequest = new SaveDecodeListRequest(); // SaveDecodeListRequest | Save a list of decodes

            try
            {
                // Save a list of decodes
                GetDecodeListDefaultResponse result = apiInstance.SaveDecodeList(saveDecodeListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.SaveDecodeList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveDecodeListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save a list of decodes
    ApiResponse<GetDecodeListDefaultResponse> response = apiInstance.SaveDecodeListWithHttpInfo(saveDecodeListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.SaveDecodeListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveDecodeListRequest** | [**SaveDecodeListRequest**](SaveDecodeListRequest.md) | Save a list of decodes |  |

### Return type

[**GetDecodeListDefaultResponse**](GetDecodeListDefaultResponse.md)

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

<a id="savefieldtransformlist"></a>
# **SaveFieldTransformList**
> GetFieldTransformListDefaultResponse SaveFieldTransformList (SaveFieldTransformListRequest saveFieldTransformListRequest)

Save a list of field transforms for use in transforming discrete values

Save a list of field transforms for use in transforming discrete values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class SaveFieldTransformListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var saveFieldTransformListRequest = new SaveFieldTransformListRequest(); // SaveFieldTransformListRequest | Save a list of field transforms for use in transforming discrete values

            try
            {
                // Save a list of field transforms for use in transforming discrete values
                GetFieldTransformListDefaultResponse result = apiInstance.SaveFieldTransformList(saveFieldTransformListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.SaveFieldTransformList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveFieldTransformListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save a list of field transforms for use in transforming discrete values
    ApiResponse<GetFieldTransformListDefaultResponse> response = apiInstance.SaveFieldTransformListWithHttpInfo(saveFieldTransformListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.SaveFieldTransformListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveFieldTransformListRequest** | [**SaveFieldTransformListRequest**](SaveFieldTransformListRequest.md) | Save a list of field transforms for use in transforming discrete values |  |

### Return type

[**GetFieldTransformListDefaultResponse**](GetFieldTransformListDefaultResponse.md)

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

<a id="updatedatasourcemapping"></a>
# **UpdateDataSourceMapping**
> AUTHChangePasswordDefaultResponse UpdateDataSourceMapping (CreateDataSourceMappingRequest createDataSourceMappingRequest)

Updates a @see(DatasourceUserMapping) to map it to another engine user name.

Updates a @see(DatasourceUserMapping) to map it to another engine user name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateDataSourceMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var createDataSourceMappingRequest = new CreateDataSourceMappingRequest(); // CreateDataSourceMappingRequest | Updates a @see(DatasourceUserMapping) to map it to another engine user name.

            try
            {
                // Updates a @see(DatasourceUserMapping) to map it to another engine user name.
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateDataSourceMapping(createDataSourceMappingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.UpdateDataSourceMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataSourceMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a @see(DatasourceUserMapping) to map it to another engine user name.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateDataSourceMappingWithHttpInfo(createDataSourceMappingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.UpdateDataSourceMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDataSourceMappingRequest** | [**CreateDataSourceMappingRequest**](CreateDataSourceMappingRequest.md) | Updates a @see(DatasourceUserMapping) to map it to another engine user name. |  |

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

<a id="updatedatasource"></a>
# **UpdateDatasource**
> AUTHChangePasswordDefaultResponse UpdateDatasource (UpdateDatasourceRequest updateDatasourceRequest)

Updates an @see(ALDataSource) with the data which is provided.  Please note that the only properties which are relevant are IsEnabled, IsVisible, Name, LastRefresh and attributes.

Updates an @see(ALDataSource) with the data which is provided.  Please note that the only properties which are relevant are IsEnabled, IsVisible, Name, LastRefresh and attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateDatasourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new DatasourcesApi(config);
            var updateDatasourceRequest = new UpdateDatasourceRequest(); // UpdateDatasourceRequest | Updates an @see(ALDataSource) with the data which is provided.  Please note that the only properties which are relevant are IsEnabled, IsVisible, Name, LastRefresh and attributes.

            try
            {
                // Updates an @see(ALDataSource) with the data which is provided.  Please note that the only properties which are relevant are IsEnabled, IsVisible, Name, LastRefresh and attributes.
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateDatasource(updateDatasourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasourcesApi.UpdateDatasource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDatasourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an @see(ALDataSource) with the data which is provided.  Please note that the only properties which are relevant are IsEnabled, IsVisible, Name, LastRefresh and attributes.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateDatasourceWithHttpInfo(updateDatasourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasourcesApi.UpdateDatasourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateDatasourceRequest** | [**UpdateDatasourceRequest**](UpdateDatasourceRequest.md) | Updates an @see(ALDataSource) with the data which is provided.  Please note that the only properties which are relevant are IsEnabled, IsVisible, Name, LastRefresh and attributes. |  |

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

