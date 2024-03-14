# Alterian.JA.Model.EMUploadMapping
Provides an upload mapping into the EM system to a specific EM client and user

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | Unique ID of this mapping | [optional] 
**Name** | **string** | Name of this mapping | [optional] 
**FolderID** | **int?** | Folder in which this mapping is located | [optional] 
**EMUserID** | **int** | EM User ID of this mapping | [optional] 
**Created** | **DateTime** | Date that this mapping was created | [optional] 
**Modified** | **DateTime** | Date that this mapping was last modified | [optional] 
**OwnerID** | **int** | The owner\\creator of this EMMapping | [optional] 
**EMUserName** | **string** | A cache of the user name which maps to the EMUserID on the EM side. | [optional] 
**CanEdit** | **int** | Does the Mapping have edit permissions for this user - cannot set this value using this property | [optional] 
**EMClient** | [**EMClient**](EMClient.md) |  | [optional] 
**EMClientID** | **int** | EM Client ID of this mapping | [optional] 
**IsEnabled** | **bool** | Is mapping enabled | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

