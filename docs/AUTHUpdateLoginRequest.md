# Alterian.JA.Model.AUTHUpdateLoginRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalAuthentication** | **bool** | True if you want this login to use external authentication [NT, SAML] | [optional] 
**LoginId** | **Guid** | Id of the login | [optional] 
**Name** | **string** | Login name | [optional] 
**NewPassword** | **string** | If you want to change the password, provide it here.  If ExternalAuth is true, this is ignored.  It must pass the password complexity rules. | [optional] 
**SiteId** | **int** | Id of the CM Site (typically 1) | [optional] 
**UserId** | **int?** | User Id to associate with the login.  Pass NULL to disassociate the login with a user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

