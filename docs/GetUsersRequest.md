# Alterian.JA.Model.GetUsersRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**FolderID** | **int?** | Optionally get just the users in this folder. Provide NULL to list all users, but see IncludeChildren below | [optional] 
**GroupID** | **int?** | Optionally get just the users in this group. Provide NULL to list all users | [optional] 
**IncludeChildren** | **bool** | If a folderID is supplied, show users in the supplied folder and all its subfolders. If a folderID is not supplied, show all users in all folders (true), or no folders (false) | [optional] 
**IncludeDisabled** | **bool** | Include disabled users in the result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

