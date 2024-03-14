# Alterian.JA.Model.GetEventRecordsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnTransforms** | [**List&lt;EventStreamColumnTransform&gt;**](EventStreamColumnTransform.md) | Applies the specified transforms to base the result on the transformed discrete values | [optional] 
**Cursor** | [**APILastModifiedCursor**](APILastModifiedCursor.md) |  | [optional] 
**DataSourceId** | **int** | Id of the datasource to which table belongs. | [optional] 
**EventDateTimeLower** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventDateTimeUpper** | **DateTime?** | Optionally filter by EventDateTime | [optional] 
**EventTypes** | **List&lt;string&gt;** | List of event types to include (default to all) | [optional] 
**Filters** | [**List&lt;ColumnMatchList&gt;**](ColumnMatchList.md) | Additional columns to filter on | [optional] 
**Initiatives** | **List&lt;string&gt;** | List of initiatives to include (default to all) | [optional] 
**Key** | **int?** | Optional Key value (the integer re-keyed value) | [optional] 
**TableNameEx** | **string** | Event Stream table (standard two part name ex) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

