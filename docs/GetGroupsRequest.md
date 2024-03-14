# Alterian.JA.Model.GetGroupsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**FolderID** | **int?** | List groups in a particular folder, null if you want a list of all groups | [optional] 
**IncludeChildren** | **bool** | If a folder ID is provided, find any child folders and list the contents of those as well | [optional] 
**IncludeDisabled** | **bool** | Should the results also include groups which have the Enabled flag set to false? False by default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

