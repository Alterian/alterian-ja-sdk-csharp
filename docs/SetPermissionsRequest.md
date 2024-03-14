# Alterian.JA.Model.SetPermissionsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsGroup** | **bool** | Is the security ID a group or a person? | [optional] 
**ItemID** | **int** | ID of the item on which to set permissions. This is NOT globally unique which is why you need to specify the ItemType. | [optional] 
**ItemType** | **ResourceType** |  | [optional] 
**Permissions** | [**List&lt;ALPermission&gt;**](ALPermission.md) | Which permissions are being assigned or removed? And is an assigned permission being Allowed or Denied? | [optional] 
**SecurityID** | **int** | User or Group ID of which to set the permissions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

