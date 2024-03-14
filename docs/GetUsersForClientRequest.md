# Alterian.JA.Model.GetUsersForClientRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **int** | ClientId for which you would like to see users. | [optional] 
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**FolderId** | **int?** | Optionally get just the users in this folder. Provide NULL to list all users, but see IncludeChildren below | [optional] 
**GroupId** | **int?** | Optionally get just the users in this group. Provide NULL to list all users | [optional] 
**IncludeChildren** | **bool** | If a folderID is supplied, show users in the supplied folder and all its subfolders. If a folderID is not supplied, show all users in all folders (true), or no folders (false) | [optional] 
**IncludeDisabled** | **bool** | Include disabled users in the result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

