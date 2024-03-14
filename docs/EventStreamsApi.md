# Alterian.JA.Api.EventStreamsApi

All URIs are relative to *http://localhost/services/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateChannel**](EventStreamsApi.md#createchannel) | **POST** /CreateChannel | Create a channel colour mapping |
| [**CreateEventStream**](EventStreamsApi.md#createeventstream) | **POST** /CreateEventStream | Creates an event stream, including a datasource and a DDE queue |
| [**CreateEventStreamGroup**](EventStreamsApi.md#createeventstreamgroup) | **POST** /CreateEventStreamGroup | Creates an event stream group, including a datasource and a DDE queue for each target (dev/test/prod) |
| [**CreateIdealisedJourney**](EventStreamsApi.md#createidealisedjourney) | **POST** /CreateIdealisedJourney | Create an Idealised Journey |
| [**CreateSankeyFavourite**](EventStreamsApi.md#createsankeyfavourite) | **POST** /CreateSankeyFavourite | Create a Sankey Favourite |
| [**CreateVisualisationFavourite**](EventStreamsApi.md#createvisualisationfavourite) | **POST** /CreateVisualisationFavourite | Create a Visualisation Favourite |
| [**DeleteChannel**](EventStreamsApi.md#deletechannel) | **POST** /DeleteChannel | Removed a channel and its associated colour from the channel list. |
| [**DeleteEventStream**](EventStreamsApi.md#deleteeventstream) | **POST** /DeleteEventStream | Removes an event stream from the system, optionally purging and deleting the corresponding queue in DDE.  Also can delete the underlying data store if the number of rows in the data store is less than the number provided |
| [**DeleteEventStreamCustomerColumns**](EventStreamsApi.md#deleteeventstreamcustomercolumns) | **POST** /DeleteEventStreamCustomerColumns | Mark for deletion the specified customer attribute columns for an @see(EventStream).             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns. |
| [**DeleteEventStreamCustomerColumnsFromGroup**](EventStreamsApi.md#deleteeventstreamcustomercolumnsfromgroup) | **POST** /DeleteEventStreamCustomerColumnsFromGroup | Mark for deletion the specified customer attribute columns for all @see(EventStream)s in a group.             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns. |
| [**DeleteEventStreamGroup**](EventStreamsApi.md#deleteeventstreamgroup) | **POST** /DeleteEventStreamGroup | Removes a group of event streams from the system, optionally purging and deleting the corresponding queues in DDE. |
| [**DeleteIdealisedJourney**](EventStreamsApi.md#deleteidealisedjourney) | **POST** /DeleteIdealisedJourney | Delete Idealised Journey&#39;s |
| [**DeleteSankeyFavourites**](EventStreamsApi.md#deletesankeyfavourites) | **POST** /DeleteSankeyFavourites | Delete a sankey favourite |
| [**DeleteVisualisationFavourites**](EventStreamsApi.md#deletevisualisationfavourites) | **POST** /DeleteVisualisationFavourites | Delete Visualisation favourite(s) |
| [**ExportEventStreamInteraction**](EventStreamsApi.md#exporteventstreaminteraction) | **POST** /ExportEventStreamInteraction | Exports the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \&quot;other\&quot; events pass all displayed events and set &#39;IncludeMatchedEvents&#39; to False. |
| [**GetChannels**](EventStreamsApi.md#getchannels) | **POST** /GetChannels | Return back a list of channels and their associated colours |
| [**GetEventRecords**](EventStreamsApi.md#geteventrecords) | **POST** /GetEventRecords | Obtain the event records from an event stream table that match the specified key |
| [**GetEventStream**](EventStreamsApi.md#geteventstream) | **POST** /GetEventStream | Return back the full details of an @see(EventStream).  Ids are available from @see(GetEventStreams) |
| [**GetEventStreamAggregates**](EventStreamsApi.md#geteventstreamaggregates) | **POST** /GetEventStreamAggregates | Get aggregate stats for an Event Stream.              Currently only supported for JD snapshots (simply because traditional sankey snapshots won&#39;t have the financial columns yet) |
| [**GetEventStreamChannels**](EventStreamsApi.md#geteventstreamchannels) | **POST** /GetEventStreamChannels | Requests a list of the channels which the event stream has received.  Use this list to create channel colour mappings @see(CreateChannel).  Use @see(GetEventStreams) for a list of the available @see(EventStream)s |
| [**GetEventStreamDecodeMappings**](EventStreamsApi.md#geteventstreamdecodemappings) | **POST** /GetEventStreamDecodeMappings | Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a cursored list of the labels taking account any decodes that may have been specified             Note that this API does not use any published decode information, if a decode list is to be applied then it should be specified explicitly |
| [**GetEventStreamDecodeTargetDiscretes**](EventStreamsApi.md#geteventstreamdecodetargetdiscretes) | **POST** /GetEventStreamDecodeTargetDiscretes | Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a list of all the currently configured decode targets along with any counts             If a target does not appear in the sampled data it will be returned with a count of zero so it can be optionally filtered out of any picklist |
| [**GetEventStreamDiscreteValues**](EventStreamsApi.md#geteventstreamdiscretevalues) | **POST** /GetEventStreamDiscreteValues | Obtain discrete values from an event stream table             Supports use of a snapshot table which should reduce the chances of us blowing the Engine discrete limit.             The first parameters constitute the sankey filters and thereby the starting set for discretes             It will also allow us to filter the values by the specified discrete filters             If the sankey filters return no data then an execption is thrown stating that \&quot;No data is available for the specified filters\&quot; as this is probably not what the user wants             If the discretes filter suppresses out all data in the sankey then no exception is raised but zero totals are returned |
| [**GetEventStreamModels**](EventStreamsApi.md#geteventstreammodels) | **POST** /GetEventStreamModels | Retrieve available models |
| [**GetEventStreams**](EventStreamsApi.md#geteventstreams) | **POST** /GetEventStreams | Returns back a list of event streams which exist in the system |
| [**GetFieldTransformationDiscreteValues**](EventStreamsApi.md#getfieldtransformationdiscretevalues) | **POST** /GetFieldTransformationDiscreteValues | Apply a list of transforms to the discrete values of a column and return the new set of values and their frequencies             If JSONTransforms is not supplied then the results will simply be the discrete values present in the source column after any sample has been applied |
| [**GetFieldTransformationMappings**](EventStreamsApi.md#getfieldtransformationmappings) | **POST** /GetFieldTransformationMappings | Apply a list of transforms and return information about the transformed value and frequency for each item in the starting set of values             If JSONCompareTransforms is specified then the starting set of values is the result of first applying these to these to the specified column             If JSONCompareTransforms is not specified then the starting set of values is the actual discrete values present in the column |
| [**GetIdealisedJourneys**](EventStreamsApi.md#getidealisedjourneys) | **POST** /GetIdealisedJourneys | Retrieve a list of Idealised Journeys |
| [**GetSankeyFavourites**](EventStreamsApi.md#getsankeyfavourites) | **POST** /GetSankeyFavourites | Retrieve a list of Sankey Favourites |
| [**GetVisualisationFavourites**](EventStreamsApi.md#getvisualisationfavourites) | **POST** /GetVisualisationFavourites | Retrieve a list of Visualisation Favourites |
| [**QueryEventStream**](EventStreamsApi.md#queryeventstream) | **POST** /QueryEventStream | Queries the domain of selected event records that is represented by the date and event type filters, returning the list of events and graph of transition streams along with frequency counts.             Transitions will specify start and end points using indices into the list of events, along with some special values.             The &#39;Drop off&#39; points where a stream ends will be assigned an index of -1.             Any transition to an event that does not fall into the TopN specification will be assigned to an &#39;other events&#39; category with an index of -2.             Right aligned streams will be left-padded up to the MaxLength specification using a &#39;no event&#39; category with an index of -3.             If timeout events are required then the start of the sequence leading up to a timeout will be flagged with an index of -4 and the end with an index of -5. |
| [**QueryEventStreamCount**](EventStreamsApi.md#queryeventstreamcount) | **POST** /QueryEventStreamCount | Take the domain of selected event records that is represented by the date filters, and count streams matching the agreed patterns represented by the CountType parameter |
| [**QueryEventStreamInteraction**](EventStreamsApi.md#queryeventstreaminteraction) | **POST** /QueryEventStreamInteraction | Queries the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \&quot;other\&quot; events pass all displayed events and set &#39;IncludeMatchedEvents&#39; to False. |
| [**QueryEventStreamTransition**](EventStreamsApi.md#queryeventstreamtransition) | **POST** /QueryEventStreamTransition | Queries the domain from a particular node to another node to return a sample of the CXID (VisitorId) values.             To get the results for \&quot;other\&quot; events pass all displayed events and set &#39;IncludeMatchedEventsFrom&#39; / IncludeMatchedEventsTo to False. |
| [**RunSequencePredictor**](EventStreamsApi.md#runsequencepredictor) | **POST** /RunSequencePredictor | Train and employ sequence prediction models for an event stream |
| [**UpdateChannel**](EventStreamsApi.md#updatechannel) | **POST** /UpdateChannel | Updates a channel, allowing you to change the name and colour |
| [**UpdateEventStreamFieldTransformLists**](EventStreamsApi.md#updateeventstreamfieldtransformlists) | **POST** /UpdateEventStreamFieldTransformLists | Publishes the specified transforms to the corresponding event stream columns             Any existing list for a column that matches on Transform Type and Alias will be replaced |
| [**UpdateIdealisedJourney**](EventStreamsApi.md#updateidealisedjourney) | **POST** /UpdateIdealisedJourney | Update an Idealised Journey |
| [**UpdateSankeyFavourite**](EventStreamsApi.md#updatesankeyfavourite) | **POST** /UpdateSankeyFavourite | Update a SankeyFavourite |
| [**UpdateVisualisationFavourite**](EventStreamsApi.md#updatevisualisationfavourite) | **POST** /UpdateVisualisationFavourite | Update a Visualisation Favourite |
| [**UpsertEventStreamCustomerColumns**](EventStreamsApi.md#upserteventstreamcustomercolumns) | **POST** /UpsertEventStreamCustomerColumns | Add or update customer attribute columns for an @see(EventStream).             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements. |
| [**UpsertEventStreamCustomerColumnsToGroup**](EventStreamsApi.md#upserteventstreamcustomercolumnstogroup) | **POST** /UpsertEventStreamCustomerColumnsToGroup | Add or update customer attribute columns to the @see(EventStream)s in a group.             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.             There is some latency (up to 5 mins) between a column being created and the queue service starting to read the data unless the queue service is restarted |

<a id="createchannel"></a>
# **CreateChannel**
> CreateClientDefaultResponse CreateChannel (CreateChannelRequest createChannelRequest)

Create a channel colour mapping

Create a channel colour mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var createChannelRequest = new CreateChannelRequest(); // CreateChannelRequest | Create a channel colour mapping

            try
            {
                // Create a channel colour mapping
                CreateClientDefaultResponse result = apiInstance.CreateChannel(createChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.CreateChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a channel colour mapping
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateChannelWithHttpInfo(createChannelRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.CreateChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createChannelRequest** | [**CreateChannelRequest**](CreateChannelRequest.md) | Create a channel colour mapping |  |

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

<a id="createeventstream"></a>
# **CreateEventStream**
> CreateClientDefaultResponse CreateEventStream (CreateEventStreamRequest createEventStreamRequest)

Creates an event stream, including a datasource and a DDE queue

Creates an event stream, including a datasource and a DDE queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateEventStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var createEventStreamRequest = new CreateEventStreamRequest(); // CreateEventStreamRequest | Creates an event stream, including a datasource and a DDE queue

            try
            {
                // Creates an event stream, including a datasource and a DDE queue
                CreateClientDefaultResponse result = apiInstance.CreateEventStream(createEventStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.CreateEventStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEventStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an event stream, including a datasource and a DDE queue
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateEventStreamWithHttpInfo(createEventStreamRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.CreateEventStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEventStreamRequest** | [**CreateEventStreamRequest**](CreateEventStreamRequest.md) | Creates an event stream, including a datasource and a DDE queue |  |

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

<a id="createeventstreamgroup"></a>
# **CreateEventStreamGroup**
> CreateClientDefaultResponse CreateEventStreamGroup (CreateEventStreamGroupRequest createEventStreamGroupRequest)

Creates an event stream group, including a datasource and a DDE queue for each target (dev/test/prod)

Creates an event stream group, including a datasource and a DDE queue for each target (dev/test/prod)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateEventStreamGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var createEventStreamGroupRequest = new CreateEventStreamGroupRequest(); // CreateEventStreamGroupRequest | Creates an event stream group, including a datasource and a DDE queue for each target (dev/test/prod)

            try
            {
                // Creates an event stream group, including a datasource and a DDE queue for each target (dev/test/prod)
                CreateClientDefaultResponse result = apiInstance.CreateEventStreamGroup(createEventStreamGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.CreateEventStreamGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEventStreamGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an event stream group, including a datasource and a DDE queue for each target (dev/test/prod)
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateEventStreamGroupWithHttpInfo(createEventStreamGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.CreateEventStreamGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEventStreamGroupRequest** | [**CreateEventStreamGroupRequest**](CreateEventStreamGroupRequest.md) | Creates an event stream group, including a datasource and a DDE queue for each target (dev/test/prod) |  |

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

<a id="createidealisedjourney"></a>
# **CreateIdealisedJourney**
> CreateClientDefaultResponse CreateIdealisedJourney (CreateIdealisedJourneyRequest createIdealisedJourneyRequest)

Create an Idealised Journey

Create an Idealised Journey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateIdealisedJourneyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var createIdealisedJourneyRequest = new CreateIdealisedJourneyRequest(); // CreateIdealisedJourneyRequest | Create an Idealised Journey

            try
            {
                // Create an Idealised Journey
                CreateClientDefaultResponse result = apiInstance.CreateIdealisedJourney(createIdealisedJourneyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.CreateIdealisedJourney: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateIdealisedJourneyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an Idealised Journey
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateIdealisedJourneyWithHttpInfo(createIdealisedJourneyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.CreateIdealisedJourneyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createIdealisedJourneyRequest** | [**CreateIdealisedJourneyRequest**](CreateIdealisedJourneyRequest.md) | Create an Idealised Journey |  |

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

<a id="createsankeyfavourite"></a>
# **CreateSankeyFavourite**
> CreateClientDefaultResponse CreateSankeyFavourite (CreateSankeyFavouriteRequest createSankeyFavouriteRequest)

Create a Sankey Favourite

Create a Sankey Favourite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateSankeyFavouriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var createSankeyFavouriteRequest = new CreateSankeyFavouriteRequest(); // CreateSankeyFavouriteRequest | Create a Sankey Favourite

            try
            {
                // Create a Sankey Favourite
                CreateClientDefaultResponse result = apiInstance.CreateSankeyFavourite(createSankeyFavouriteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.CreateSankeyFavourite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSankeyFavouriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Sankey Favourite
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateSankeyFavouriteWithHttpInfo(createSankeyFavouriteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.CreateSankeyFavouriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSankeyFavouriteRequest** | [**CreateSankeyFavouriteRequest**](CreateSankeyFavouriteRequest.md) | Create a Sankey Favourite |  |

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

<a id="createvisualisationfavourite"></a>
# **CreateVisualisationFavourite**
> CreateClientDefaultResponse CreateVisualisationFavourite (CreateVisualisationFavouriteRequest createVisualisationFavouriteRequest)

Create a Visualisation Favourite

Create a Visualisation Favourite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class CreateVisualisationFavouriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var createVisualisationFavouriteRequest = new CreateVisualisationFavouriteRequest(); // CreateVisualisationFavouriteRequest | Create a Visualisation Favourite

            try
            {
                // Create a Visualisation Favourite
                CreateClientDefaultResponse result = apiInstance.CreateVisualisationFavourite(createVisualisationFavouriteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.CreateVisualisationFavourite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateVisualisationFavouriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Visualisation Favourite
    ApiResponse<CreateClientDefaultResponse> response = apiInstance.CreateVisualisationFavouriteWithHttpInfo(createVisualisationFavouriteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.CreateVisualisationFavouriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createVisualisationFavouriteRequest** | [**CreateVisualisationFavouriteRequest**](CreateVisualisationFavouriteRequest.md) | Create a Visualisation Favourite |  |

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

<a id="deletechannel"></a>
# **DeleteChannel**
> AUTHChangePasswordDefaultResponse DeleteChannel (DeleteChannelRequest deleteChannelRequest)

Removed a channel and its associated colour from the channel list.

Removed a channel and its associated colour from the channel list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var deleteChannelRequest = new DeleteChannelRequest(); // DeleteChannelRequest | Removed a channel and its associated colour from the channel list.

            try
            {
                // Removed a channel and its associated colour from the channel list.
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteChannel(deleteChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.DeleteChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removed a channel and its associated colour from the channel list.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteChannelWithHttpInfo(deleteChannelRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.DeleteChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteChannelRequest** | [**DeleteChannelRequest**](DeleteChannelRequest.md) | Removed a channel and its associated colour from the channel list. |  |

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

<a id="deleteeventstream"></a>
# **DeleteEventStream**
> AUTHChangePasswordDefaultResponse DeleteEventStream (DeleteEventStreamRequest deleteEventStreamRequest)

Removes an event stream from the system, optionally purging and deleting the corresponding queue in DDE.  Also can delete the underlying data store if the number of rows in the data store is less than the number provided

Removes an event stream from the system, optionally purging and deleting the corresponding queue in DDE.  Also can delete the underlying data store if the number of rows in the data store is less than the number provided

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteEventStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var deleteEventStreamRequest = new DeleteEventStreamRequest(); // DeleteEventStreamRequest | Removes an event stream from the system, optionally purging and deleting the corresponding queue in DDE.  Also can delete the underlying data store if the number of rows in the data store is less than the number provided

            try
            {
                // Removes an event stream from the system, optionally purging and deleting the corresponding queue in DDE.  Also can delete the underlying data store if the number of rows in the data store is less than the number provided
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteEventStream(deleteEventStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.DeleteEventStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEventStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes an event stream from the system, optionally purging and deleting the corresponding queue in DDE.  Also can delete the underlying data store if the number of rows in the data store is less than the number provided
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteEventStreamWithHttpInfo(deleteEventStreamRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.DeleteEventStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteEventStreamRequest** | [**DeleteEventStreamRequest**](DeleteEventStreamRequest.md) | Removes an event stream from the system, optionally purging and deleting the corresponding queue in DDE.  Also can delete the underlying data store if the number of rows in the data store is less than the number provided |  |

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

<a id="deleteeventstreamcustomercolumns"></a>
# **DeleteEventStreamCustomerColumns**
> AUTHChangePasswordDefaultResponse DeleteEventStreamCustomerColumns (DeleteEventStreamCustomerColumnsRequest deleteEventStreamCustomerColumnsRequest)

Mark for deletion the specified customer attribute columns for an @see(EventStream).             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.

Mark for deletion the specified customer attribute columns for an @see(EventStream).             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteEventStreamCustomerColumnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var deleteEventStreamCustomerColumnsRequest = new DeleteEventStreamCustomerColumnsRequest(); // DeleteEventStreamCustomerColumnsRequest | Mark for deletion the specified customer attribute columns for an @see(EventStream).             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.

            try
            {
                // Mark for deletion the specified customer attribute columns for an @see(EventStream).             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteEventStreamCustomerColumns(deleteEventStreamCustomerColumnsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.DeleteEventStreamCustomerColumns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEventStreamCustomerColumnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark for deletion the specified customer attribute columns for an @see(EventStream).             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteEventStreamCustomerColumnsWithHttpInfo(deleteEventStreamCustomerColumnsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.DeleteEventStreamCustomerColumnsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteEventStreamCustomerColumnsRequest** | [**DeleteEventStreamCustomerColumnsRequest**](DeleteEventStreamCustomerColumnsRequest.md) | Mark for deletion the specified customer attribute columns for an @see(EventStream).             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns. |  |

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

<a id="deleteeventstreamcustomercolumnsfromgroup"></a>
# **DeleteEventStreamCustomerColumnsFromGroup**
> AUTHChangePasswordDefaultResponse DeleteEventStreamCustomerColumnsFromGroup (DeleteEventStreamCustomerColumnsFromGroupRequest deleteEventStreamCustomerColumnsFromGroupRequest)

Mark for deletion the specified customer attribute columns for all @see(EventStream)s in a group.             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.

Mark for deletion the specified customer attribute columns for all @see(EventStream)s in a group.             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteEventStreamCustomerColumnsFromGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var deleteEventStreamCustomerColumnsFromGroupRequest = new DeleteEventStreamCustomerColumnsFromGroupRequest(); // DeleteEventStreamCustomerColumnsFromGroupRequest | Mark for deletion the specified customer attribute columns for all @see(EventStream)s in a group.             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.

            try
            {
                // Mark for deletion the specified customer attribute columns for all @see(EventStream)s in a group.             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteEventStreamCustomerColumnsFromGroup(deleteEventStreamCustomerColumnsFromGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.DeleteEventStreamCustomerColumnsFromGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEventStreamCustomerColumnsFromGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark for deletion the specified customer attribute columns for all @see(EventStream)s in a group.             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteEventStreamCustomerColumnsFromGroupWithHttpInfo(deleteEventStreamCustomerColumnsFromGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.DeleteEventStreamCustomerColumnsFromGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteEventStreamCustomerColumnsFromGroupRequest** | [**DeleteEventStreamCustomerColumnsFromGroupRequest**](DeleteEventStreamCustomerColumnsFromGroupRequest.md) | Mark for deletion the specified customer attribute columns for all @see(EventStream)s in a group.             NOTE THAT THE ASSOCIATED ENGINE COLUMN AND DDE CACHE COLUMN WILL BE DELETED AND ANY DATA LOST PERMANENTLY.             Deletion of the column from Engine and the DDE cache is not synchronous so attempts to recreate the column may fail initially and require a different name to be specified.             Once marked for deletion the columns no longer contribute to the cap imposed by the max number of allowed columns. |  |

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

<a id="deleteeventstreamgroup"></a>
# **DeleteEventStreamGroup**
> AUTHChangePasswordDefaultResponse DeleteEventStreamGroup (DeleteEventStreamGroupRequest deleteEventStreamGroupRequest)

Removes a group of event streams from the system, optionally purging and deleting the corresponding queues in DDE.

Removes a group of event streams from the system, optionally purging and deleting the corresponding queues in DDE.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteEventStreamGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var deleteEventStreamGroupRequest = new DeleteEventStreamGroupRequest(); // DeleteEventStreamGroupRequest | Removes a group of event streams from the system, optionally purging and deleting the corresponding queues in DDE.

            try
            {
                // Removes a group of event streams from the system, optionally purging and deleting the corresponding queues in DDE.
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteEventStreamGroup(deleteEventStreamGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.DeleteEventStreamGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEventStreamGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a group of event streams from the system, optionally purging and deleting the corresponding queues in DDE.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteEventStreamGroupWithHttpInfo(deleteEventStreamGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.DeleteEventStreamGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteEventStreamGroupRequest** | [**DeleteEventStreamGroupRequest**](DeleteEventStreamGroupRequest.md) | Removes a group of event streams from the system, optionally purging and deleting the corresponding queues in DDE. |  |

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

<a id="deleteidealisedjourney"></a>
# **DeleteIdealisedJourney**
> AUTHChangePasswordDefaultResponse DeleteIdealisedJourney (DeleteIdealisedJourneyRequest deleteIdealisedJourneyRequest)

Delete Idealised Journey's

Delete Idealised Journey's

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteIdealisedJourneyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var deleteIdealisedJourneyRequest = new DeleteIdealisedJourneyRequest(); // DeleteIdealisedJourneyRequest | Delete Idealised Journey's

            try
            {
                // Delete Idealised Journey's
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteIdealisedJourney(deleteIdealisedJourneyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.DeleteIdealisedJourney: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIdealisedJourneyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Idealised Journey's
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteIdealisedJourneyWithHttpInfo(deleteIdealisedJourneyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.DeleteIdealisedJourneyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteIdealisedJourneyRequest** | [**DeleteIdealisedJourneyRequest**](DeleteIdealisedJourneyRequest.md) | Delete Idealised Journey&#39;s |  |

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

<a id="deletesankeyfavourites"></a>
# **DeleteSankeyFavourites**
> AUTHChangePasswordDefaultResponse DeleteSankeyFavourites (DeleteSankeyFavouritesRequest deleteSankeyFavouritesRequest)

Delete a sankey favourite

Delete a sankey favourite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteSankeyFavouritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var deleteSankeyFavouritesRequest = new DeleteSankeyFavouritesRequest(); // DeleteSankeyFavouritesRequest | Delete a sankey favourite

            try
            {
                // Delete a sankey favourite
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteSankeyFavourites(deleteSankeyFavouritesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.DeleteSankeyFavourites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSankeyFavouritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a sankey favourite
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteSankeyFavouritesWithHttpInfo(deleteSankeyFavouritesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.DeleteSankeyFavouritesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteSankeyFavouritesRequest** | [**DeleteSankeyFavouritesRequest**](DeleteSankeyFavouritesRequest.md) | Delete a sankey favourite |  |

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

<a id="deletevisualisationfavourites"></a>
# **DeleteVisualisationFavourites**
> AUTHChangePasswordDefaultResponse DeleteVisualisationFavourites (DeleteVisualisationFavouritesRequest deleteVisualisationFavouritesRequest)

Delete Visualisation favourite(s)

Delete Visualisation favourite(s)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class DeleteVisualisationFavouritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var deleteVisualisationFavouritesRequest = new DeleteVisualisationFavouritesRequest(); // DeleteVisualisationFavouritesRequest | Delete Visualisation favourite(s)

            try
            {
                // Delete Visualisation favourite(s)
                AUTHChangePasswordDefaultResponse result = apiInstance.DeleteVisualisationFavourites(deleteVisualisationFavouritesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.DeleteVisualisationFavourites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVisualisationFavouritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Visualisation favourite(s)
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.DeleteVisualisationFavouritesWithHttpInfo(deleteVisualisationFavouritesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.DeleteVisualisationFavouritesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteVisualisationFavouritesRequest** | [**DeleteVisualisationFavouritesRequest**](DeleteVisualisationFavouritesRequest.md) | Delete Visualisation favourite(s) |  |

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

<a id="exporteventstreaminteraction"></a>
# **ExportEventStreamInteraction**
> System.IO.Stream ExportEventStreamInteraction (ExportEventStreamInteractionRequest exportEventStreamInteractionRequest)

Exports the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.

Exports the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class ExportEventStreamInteractionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var exportEventStreamInteractionRequest = new ExportEventStreamInteractionRequest(); // ExportEventStreamInteractionRequest | Exports the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.

            try
            {
                // Exports the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.
                System.IO.Stream result = apiInstance.ExportEventStreamInteraction(exportEventStreamInteractionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.ExportEventStreamInteraction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportEventStreamInteractionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Exports the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.
    ApiResponse<System.IO.Stream> response = apiInstance.ExportEventStreamInteractionWithHttpInfo(exportEventStreamInteractionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.ExportEventStreamInteractionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **exportEventStreamInteractionRequest** | [**ExportEventStreamInteractionRequest**](ExportEventStreamInteractionRequest.md) | Exports the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \&quot;other\&quot; events pass all displayed events and set &#39;IncludeMatchedEvents&#39; to False. |  |

### Return type

**System.IO.Stream**

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

<a id="getchannels"></a>
# **GetChannels**
> GetChannelsDefaultResponse GetChannels ()

Return back a list of channels and their associated colours

Return back a list of channels and their associated colours

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetChannelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);

            try
            {
                // Return back a list of channels and their associated colours
                GetChannelsDefaultResponse result = apiInstance.GetChannels();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetChannels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChannelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back a list of channels and their associated colours
    ApiResponse<GetChannelsDefaultResponse> response = apiInstance.GetChannelsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetChannelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetChannelsDefaultResponse**](GetChannelsDefaultResponse.md)

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

<a id="geteventrecords"></a>
# **GetEventRecords**
> GetEventRecordsDefaultResponse GetEventRecords (GetEventRecordsRequest getEventRecordsRequest)

Obtain the event records from an event stream table that match the specified key

Obtain the event records from an event stream table that match the specified key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getEventRecordsRequest = new GetEventRecordsRequest(); // GetEventRecordsRequest | Obtain the event records from an event stream table that match the specified key

            try
            {
                // Obtain the event records from an event stream table that match the specified key
                GetEventRecordsDefaultResponse result = apiInstance.GetEventRecords(getEventRecordsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Obtain the event records from an event stream table that match the specified key
    ApiResponse<GetEventRecordsDefaultResponse> response = apiInstance.GetEventRecordsWithHttpInfo(getEventRecordsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventRecordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventRecordsRequest** | [**GetEventRecordsRequest**](GetEventRecordsRequest.md) | Obtain the event records from an event stream table that match the specified key |  |

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

<a id="geteventstream"></a>
# **GetEventStream**
> GetEventStreamDefaultResponse GetEventStream (GetEventStreamRequest getEventStreamRequest)

Return back the full details of an @see(EventStream).  Ids are available from @see(GetEventStreams)

Return back the full details of an @see(EventStream).  Ids are available from @see(GetEventStreams)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getEventStreamRequest = new GetEventStreamRequest(); // GetEventStreamRequest | Return back the full details of an @see(EventStream).  Ids are available from @see(GetEventStreams)

            try
            {
                // Return back the full details of an @see(EventStream).  Ids are available from @see(GetEventStreams)
                GetEventStreamDefaultResponse result = apiInstance.GetEventStream(getEventStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back the full details of an @see(EventStream).  Ids are available from @see(GetEventStreams)
    ApiResponse<GetEventStreamDefaultResponse> response = apiInstance.GetEventStreamWithHttpInfo(getEventStreamRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventStreamRequest** | [**GetEventStreamRequest**](GetEventStreamRequest.md) | Return back the full details of an @see(EventStream).  Ids are available from @see(GetEventStreams) |  |

### Return type

[**GetEventStreamDefaultResponse**](GetEventStreamDefaultResponse.md)

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

<a id="geteventstreamaggregates"></a>
# **GetEventStreamAggregates**
> GetEventRecordsDefaultResponse GetEventStreamAggregates (GetEventStreamAggregatesRequest getEventStreamAggregatesRequest)

Get aggregate stats for an Event Stream.              Currently only supported for JD snapshots (simply because traditional sankey snapshots won't have the financial columns yet)

Get aggregate stats for an Event Stream.              Currently only supported for JD snapshots (simply because traditional sankey snapshots won't have the financial columns yet)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamAggregatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getEventStreamAggregatesRequest = new GetEventStreamAggregatesRequest(); // GetEventStreamAggregatesRequest | Get aggregate stats for an Event Stream.              Currently only supported for JD snapshots (simply because traditional sankey snapshots won't have the financial columns yet)

            try
            {
                // Get aggregate stats for an Event Stream.              Currently only supported for JD snapshots (simply because traditional sankey snapshots won't have the financial columns yet)
                GetEventRecordsDefaultResponse result = apiInstance.GetEventStreamAggregates(getEventStreamAggregatesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventStreamAggregates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamAggregatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get aggregate stats for an Event Stream.              Currently only supported for JD snapshots (simply because traditional sankey snapshots won't have the financial columns yet)
    ApiResponse<GetEventRecordsDefaultResponse> response = apiInstance.GetEventStreamAggregatesWithHttpInfo(getEventStreamAggregatesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventStreamAggregatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventStreamAggregatesRequest** | [**GetEventStreamAggregatesRequest**](GetEventStreamAggregatesRequest.md) | Get aggregate stats for an Event Stream.              Currently only supported for JD snapshots (simply because traditional sankey snapshots won&#39;t have the financial columns yet) |  |

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

<a id="geteventstreamchannels"></a>
# **GetEventStreamChannels**
> GetDataSourceUsersDefaultResponse GetEventStreamChannels (GetEventStreamChannelsRequest getEventStreamChannelsRequest)

Requests a list of the channels which the event stream has received.  Use this list to create channel colour mappings @see(CreateChannel).  Use @see(GetEventStreams) for a list of the available @see(EventStream)s

Requests a list of the channels which the event stream has received.  Use this list to create channel colour mappings @see(CreateChannel).  Use @see(GetEventStreams) for a list of the available @see(EventStream)s

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamChannelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getEventStreamChannelsRequest = new GetEventStreamChannelsRequest(); // GetEventStreamChannelsRequest | Requests a list of the channels which the event stream has received.  Use this list to create channel colour mappings @see(CreateChannel).  Use @see(GetEventStreams) for a list of the available @see(EventStream)s

            try
            {
                // Requests a list of the channels which the event stream has received.  Use this list to create channel colour mappings @see(CreateChannel).  Use @see(GetEventStreams) for a list of the available @see(EventStream)s
                GetDataSourceUsersDefaultResponse result = apiInstance.GetEventStreamChannels(getEventStreamChannelsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventStreamChannels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamChannelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests a list of the channels which the event stream has received.  Use this list to create channel colour mappings @see(CreateChannel).  Use @see(GetEventStreams) for a list of the available @see(EventStream)s
    ApiResponse<GetDataSourceUsersDefaultResponse> response = apiInstance.GetEventStreamChannelsWithHttpInfo(getEventStreamChannelsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventStreamChannelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventStreamChannelsRequest** | [**GetEventStreamChannelsRequest**](GetEventStreamChannelsRequest.md) | Requests a list of the channels which the event stream has received.  Use this list to create channel colour mappings @see(CreateChannel).  Use @see(GetEventStreams) for a list of the available @see(EventStream)s |  |

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

<a id="geteventstreamdecodemappings"></a>
# **GetEventStreamDecodeMappings**
> GetEventStreamDecodeMappingsDefaultResponse GetEventStreamDecodeMappings (GetEventStreamDecodeMappingsRequest getEventStreamDecodeMappingsRequest)

Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a cursored list of the labels taking account any decodes that may have been specified             Note that this API does not use any published decode information, if a decode list is to be applied then it should be specified explicitly

Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a cursored list of the labels taking account any decodes that may have been specified             Note that this API does not use any published decode information, if a decode list is to be applied then it should be specified explicitly

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamDecodeMappingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getEventStreamDecodeMappingsRequest = new GetEventStreamDecodeMappingsRequest(); // GetEventStreamDecodeMappingsRequest | Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a cursored list of the labels taking account any decodes that may have been specified             Note that this API does not use any published decode information, if a decode list is to be applied then it should be specified explicitly

            try
            {
                // Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a cursored list of the labels taking account any decodes that may have been specified             Note that this API does not use any published decode information, if a decode list is to be applied then it should be specified explicitly
                GetEventStreamDecodeMappingsDefaultResponse result = apiInstance.GetEventStreamDecodeMappings(getEventStreamDecodeMappingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventStreamDecodeMappings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamDecodeMappingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a cursored list of the labels taking account any decodes that may have been specified             Note that this API does not use any published decode information, if a decode list is to be applied then it should be specified explicitly
    ApiResponse<GetEventStreamDecodeMappingsDefaultResponse> response = apiInstance.GetEventStreamDecodeMappingsWithHttpInfo(getEventStreamDecodeMappingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventStreamDecodeMappingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventStreamDecodeMappingsRequest** | [**GetEventStreamDecodeMappingsRequest**](GetEventStreamDecodeMappingsRequest.md) | Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a cursored list of the labels taking account any decodes that may have been specified             Note that this API does not use any published decode information, if a decode list is to be applied then it should be specified explicitly |  |

### Return type

[**GetEventStreamDecodeMappingsDefaultResponse**](GetEventStreamDecodeMappingsDefaultResponse.md)

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

<a id="geteventstreamdecodetargetdiscretes"></a>
# **GetEventStreamDecodeTargetDiscretes**
> GetEventStreamDecodeTargetDiscretesDefaultResponse GetEventStreamDecodeTargetDiscretes (GetEventStreamDecodeTargetDiscretesRequest getEventStreamDecodeTargetDiscretesRequest)

Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a list of all the currently configured decode targets along with any counts             If a target does not appear in the sampled data it will be returned with a count of zero so it can be optionally filtered out of any picklist

Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a list of all the currently configured decode targets along with any counts             If a target does not appear in the sampled data it will be returned with a count of zero so it can be optionally filtered out of any picklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamDecodeTargetDiscretesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getEventStreamDecodeTargetDiscretesRequest = new GetEventStreamDecodeTargetDiscretesRequest(); // GetEventStreamDecodeTargetDiscretesRequest | Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a list of all the currently configured decode targets along with any counts             If a target does not appear in the sampled data it will be returned with a count of zero so it can be optionally filtered out of any picklist

            try
            {
                // Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a list of all the currently configured decode targets along with any counts             If a target does not appear in the sampled data it will be returned with a count of zero so it can be optionally filtered out of any picklist
                GetEventStreamDecodeTargetDiscretesDefaultResponse result = apiInstance.GetEventStreamDecodeTargetDiscretes(getEventStreamDecodeTargetDiscretesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventStreamDecodeTargetDiscretes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamDecodeTargetDiscretesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a list of all the currently configured decode targets along with any counts             If a target does not appear in the sampled data it will be returned with a count of zero so it can be optionally filtered out of any picklist
    ApiResponse<GetEventStreamDecodeTargetDiscretesDefaultResponse> response = apiInstance.GetEventStreamDecodeTargetDiscretesWithHttpInfo(getEventStreamDecodeTargetDiscretesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventStreamDecodeTargetDiscretesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventStreamDecodeTargetDiscretesRequest** | [**GetEventStreamDecodeTargetDiscretesRequest**](GetEventStreamDecodeTargetDiscretesRequest.md) | Given an event stream this API will take an event stream column, sample the data using the specified dates, apply any published transform and then return a list of all the currently configured decode targets along with any counts             If a target does not appear in the sampled data it will be returned with a count of zero so it can be optionally filtered out of any picklist |  |

### Return type

[**GetEventStreamDecodeTargetDiscretesDefaultResponse**](GetEventStreamDecodeTargetDiscretesDefaultResponse.md)

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

<a id="geteventstreamdiscretevalues"></a>
# **GetEventStreamDiscreteValues**
> GetEventStreamDiscreteValuesDefaultResponse GetEventStreamDiscreteValues (GetEventStreamDiscreteValuesRequest getEventStreamDiscreteValuesRequest)

Obtain discrete values from an event stream table             Supports use of a snapshot table which should reduce the chances of us blowing the Engine discrete limit.             The first parameters constitute the sankey filters and thereby the starting set for discretes             It will also allow us to filter the values by the specified discrete filters             If the sankey filters return no data then an execption is thrown stating that \"No data is available for the specified filters\" as this is probably not what the user wants             If the discretes filter suppresses out all data in the sankey then no exception is raised but zero totals are returned

Obtain discrete values from an event stream table             Supports use of a snapshot table which should reduce the chances of us blowing the Engine discrete limit.             The first parameters constitute the sankey filters and thereby the starting set for discretes             It will also allow us to filter the values by the specified discrete filters             If the sankey filters return no data then an execption is thrown stating that \"No data is available for the specified filters\" as this is probably not what the user wants             If the discretes filter suppresses out all data in the sankey then no exception is raised but zero totals are returned

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamDiscreteValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getEventStreamDiscreteValuesRequest = new GetEventStreamDiscreteValuesRequest(); // GetEventStreamDiscreteValuesRequest | Obtain discrete values from an event stream table             Supports use of a snapshot table which should reduce the chances of us blowing the Engine discrete limit.             The first parameters constitute the sankey filters and thereby the starting set for discretes             It will also allow us to filter the values by the specified discrete filters             If the sankey filters return no data then an execption is thrown stating that \"No data is available for the specified filters\" as this is probably not what the user wants             If the discretes filter suppresses out all data in the sankey then no exception is raised but zero totals are returned

            try
            {
                // Obtain discrete values from an event stream table             Supports use of a snapshot table which should reduce the chances of us blowing the Engine discrete limit.             The first parameters constitute the sankey filters and thereby the starting set for discretes             It will also allow us to filter the values by the specified discrete filters             If the sankey filters return no data then an execption is thrown stating that \"No data is available for the specified filters\" as this is probably not what the user wants             If the discretes filter suppresses out all data in the sankey then no exception is raised but zero totals are returned
                GetEventStreamDiscreteValuesDefaultResponse result = apiInstance.GetEventStreamDiscreteValues(getEventStreamDiscreteValuesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventStreamDiscreteValues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamDiscreteValuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Obtain discrete values from an event stream table             Supports use of a snapshot table which should reduce the chances of us blowing the Engine discrete limit.             The first parameters constitute the sankey filters and thereby the starting set for discretes             It will also allow us to filter the values by the specified discrete filters             If the sankey filters return no data then an execption is thrown stating that \"No data is available for the specified filters\" as this is probably not what the user wants             If the discretes filter suppresses out all data in the sankey then no exception is raised but zero totals are returned
    ApiResponse<GetEventStreamDiscreteValuesDefaultResponse> response = apiInstance.GetEventStreamDiscreteValuesWithHttpInfo(getEventStreamDiscreteValuesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventStreamDiscreteValuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventStreamDiscreteValuesRequest** | [**GetEventStreamDiscreteValuesRequest**](GetEventStreamDiscreteValuesRequest.md) | Obtain discrete values from an event stream table             Supports use of a snapshot table which should reduce the chances of us blowing the Engine discrete limit.             The first parameters constitute the sankey filters and thereby the starting set for discretes             It will also allow us to filter the values by the specified discrete filters             If the sankey filters return no data then an execption is thrown stating that \&quot;No data is available for the specified filters\&quot; as this is probably not what the user wants             If the discretes filter suppresses out all data in the sankey then no exception is raised but zero totals are returned |  |

### Return type

[**GetEventStreamDiscreteValuesDefaultResponse**](GetEventStreamDiscreteValuesDefaultResponse.md)

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

<a id="geteventstreammodels"></a>
# **GetEventStreamModels**
> GetEventStreamModelsDefaultResponse GetEventStreamModels (GetEventStreamModelsRequest getEventStreamModelsRequest)

Retrieve available models

Retrieve available models

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getEventStreamModelsRequest = new GetEventStreamModelsRequest(); // GetEventStreamModelsRequest | Retrieve available models

            try
            {
                // Retrieve available models
                GetEventStreamModelsDefaultResponse result = apiInstance.GetEventStreamModels(getEventStreamModelsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventStreamModels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamModelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve available models
    ApiResponse<GetEventStreamModelsDefaultResponse> response = apiInstance.GetEventStreamModelsWithHttpInfo(getEventStreamModelsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventStreamModelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEventStreamModelsRequest** | [**GetEventStreamModelsRequest**](GetEventStreamModelsRequest.md) | Retrieve available models |  |

### Return type

[**GetEventStreamModelsDefaultResponse**](GetEventStreamModelsDefaultResponse.md)

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

<a id="geteventstreams"></a>
# **GetEventStreams**
> GetEventStreamsDefaultResponse GetEventStreams (GetClientSetsRequest getClientSetsRequest)

Returns back a list of event streams which exist in the system

Returns back a list of event streams which exist in the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetEventStreamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getClientSetsRequest = new GetClientSetsRequest(); // GetClientSetsRequest | Returns back a list of event streams which exist in the system

            try
            {
                // Returns back a list of event streams which exist in the system
                GetEventStreamsDefaultResponse result = apiInstance.GetEventStreams(getClientSetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetEventStreams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventStreamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a list of event streams which exist in the system
    ApiResponse<GetEventStreamsDefaultResponse> response = apiInstance.GetEventStreamsWithHttpInfo(getClientSetsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetEventStreamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getClientSetsRequest** | [**GetClientSetsRequest**](GetClientSetsRequest.md) | Returns back a list of event streams which exist in the system |  |

### Return type

[**GetEventStreamsDefaultResponse**](GetEventStreamsDefaultResponse.md)

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

<a id="getfieldtransformationdiscretevalues"></a>
# **GetFieldTransformationDiscreteValues**
> GetEventStreamDecodeTargetDiscretesDefaultResponse GetFieldTransformationDiscreteValues (GetFieldTransformationDiscreteValuesRequest getFieldTransformationDiscreteValuesRequest)

Apply a list of transforms to the discrete values of a column and return the new set of values and their frequencies             If JSONTransforms is not supplied then the results will simply be the discrete values present in the source column after any sample has been applied

Apply a list of transforms to the discrete values of a column and return the new set of values and their frequencies             If JSONTransforms is not supplied then the results will simply be the discrete values present in the source column after any sample has been applied

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetFieldTransformationDiscreteValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getFieldTransformationDiscreteValuesRequest = new GetFieldTransformationDiscreteValuesRequest(); // GetFieldTransformationDiscreteValuesRequest | Apply a list of transforms to the discrete values of a column and return the new set of values and their frequencies             If JSONTransforms is not supplied then the results will simply be the discrete values present in the source column after any sample has been applied

            try
            {
                // Apply a list of transforms to the discrete values of a column and return the new set of values and their frequencies             If JSONTransforms is not supplied then the results will simply be the discrete values present in the source column after any sample has been applied
                GetEventStreamDecodeTargetDiscretesDefaultResponse result = apiInstance.GetFieldTransformationDiscreteValues(getFieldTransformationDiscreteValuesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetFieldTransformationDiscreteValues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFieldTransformationDiscreteValuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply a list of transforms to the discrete values of a column and return the new set of values and their frequencies             If JSONTransforms is not supplied then the results will simply be the discrete values present in the source column after any sample has been applied
    ApiResponse<GetEventStreamDecodeTargetDiscretesDefaultResponse> response = apiInstance.GetFieldTransformationDiscreteValuesWithHttpInfo(getFieldTransformationDiscreteValuesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetFieldTransformationDiscreteValuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getFieldTransformationDiscreteValuesRequest** | [**GetFieldTransformationDiscreteValuesRequest**](GetFieldTransformationDiscreteValuesRequest.md) | Apply a list of transforms to the discrete values of a column and return the new set of values and their frequencies             If JSONTransforms is not supplied then the results will simply be the discrete values present in the source column after any sample has been applied |  |

### Return type

[**GetEventStreamDecodeTargetDiscretesDefaultResponse**](GetEventStreamDecodeTargetDiscretesDefaultResponse.md)

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

<a id="getfieldtransformationmappings"></a>
# **GetFieldTransformationMappings**
> GetFieldTransformationMappingsDefaultResponse GetFieldTransformationMappings (GetFieldTransformationMappingsRequest getFieldTransformationMappingsRequest)

Apply a list of transforms and return information about the transformed value and frequency for each item in the starting set of values             If JSONCompareTransforms is specified then the starting set of values is the result of first applying these to these to the specified column             If JSONCompareTransforms is not specified then the starting set of values is the actual discrete values present in the column

Apply a list of transforms and return information about the transformed value and frequency for each item in the starting set of values             If JSONCompareTransforms is specified then the starting set of values is the result of first applying these to these to the specified column             If JSONCompareTransforms is not specified then the starting set of values is the actual discrete values present in the column

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetFieldTransformationMappingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getFieldTransformationMappingsRequest = new GetFieldTransformationMappingsRequest(); // GetFieldTransformationMappingsRequest | Apply a list of transforms and return information about the transformed value and frequency for each item in the starting set of values             If JSONCompareTransforms is specified then the starting set of values is the result of first applying these to these to the specified column             If JSONCompareTransforms is not specified then the starting set of values is the actual discrete values present in the column

            try
            {
                // Apply a list of transforms and return information about the transformed value and frequency for each item in the starting set of values             If JSONCompareTransforms is specified then the starting set of values is the result of first applying these to these to the specified column             If JSONCompareTransforms is not specified then the starting set of values is the actual discrete values present in the column
                GetFieldTransformationMappingsDefaultResponse result = apiInstance.GetFieldTransformationMappings(getFieldTransformationMappingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetFieldTransformationMappings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFieldTransformationMappingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply a list of transforms and return information about the transformed value and frequency for each item in the starting set of values             If JSONCompareTransforms is specified then the starting set of values is the result of first applying these to these to the specified column             If JSONCompareTransforms is not specified then the starting set of values is the actual discrete values present in the column
    ApiResponse<GetFieldTransformationMappingsDefaultResponse> response = apiInstance.GetFieldTransformationMappingsWithHttpInfo(getFieldTransformationMappingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetFieldTransformationMappingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getFieldTransformationMappingsRequest** | [**GetFieldTransformationMappingsRequest**](GetFieldTransformationMappingsRequest.md) | Apply a list of transforms and return information about the transformed value and frequency for each item in the starting set of values             If JSONCompareTransforms is specified then the starting set of values is the result of first applying these to these to the specified column             If JSONCompareTransforms is not specified then the starting set of values is the actual discrete values present in the column |  |

### Return type

[**GetFieldTransformationMappingsDefaultResponse**](GetFieldTransformationMappingsDefaultResponse.md)

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

<a id="getidealisedjourneys"></a>
# **GetIdealisedJourneys**
> GetIdealisedJourneysDefaultResponse GetIdealisedJourneys ()

Retrieve a list of Idealised Journeys

Retrieve a list of Idealised Journeys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetIdealisedJourneysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);

            try
            {
                // Retrieve a list of Idealised Journeys
                GetIdealisedJourneysDefaultResponse result = apiInstance.GetIdealisedJourneys();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetIdealisedJourneys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIdealisedJourneysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a list of Idealised Journeys
    ApiResponse<GetIdealisedJourneysDefaultResponse> response = apiInstance.GetIdealisedJourneysWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetIdealisedJourneysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetIdealisedJourneysDefaultResponse**](GetIdealisedJourneysDefaultResponse.md)

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

<a id="getsankeyfavourites"></a>
# **GetSankeyFavourites**
> GetSankeyFavouritesDefaultResponse GetSankeyFavourites (GetSankeyFavouritesRequest getSankeyFavouritesRequest)

Retrieve a list of Sankey Favourites

Retrieve a list of Sankey Favourites

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetSankeyFavouritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var getSankeyFavouritesRequest = new GetSankeyFavouritesRequest(); // GetSankeyFavouritesRequest | Retrieve a list of Sankey Favourites

            try
            {
                // Retrieve a list of Sankey Favourites
                GetSankeyFavouritesDefaultResponse result = apiInstance.GetSankeyFavourites(getSankeyFavouritesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetSankeyFavourites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSankeyFavouritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a list of Sankey Favourites
    ApiResponse<GetSankeyFavouritesDefaultResponse> response = apiInstance.GetSankeyFavouritesWithHttpInfo(getSankeyFavouritesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetSankeyFavouritesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSankeyFavouritesRequest** | [**GetSankeyFavouritesRequest**](GetSankeyFavouritesRequest.md) | Retrieve a list of Sankey Favourites |  |

### Return type

[**GetSankeyFavouritesDefaultResponse**](GetSankeyFavouritesDefaultResponse.md)

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

<a id="getvisualisationfavourites"></a>
# **GetVisualisationFavourites**
> GetVisualisationFavouritesDefaultResponse GetVisualisationFavourites ()

Retrieve a list of Visualisation Favourites

Retrieve a list of Visualisation Favourites

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class GetVisualisationFavouritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);

            try
            {
                // Retrieve a list of Visualisation Favourites
                GetVisualisationFavouritesDefaultResponse result = apiInstance.GetVisualisationFavourites();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.GetVisualisationFavourites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVisualisationFavouritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a list of Visualisation Favourites
    ApiResponse<GetVisualisationFavouritesDefaultResponse> response = apiInstance.GetVisualisationFavouritesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.GetVisualisationFavouritesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetVisualisationFavouritesDefaultResponse**](GetVisualisationFavouritesDefaultResponse.md)

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

<a id="queryeventstream"></a>
# **QueryEventStream**
> QueryEventStreamDefaultResponse QueryEventStream (QueryEventStreamRequest queryEventStreamRequest)

Queries the domain of selected event records that is represented by the date and event type filters, returning the list of events and graph of transition streams along with frequency counts.             Transitions will specify start and end points using indices into the list of events, along with some special values.             The 'Drop off' points where a stream ends will be assigned an index of -1.             Any transition to an event that does not fall into the TopN specification will be assigned to an 'other events' category with an index of -2.             Right aligned streams will be left-padded up to the MaxLength specification using a 'no event' category with an index of -3.             If timeout events are required then the start of the sequence leading up to a timeout will be flagged with an index of -4 and the end with an index of -5.

Queries the domain of selected event records that is represented by the date and event type filters, returning the list of events and graph of transition streams along with frequency counts.             Transitions will specify start and end points using indices into the list of events, along with some special values.             The 'Drop off' points where a stream ends will be assigned an index of -1.             Any transition to an event that does not fall into the TopN specification will be assigned to an 'other events' category with an index of -2.             Right aligned streams will be left-padded up to the MaxLength specification using a 'no event' category with an index of -3.             If timeout events are required then the start of the sequence leading up to a timeout will be flagged with an index of -4 and the end with an index of -5.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class QueryEventStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var queryEventStreamRequest = new QueryEventStreamRequest(); // QueryEventStreamRequest | Queries the domain of selected event records that is represented by the date and event type filters, returning the list of events and graph of transition streams along with frequency counts.             Transitions will specify start and end points using indices into the list of events, along with some special values.             The 'Drop off' points where a stream ends will be assigned an index of -1.             Any transition to an event that does not fall into the TopN specification will be assigned to an 'other events' category with an index of -2.             Right aligned streams will be left-padded up to the MaxLength specification using a 'no event' category with an index of -3.             If timeout events are required then the start of the sequence leading up to a timeout will be flagged with an index of -4 and the end with an index of -5.

            try
            {
                // Queries the domain of selected event records that is represented by the date and event type filters, returning the list of events and graph of transition streams along with frequency counts.             Transitions will specify start and end points using indices into the list of events, along with some special values.             The 'Drop off' points where a stream ends will be assigned an index of -1.             Any transition to an event that does not fall into the TopN specification will be assigned to an 'other events' category with an index of -2.             Right aligned streams will be left-padded up to the MaxLength specification using a 'no event' category with an index of -3.             If timeout events are required then the start of the sequence leading up to a timeout will be flagged with an index of -4 and the end with an index of -5.
                QueryEventStreamDefaultResponse result = apiInstance.QueryEventStream(queryEventStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.QueryEventStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryEventStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Queries the domain of selected event records that is represented by the date and event type filters, returning the list of events and graph of transition streams along with frequency counts.             Transitions will specify start and end points using indices into the list of events, along with some special values.             The 'Drop off' points where a stream ends will be assigned an index of -1.             Any transition to an event that does not fall into the TopN specification will be assigned to an 'other events' category with an index of -2.             Right aligned streams will be left-padded up to the MaxLength specification using a 'no event' category with an index of -3.             If timeout events are required then the start of the sequence leading up to a timeout will be flagged with an index of -4 and the end with an index of -5.
    ApiResponse<QueryEventStreamDefaultResponse> response = apiInstance.QueryEventStreamWithHttpInfo(queryEventStreamRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.QueryEventStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryEventStreamRequest** | [**QueryEventStreamRequest**](QueryEventStreamRequest.md) | Queries the domain of selected event records that is represented by the date and event type filters, returning the list of events and graph of transition streams along with frequency counts.             Transitions will specify start and end points using indices into the list of events, along with some special values.             The &#39;Drop off&#39; points where a stream ends will be assigned an index of -1.             Any transition to an event that does not fall into the TopN specification will be assigned to an &#39;other events&#39; category with an index of -2.             Right aligned streams will be left-padded up to the MaxLength specification using a &#39;no event&#39; category with an index of -3.             If timeout events are required then the start of the sequence leading up to a timeout will be flagged with an index of -4 and the end with an index of -5. |  |

### Return type

[**QueryEventStreamDefaultResponse**](QueryEventStreamDefaultResponse.md)

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

<a id="queryeventstreamcount"></a>
# **QueryEventStreamCount**
> QueryEventStreamCountDefaultResponse QueryEventStreamCount (QueryEventStreamCountRequest queryEventStreamCountRequest)

Take the domain of selected event records that is represented by the date filters, and count streams matching the agreed patterns represented by the CountType parameter

Take the domain of selected event records that is represented by the date filters, and count streams matching the agreed patterns represented by the CountType parameter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class QueryEventStreamCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var queryEventStreamCountRequest = new QueryEventStreamCountRequest(); // QueryEventStreamCountRequest | Take the domain of selected event records that is represented by the date filters, and count streams matching the agreed patterns represented by the CountType parameter

            try
            {
                // Take the domain of selected event records that is represented by the date filters, and count streams matching the agreed patterns represented by the CountType parameter
                QueryEventStreamCountDefaultResponse result = apiInstance.QueryEventStreamCount(queryEventStreamCountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.QueryEventStreamCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryEventStreamCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Take the domain of selected event records that is represented by the date filters, and count streams matching the agreed patterns represented by the CountType parameter
    ApiResponse<QueryEventStreamCountDefaultResponse> response = apiInstance.QueryEventStreamCountWithHttpInfo(queryEventStreamCountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.QueryEventStreamCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryEventStreamCountRequest** | [**QueryEventStreamCountRequest**](QueryEventStreamCountRequest.md) | Take the domain of selected event records that is represented by the date filters, and count streams matching the agreed patterns represented by the CountType parameter |  |

### Return type

[**QueryEventStreamCountDefaultResponse**](QueryEventStreamCountDefaultResponse.md)

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

<a id="queryeventstreaminteraction"></a>
# **QueryEventStreamInteraction**
> GetEventRecordsDefaultResponse QueryEventStreamInteraction (ExportEventStreamInteractionRequest exportEventStreamInteractionRequest)

Queries the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.

Queries the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class QueryEventStreamInteractionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var exportEventStreamInteractionRequest = new ExportEventStreamInteractionRequest(); // ExportEventStreamInteractionRequest | Queries the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.

            try
            {
                // Queries the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.
                GetEventRecordsDefaultResponse result = apiInstance.QueryEventStreamInteraction(exportEventStreamInteractionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.QueryEventStreamInteraction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryEventStreamInteractionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Queries the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEvents' to False.
    ApiResponse<GetEventRecordsDefaultResponse> response = apiInstance.QueryEventStreamInteractionWithHttpInfo(exportEventStreamInteractionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.QueryEventStreamInteractionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **exportEventStreamInteractionRequest** | [**ExportEventStreamInteractionRequest**](ExportEventStreamInteractionRequest.md) | Queries the domain of a particular node to return a sample of the CXID (VisitorId) values.             To get the results for \&quot;other\&quot; events pass all displayed events and set &#39;IncludeMatchedEvents&#39; to False. |  |

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

<a id="queryeventstreamtransition"></a>
# **QueryEventStreamTransition**
> GetEventRecordsDefaultResponse QueryEventStreamTransition (QueryEventStreamTransitionRequest queryEventStreamTransitionRequest)

Queries the domain from a particular node to another node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEventsFrom' / IncludeMatchedEventsTo to False.

Queries the domain from a particular node to another node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEventsFrom' / IncludeMatchedEventsTo to False.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class QueryEventStreamTransitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var queryEventStreamTransitionRequest = new QueryEventStreamTransitionRequest(); // QueryEventStreamTransitionRequest | Queries the domain from a particular node to another node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEventsFrom' / IncludeMatchedEventsTo to False.

            try
            {
                // Queries the domain from a particular node to another node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEventsFrom' / IncludeMatchedEventsTo to False.
                GetEventRecordsDefaultResponse result = apiInstance.QueryEventStreamTransition(queryEventStreamTransitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.QueryEventStreamTransition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryEventStreamTransitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Queries the domain from a particular node to another node to return a sample of the CXID (VisitorId) values.             To get the results for \"other\" events pass all displayed events and set 'IncludeMatchedEventsFrom' / IncludeMatchedEventsTo to False.
    ApiResponse<GetEventRecordsDefaultResponse> response = apiInstance.QueryEventStreamTransitionWithHttpInfo(queryEventStreamTransitionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.QueryEventStreamTransitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryEventStreamTransitionRequest** | [**QueryEventStreamTransitionRequest**](QueryEventStreamTransitionRequest.md) | Queries the domain from a particular node to another node to return a sample of the CXID (VisitorId) values.             To get the results for \&quot;other\&quot; events pass all displayed events and set &#39;IncludeMatchedEventsFrom&#39; / IncludeMatchedEventsTo to False. |  |

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

<a id="runsequencepredictor"></a>
# **RunSequencePredictor**
> RunSequencePredictorDefaultResponse RunSequencePredictor (RunSequencePredictorRequest runSequencePredictorRequest)

Train and employ sequence prediction models for an event stream

Train and employ sequence prediction models for an event stream

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class RunSequencePredictorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var runSequencePredictorRequest = new RunSequencePredictorRequest(); // RunSequencePredictorRequest | Train and employ sequence prediction models for an event stream

            try
            {
                // Train and employ sequence prediction models for an event stream
                RunSequencePredictorDefaultResponse result = apiInstance.RunSequencePredictor(runSequencePredictorRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.RunSequencePredictor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunSequencePredictorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Train and employ sequence prediction models for an event stream
    ApiResponse<RunSequencePredictorDefaultResponse> response = apiInstance.RunSequencePredictorWithHttpInfo(runSequencePredictorRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.RunSequencePredictorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runSequencePredictorRequest** | [**RunSequencePredictorRequest**](RunSequencePredictorRequest.md) | Train and employ sequence prediction models for an event stream |  |

### Return type

[**RunSequencePredictorDefaultResponse**](RunSequencePredictorDefaultResponse.md)

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

<a id="updatechannel"></a>
# **UpdateChannel**
> AUTHChangePasswordDefaultResponse UpdateChannel (UpdateChannelRequest updateChannelRequest)

Updates a channel, allowing you to change the name and colour

Updates a channel, allowing you to change the name and colour

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var updateChannelRequest = new UpdateChannelRequest(); // UpdateChannelRequest | Updates a channel, allowing you to change the name and colour

            try
            {
                // Updates a channel, allowing you to change the name and colour
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateChannel(updateChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.UpdateChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a channel, allowing you to change the name and colour
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateChannelWithHttpInfo(updateChannelRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.UpdateChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateChannelRequest** | [**UpdateChannelRequest**](UpdateChannelRequest.md) | Updates a channel, allowing you to change the name and colour |  |

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

<a id="updateeventstreamfieldtransformlists"></a>
# **UpdateEventStreamFieldTransformLists**
> AUTHChangePasswordDefaultResponse UpdateEventStreamFieldTransformLists (UpdateEventStreamFieldTransformListsRequest updateEventStreamFieldTransformListsRequest)

Publishes the specified transforms to the corresponding event stream columns             Any existing list for a column that matches on Transform Type and Alias will be replaced

Publishes the specified transforms to the corresponding event stream columns             Any existing list for a column that matches on Transform Type and Alias will be replaced

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateEventStreamFieldTransformListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var updateEventStreamFieldTransformListsRequest = new UpdateEventStreamFieldTransformListsRequest(); // UpdateEventStreamFieldTransformListsRequest | Publishes the specified transforms to the corresponding event stream columns             Any existing list for a column that matches on Transform Type and Alias will be replaced

            try
            {
                // Publishes the specified transforms to the corresponding event stream columns             Any existing list for a column that matches on Transform Type and Alias will be replaced
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateEventStreamFieldTransformLists(updateEventStreamFieldTransformListsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.UpdateEventStreamFieldTransformLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEventStreamFieldTransformListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Publishes the specified transforms to the corresponding event stream columns             Any existing list for a column that matches on Transform Type and Alias will be replaced
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateEventStreamFieldTransformListsWithHttpInfo(updateEventStreamFieldTransformListsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.UpdateEventStreamFieldTransformListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateEventStreamFieldTransformListsRequest** | [**UpdateEventStreamFieldTransformListsRequest**](UpdateEventStreamFieldTransformListsRequest.md) | Publishes the specified transforms to the corresponding event stream columns             Any existing list for a column that matches on Transform Type and Alias will be replaced |  |

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

<a id="updateidealisedjourney"></a>
# **UpdateIdealisedJourney**
> AUTHChangePasswordDefaultResponse UpdateIdealisedJourney (UpdateIdealisedJourneyRequest updateIdealisedJourneyRequest)

Update an Idealised Journey

Update an Idealised Journey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateIdealisedJourneyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var updateIdealisedJourneyRequest = new UpdateIdealisedJourneyRequest(); // UpdateIdealisedJourneyRequest | Update an Idealised Journey

            try
            {
                // Update an Idealised Journey
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateIdealisedJourney(updateIdealisedJourneyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.UpdateIdealisedJourney: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateIdealisedJourneyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an Idealised Journey
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateIdealisedJourneyWithHttpInfo(updateIdealisedJourneyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.UpdateIdealisedJourneyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateIdealisedJourneyRequest** | [**UpdateIdealisedJourneyRequest**](UpdateIdealisedJourneyRequest.md) | Update an Idealised Journey |  |

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

<a id="updatesankeyfavourite"></a>
# **UpdateSankeyFavourite**
> AUTHChangePasswordDefaultResponse UpdateSankeyFavourite (UpdateSankeyFavouriteRequest updateSankeyFavouriteRequest)

Update a SankeyFavourite

Update a SankeyFavourite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateSankeyFavouriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var updateSankeyFavouriteRequest = new UpdateSankeyFavouriteRequest(); // UpdateSankeyFavouriteRequest | Update a SankeyFavourite

            try
            {
                // Update a SankeyFavourite
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateSankeyFavourite(updateSankeyFavouriteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.UpdateSankeyFavourite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSankeyFavouriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a SankeyFavourite
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateSankeyFavouriteWithHttpInfo(updateSankeyFavouriteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.UpdateSankeyFavouriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateSankeyFavouriteRequest** | [**UpdateSankeyFavouriteRequest**](UpdateSankeyFavouriteRequest.md) | Update a SankeyFavourite |  |

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

<a id="updatevisualisationfavourite"></a>
# **UpdateVisualisationFavourite**
> AUTHChangePasswordDefaultResponse UpdateVisualisationFavourite (UpdateVisualisationFavouriteRequest updateVisualisationFavouriteRequest)

Update a Visualisation Favourite

Update a Visualisation Favourite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpdateVisualisationFavouriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var updateVisualisationFavouriteRequest = new UpdateVisualisationFavouriteRequest(); // UpdateVisualisationFavouriteRequest | Update a Visualisation Favourite

            try
            {
                // Update a Visualisation Favourite
                AUTHChangePasswordDefaultResponse result = apiInstance.UpdateVisualisationFavourite(updateVisualisationFavouriteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.UpdateVisualisationFavourite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVisualisationFavouriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Visualisation Favourite
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpdateVisualisationFavouriteWithHttpInfo(updateVisualisationFavouriteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.UpdateVisualisationFavouriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateVisualisationFavouriteRequest** | [**UpdateVisualisationFavouriteRequest**](UpdateVisualisationFavouriteRequest.md) | Update a Visualisation Favourite |  |

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

<a id="upserteventstreamcustomercolumns"></a>
# **UpsertEventStreamCustomerColumns**
> AUTHChangePasswordDefaultResponse UpsertEventStreamCustomerColumns (UpsertEventStreamCustomerColumnsRequest upsertEventStreamCustomerColumnsRequest)

Add or update customer attribute columns for an @see(EventStream).             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.

Add or update customer attribute columns for an @see(EventStream).             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpsertEventStreamCustomerColumnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var upsertEventStreamCustomerColumnsRequest = new UpsertEventStreamCustomerColumnsRequest(); // UpsertEventStreamCustomerColumnsRequest | Add or update customer attribute columns for an @see(EventStream).             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.

            try
            {
                // Add or update customer attribute columns for an @see(EventStream).             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.
                AUTHChangePasswordDefaultResponse result = apiInstance.UpsertEventStreamCustomerColumns(upsertEventStreamCustomerColumnsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.UpsertEventStreamCustomerColumns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertEventStreamCustomerColumnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add or update customer attribute columns for an @see(EventStream).             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpsertEventStreamCustomerColumnsWithHttpInfo(upsertEventStreamCustomerColumnsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.UpsertEventStreamCustomerColumnsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertEventStreamCustomerColumnsRequest** | [**UpsertEventStreamCustomerColumnsRequest**](UpsertEventStreamCustomerColumnsRequest.md) | Add or update customer attribute columns for an @see(EventStream).             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements. |  |

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

<a id="upserteventstreamcustomercolumnstogroup"></a>
# **UpsertEventStreamCustomerColumnsToGroup**
> AUTHChangePasswordDefaultResponse UpsertEventStreamCustomerColumnsToGroup (UpsertEventStreamCustomerColumnsToGroupRequest upsertEventStreamCustomerColumnsToGroupRequest)

Add or update customer attribute columns to the @see(EventStream)s in a group.             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.             There is some latency (up to 5 mins) between a column being created and the queue service starting to read the data unless the queue service is restarted

Add or update customer attribute columns to the @see(EventStream)s in a group.             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.             There is some latency (up to 5 mins) between a column being created and the queue service starting to read the data unless the queue service is restarted

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.JA.Api;
using Alterian.JA.Client;
using Alterian.JA.Model;

namespace Example
{
    public class UpsertEventStreamCustomerColumnsToGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/services/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new EventStreamsApi(config);
            var upsertEventStreamCustomerColumnsToGroupRequest = new UpsertEventStreamCustomerColumnsToGroupRequest(); // UpsertEventStreamCustomerColumnsToGroupRequest | Add or update customer attribute columns to the @see(EventStream)s in a group.             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.             There is some latency (up to 5 mins) between a column being created and the queue service starting to read the data unless the queue service is restarted

            try
            {
                // Add or update customer attribute columns to the @see(EventStream)s in a group.             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.             There is some latency (up to 5 mins) between a column being created and the queue service starting to read the data unless the queue service is restarted
                AUTHChangePasswordDefaultResponse result = apiInstance.UpsertEventStreamCustomerColumnsToGroup(upsertEventStreamCustomerColumnsToGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamsApi.UpsertEventStreamCustomerColumnsToGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertEventStreamCustomerColumnsToGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add or update customer attribute columns to the @see(EventStream)s in a group.             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.             There is some latency (up to 5 mins) between a column being created and the queue service starting to read the data unless the queue service is restarted
    ApiResponse<AUTHChangePasswordDefaultResponse> response = apiInstance.UpsertEventStreamCustomerColumnsToGroupWithHttpInfo(upsertEventStreamCustomerColumnsToGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamsApi.UpsertEventStreamCustomerColumnsToGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertEventStreamCustomerColumnsToGroupRequest** | [**UpsertEventStreamCustomerColumnsToGroupRequest**](UpsertEventStreamCustomerColumnsToGroupRequest.md) | Add or update customer attribute columns to the @see(EventStream)s in a group.             Only updates to column width (that are atomic and have no truncation risk) are currenty supported.              Width only needs to be specified for text or unicode columns.              The number of allowed columns is capped.              Customer attribute columns must maintain discrete cardinality to be used in the Sankey.              Names must meet Engine naming requirements.             There is some latency (up to 5 mins) between a column being created and the queue service starting to read the data unless the queue service is restarted |  |

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

