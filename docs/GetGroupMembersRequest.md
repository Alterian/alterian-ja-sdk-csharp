# Alterian.JA.Model.GetGroupMembersRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**GroupID** | **int** | ID of the group to get membership | [optional] 
**IncludeGroups** | **bool** | Should the results also include the members of the groups? Default false | [optional] 
**IncludeUsers** | **bool** | Should the results also include the users within this group? Default false | [optional] 
**Inverse** | **bool** | Include FALSE to return back the users and groups which are in the group ID provided; Sent TRUE to get a list of users and groups which are NOT in the group selected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

