# Alterian.JA.Model.ALPermission
This represents a particular permission which is applied [either via inheritance or diretly] to a user.  A user may inherit permissions from folders or group membership.  Anything which has not been granted in some manner will be denied by default.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | The ID of the permission. (What right is being allowed or denied?) | [optional] 
**Value** | **ALPermissionFlag** |  | [optional] 
**Name** | **string** | The name of the permission | [optional] 
**Source** | **PermissionSource** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

