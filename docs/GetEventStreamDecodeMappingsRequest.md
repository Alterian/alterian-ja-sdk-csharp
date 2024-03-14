# Alterian.JA.Model.GetEventStreamDecodeMappingsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseListId** | **int?** | Optionally base the decodes on a specified decode list subject to any explicitly specified overrides | [optional] 
**BaseListVersion** | **int?** | Optional list version (defaults to latest) | [optional] 
**ColumnName** | **string** | Column from the event stream to be decoded (defaults to Location) | [optional] 
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**DefaultLabel** | **string** | In conjunction with IsDefaultLabelConfigured this allows the API to override the default label from any specified base decode list. Pass NULL to remove an underlying list default and an empty string or space to override it to NULL | [optional] 
**EventDateTimeLower** | **DateTime?** | Start of the date window for column values to be displayed and decoded | [optional] 
**EventDateTimeUpper** | **DateTime?** | End of the date window for column values to be displayed and decoded | [optional] 
**EventStreamId** | **int** | Event Stream Id | [optional] 
**IncludeMappingsMissingFromSample** | **bool** | When set to true any decodes that have been configured but which do not appear in the sampled data will be included with a zero count | [optional] 
**IsDataRefreshRequired** | **bool** | Force the source labels to be refreshed from the event stream data | [optional] 
**IsDefaultLabelConfigured** | **bool?** | Set this to true if DefaultLabel is being used. If set to false then the default label will be determined by any specified base decode list | [optional] 
**SourceLabels** | **List&lt;string&gt;** | Specify any source labels that should be overriden on the specified base decode list | [optional] 
**SourceLabelSearch** | **string** | Filter the result by using search string against the source labels. Search term doesn not required wildcards and is currently case sensitive | [optional] 
**TargetLabelMatchList** | **List&lt;string&gt;** | Filter the result the specified target labels | [optional] 
**TargetLabels** | **List&lt;string&gt;** | Specify the target labels that should override the specified base decode list. Pass NULL to remove an underlying list decode or an empty string to override it to NULL. Pass a NULL list to remove mappings for all the specified source labels | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

