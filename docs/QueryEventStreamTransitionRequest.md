# Alterian.JA.Model.QueryEventStreamTransitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alignment** | **EventStreamAlignmentType** |  | [optional] 
**AlignmentEventName** | **string** | Optional event name to align to. Requires Alignment to be set | [optional] 
**ColumnTransforms** | [**List&lt;EventStreamColumnTransform&gt;**](EventStreamColumnTransform.md) | Applies the specified transforms to base the result on the transformed discrete values | [optional] 
**ConversationTimeoutInSeconds** | **int?** | Configures delay after which a new conversation is considered to have started - defaults to 1800s (30mins) when either StreamKey is set to Interaction or Timeout events are required | [optional] 
**Cursor** | [**APILastModifiedCursor**](APILastModifiedCursor.md) |  | [optional] 
**DataSourceId** | **int** | Datasource ID | [optional] 
**EventDateTimeLower** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventDateTimeUpper** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventStreamId** | **int?** | Optionally invoke using an Event Stream ID instead of DataSourceId/TableNameEx. In this mode ColumnTransforms will be defaulted to those published against the columns of the Event Stream but can still be overridden if required | [optional] 
**EventTypes** | **List&lt;string&gt;** | List of event types to include (default to all) | [optional] 
**Filters** | [**List&lt;ColumnMatchList&gt;**](ColumnMatchList.md) | Additional columns to filter on | [optional] 
**FromMatchEvents** | **List&lt;string&gt;** | Events to match at the start of the specified transition. Pass -1 to indicate the &#39;drop off&#39; event and -3 to specify the padded (&#39;no event&#39;) placeholder for right aligned streams | [optional] 
**IncludeFromMatchedEvents** | **bool?** | Set to False to exclude all records that fall into specified FromMatchEvents (Defaults to True). Use this to get events in the &#39;other&#39; category by passing all the displayed events and setting match to false | [optional] 
**IncludeToMatchedEvents** | **bool?** | Set to False to exclude all records that fall into specified ToMatchEvents (Defaults to True). Use this to get events in the &#39;other&#39; category by passing all the displayed events and setting match to false | [optional] 
**Initiatives** | **List&lt;string&gt;** | List of initiatives to include (default to all) | [optional] 
**Interaction** | **int** | Interaction start point | [optional] 
**IsDeduplicationRequired** | **bool** | Indicates whether identical consecutive events in a stream are combined into a single event (default false) | [optional] 
**IsTimeoutEventsRequired** | **bool?** | Optionally show Start/End conversation events | [optional] 
**Pattern** | [**EventStreamPattern**](EventStreamPattern.md) |  | [optional] 
**StreamKey** | **string** | Optionally specify the key to be used for the Sankey - Visitor, Interaction etc (defaults to using the Visitor ID) | [optional] 
**StreamQuery** | **string** | Specify rules for stream inclusion using stream query patterns e.g. Offer/_*_/Checkout would require a stream to have an offer event followed by a checkout event | [optional] 
**TableNameEx** | **string** | Event Stream table (standard two part name ex) | [optional] 
**ToMatchEvents** | **List&lt;string&gt;** | Events to match at the end of the specified transition. Pass -1 to indicate the &#39;drop off&#39; event and -3 to specify the padded (&#39;no event&#39;) placeholder for right aligned streams | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

