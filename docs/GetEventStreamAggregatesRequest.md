# Alterian.JA.Model.GetEventStreamAggregatesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnTransforms** | [**List&lt;EventStreamColumnTransform&gt;**](EventStreamColumnTransform.md) | Applies the specified transforms to base the result on the transformed discrete values | [optional] 
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**DataSourceId** | **int** | Datasource ID | [optional] 
**EventDateTimeLower** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventDateTimeUpper** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventStreamId** | **int?** | Optionally invoke using an Event Stream ID instead of DataSourceId/TableNameEx. In this mode ColumnTransforms will be defaulted to those published against the columns of the Event Stream but can still be overridden if required | [optional] 
**Filters** | [**List&lt;ColumnMatchList&gt;**](ColumnMatchList.md) | Additional columns to filter on | [optional] 
**IsDataRefreshRequired** | **bool** | Indicate whether the request can be satisfied with an existing cached result or requires recreation with latest data (default false). Has no effect if PatternId is specified | [optional] 
**Pattern** | [**EventStreamPattern**](EventStreamPattern.md) |  | [optional] 
**TableNameEx** | **string** | Event Stream table (standard two part name ex) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

