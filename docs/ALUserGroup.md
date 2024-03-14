# Alterian.JA.Model.ALUserGroup
A user is a unique profile of permissions and linked to a set of user login credentials. When a user logs in using those credentials, the permissions in the user profile are applied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Enabled** | **bool** |  | [optional] 
**Created** | **DateTime?** |  | [optional] 
**Modified** | **DateTime?** |  | [optional] 
**FolderID** | **int** |  | [optional] 
**Members** | **List&lt;Object&gt;** | A list that can contain the groups or users that are immediate children of this group. I contain them. | [optional] 
**Groups** | [**List&lt;ALUserGroup&gt;**](ALUserGroup.md) | The groups that are immediate parents of this group. They contain me. | [optional] 
**FolderName** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

