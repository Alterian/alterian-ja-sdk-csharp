# Alterian.JA.Model.QueryEventStreamCountRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountType** | **EventStreamCountType** |  | [optional] 
**DataSourceId** | **int** | Datasource ID | [optional] 
**EventDateTimeLower** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventDateTimeUpper** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventStreamId** | **int?** | Optionally invoke using an Event Stream ID instead of DataSourceId/TableNameEx. In this mode ColumnTransforms will be defaulted to those published against the columns of the Event Stream but can still be overridden if required | [optional] 
**Filters** | [**List&lt;ColumnMatchList&gt;**](ColumnMatchList.md) | Additional columns to filter on | [optional] 
**IsDataRefreshRequired** | **bool** | Indicate whether the request can be satisfied with an existing cached result or requires recreation with latest data (default false). Has no effect if PatternId is specified | [optional] 
**PatternId** | **int?** | Optionally invoke using a Pattern instead of DataSourceId/TableNameEx. Dates will default to those of the pattern snapshot but can be set to any range contained within that snapshot | [optional] 
**TableNameEx** | **string** | Event Stream table (standard two part name ex) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

