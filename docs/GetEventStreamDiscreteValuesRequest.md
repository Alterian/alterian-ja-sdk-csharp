# Alterian.JA.Model.GetEventStreamDiscreteValuesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnTransforms** | [**List&lt;EventStreamColumnTransform&gt;**](EventStreamColumnTransform.md) | Applies the specified transforms to base the result on the transformed discrete values | [optional] 
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**DataSourceId** | **int** | Id of the datasource to which table belongs. | [optional] 
**EventDateTimeLower** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventDateTimeUpper** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventStreamId** | **int?** | Optionally invoke using an Event Stream ID instead of DataSourceId/TableNameEx. In this mode ColumnTransforms will be defaulted to those published against the columns of the Event Stream but can still be overridden if required | [optional] 
**EventTypes** | **List&lt;string&gt;** | List of event types to include (default to all) | [optional] 
**Filters** | [**List&lt;ColumnMatchList&gt;**](ColumnMatchList.md) | Additional columns to filter on | [optional] 
**Initiatives** | **List&lt;string&gt;** | List of initiatives to include (default to all) | [optional] 
**IsDataRefreshRequired** | **bool** | Indicate whether the request can be satisfied with an existing cached result or requires recreation with latest data (default false). Has no effect if PatternId is specified | [optional] 
**Pattern** | [**EventStreamPattern**](EventStreamPattern.md) |  | [optional] 
**PrimaryDiscretesColumnName** | **string** | Optionally set the column name that is the primary source of discrete values (defaults to Location) | [optional] 
**PrimaryDiscretesFilter** | **string** | Optionally set a literal value or NSQL wildcard filter to further restrict the number of primary discrete values considered (e.g. MyEvent or %AllTheseEvents or EventsBeginningWith*) | [optional] 
**SecondaryDiscretesColumnName** | **string** | Optionally set a secondary column name that can be used to further partition the discrete values e.g. Channel | [optional] 
**SecondaryDiscretesFilter** | **string** | Optionally set a literal value or NSQL wildcard filter to further restrict the number of secondary discrete values considered (e.g. MyEvent or %AllTheseEvents or EventsBeginningWith*) | [optional] 
**TableNameEx** | **string** | Event Stream table (standard two part name ex) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

