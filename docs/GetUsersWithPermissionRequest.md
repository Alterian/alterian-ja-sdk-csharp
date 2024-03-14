# Alterian.JA.Model.GetUsersWithPermissionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**GroupID** | **int?** | Optionally restrict the check to users that are members of the specified group (either directly or by inclusion in a member group - see IsMemberGroupRecursionAllowed) | [optional] 
**IsMemberGroupRecursionAllowed** | **bool?** | Where restricting the check to users that are members of the specified group set to false to require direct membership or true to allow inclusion in one of its member groups | [optional] 
**PermissionID** | **int** | ID of the permission to check | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

