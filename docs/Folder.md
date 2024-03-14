# Alterian.JA.Model.Folder
A folder is a logical container for items which match the foldertype.  All folders have security applied to them, with the exception of @see(ALUser) and @see(ALUserGroup) folders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | ID of the folder; always unique | [optional] 
**Name** | **string** | Name of the folder; only unique within a ParentID and FolderType | [optional] 
**SubFolders** | [**List&lt;Folder&gt;**](Folder.md) | GUI helper property; not filled in by the API | [optional] 
**Items** | **List&lt;Object&gt;** | GUI helper property; not filled in by the API | [optional] 
**VarSystem** | **bool** | Is this a system folder?  You can&#39;t delete system folders | [optional] 
**ParentID** | **int?** | Parent of this folder; null means it is a root folder | [optional] 
**AccessView** | **bool** | Can the user view this folder | [optional] 
**AccessModify** | **bool** | Can the user modify this folder in some way [rename, etc.] | [optional] 
**OwnerID** | **int** | The owner of this folder.  This typically starts out as the creator of the folder. | [optional] 
**Hidden** | **bool** | Has this folder been flagged as \&quot;hidden\&quot; | [optional] 
**AncestorFolderIDs** | **List&lt;int&gt;** | The ids of all the folders under the root that are ancestors of this one, ordered from parent to child             Only populated by the GetFolder API | [optional] 
**ChildCount** | **int** | Count of the folders immediate children | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

