# Alterian.JA.Model.Permission

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Id of the permission | [optional] 
**Name** | **string** | Name of the permission | [optional] 
**Resource** | **ResourceType** |  | [optional] 
**ItemPermission** | **int?** | If this permission is applied to a folder, this is the permission id for the underlying item.  For instance, if the resource type is Folder and the permission is \&quot;View Document\&quot; [44], the ItemPermission will be 1 because that is the matching permission for the underlying resource for the folder. | [optional] 
**IsModify** | **bool** | Is the permission a \&quot;modify\&quot; type permission | [optional] 
**IsView** | **bool** | Is the permission a \&quot;view\&quot; type permission | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

