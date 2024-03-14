# Alterian.JA.Model.QueryEventStreamRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alignment** | **EventStreamAlignmentType** |  | [optional] 
**AlignmentEventName** | **string** | If Alignment is set to Left/Right,then this is the primary event name that will be aligned to, with an empty string meaning alignment to NULL | [optional] 
**AlignmentSecondaryEventName** | **string** | If Alignment is set to Left/Right, and a secondary event column is specified then this is the secondary event name that will be aligned to, with an empty string meaning alignment to NULL | [optional] 
**ColumnTransforms** | [**List&lt;EventStreamColumnTransform&gt;**](EventStreamColumnTransform.md) | Applies the specified transforms to base the result on the transformed discrete values | [optional] 
**ConversationTimeoutInSeconds** | **int?** | Configures delay after which a new conversation is considered to have started - defaults to 1800s (30mins) when either StreamKey is set to Interaction or Timeout events are required | [optional] 
**DataSourceId** | **int** | Datasource ID | [optional] 
**EventDateTimeLower** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventDateTimeUpper** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventStreamId** | **int?** | Optionally invoke using an Event Stream ID instead of DataSourceId/TableNameEx. In this mode ColumnTransforms will be defaulted to those published against the columns of the Event Stream but can still be overridden if required | [optional] 
**EventTypes** | **List&lt;string&gt;** | List of event types to include (default to all) | [optional] 
**Filters** | [**List&lt;ColumnMatchList&gt;**](ColumnMatchList.md) | Additional columns to filter on | [optional] 
**Initiatives** | **List&lt;string&gt;** | List of initiatives to include (default to all) | [optional] 
**IsDataRefreshRequired** | **bool** | Indicate whether the request can be satisfied with an existing cached result or requires recreation with latest data (default false). Has no effect if PatternId is specified | [optional] 
**IsDeduplicationRequired** | **bool** | Indicates whether identical consecutive events in a stream are combined into a single event (default false) | [optional] 
**IsTimeoutEventsRequired** | **bool?** | Optionally show Start/End conversation events | [optional] 
**MaxLength** | **int?** | Max number of interactions (default 5) to display per stream | [optional] 
**Pattern** | [**EventStreamPattern**](EventStreamPattern.md) |  | [optional] 
**PrimaryEventColumnName** | **string** | Optionally set the column name that contains the event names (defaults to Location) | [optional] 
**SecondaryEventColumnName** | **string** | Optionally set a secondary column name that can be used to further partition the events e.g. Channel | [optional] 
**StreamKey** | **string** | Optionally specify the key to be used for the Sankey - Visitor, Interaction etc (defaults to using the Visitor ID) | [optional] 
**StreamQuery** | **string** | Specify rules for stream inclusion using stream query patterns e.g. Offer/_*_/Checkout would require a stream to have an offer event followed by a checkout event | [optional] 
**TableNameEx** | **string** | Event Stream table (standard two part name ex) | [optional] 
**TopN** | **int?** | Max number of events (default 5) to display in each interaction preferring highest count | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

