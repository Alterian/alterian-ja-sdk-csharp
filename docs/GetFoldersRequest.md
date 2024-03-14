# Alterian.JA.Model.GetFoldersRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**FolderType** | **FolderTypes** |  | [optional] 
**GetChildFolders** | **bool** | Return back the children of the folders [recursively] | [optional] 
**IncludeChildCount** | **bool** | If GetChildFolders is set to false then this option can be user to get a count of the immediate children of each returned folder. | [optional] 
**IncludeHidden** | **bool** | Include hidden folders in your result | [optional] 
**ParentFolder** | **int?** | Parent folder to start looking for folders | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

