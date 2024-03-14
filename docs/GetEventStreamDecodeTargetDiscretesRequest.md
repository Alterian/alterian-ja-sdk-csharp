# Alterian.JA.Model.GetEventStreamDecodeTargetDiscretesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseListId** | **int?** | Optionally base the decodes on a specified decode list subject to any explicitly specified overrides | [optional] 
**BaseListVersion** | **int?** | Optional list version (defaults to latest) | [optional] 
**ColumnName** | **string** | Column from the event stream to be decoded (defaults to Location) | [optional] 
**DefaultLabel** | **string** | In conjunction with IsDefaultLabelConfigured this allows the API to override the default label from any specified base decode list. Pass NULL to remove an underlying list default and an empty string or space to override it to NULL | [optional] 
**EventDateTimeLower** | **DateTime?** | Start of the date window for column values to be displayed and decoded | [optional] 
**EventDateTimeUpper** | **DateTime?** | End of the date window for column values to be displayed and decoded | [optional] 
**EventStreamId** | **int** | Event Stream Id | [optional] 
**IsDataRefreshRequired** | **bool** | Force the source labels to be refreshed from the event stream data | [optional] 
**IsDefaultLabelConfigured** | **bool?** | Set this to true if DefaultLabel is being used. If set to false then the default label will be determined by any specified base decode list | [optional] 
**SourceLabels** | **List&lt;string&gt;** | Specify any source labels that should be overriden on the specified base decode list | [optional] 
**TargetLabels** | **List&lt;string&gt;** | Specify the target labels that should override the specified base decode list. Pass NULL to remove an underlying list decode or an empty string to override it to NULL. Pass a NULL list to remove mappings for all the specified source labels | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

