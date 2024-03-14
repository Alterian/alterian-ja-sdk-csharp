# Alterian.JA.Model.CMTokenInformation
Definition of a token for the CM system.  A token is a GUID which is passed to ALL calls into CM and this token typically has a @see(ALUser) assigned to it to enforce permissions.  Some methods require an SA [system admin] token to call.             Those calls which have permissions MUST have a user token provided.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | Internal ID of the token | [optional] 
**LoginID** | **Guid?** | Authentication system&#39;s login ID for this token [if applicable] | [optional] 
**Token** | **Guid** | Actual GUID of the token.  This is what you would use to pass to API methods. | [optional] 
**TimezoneID** | **int?** | Timezone of the user associated with this token | [optional] 
**UserID** | **int?** | User associated with this token | [optional] 
**ClientID** | **int?** | Client associated with this token | [optional] 
**LastActivity** | **DateTime** | Last time this token was actually used for something | [optional] 
**Created** | **DateTime** | When this token was created | [optional] 
**Culture** | **string** | The culture of the user associated with this token | [optional] 
**IsStatic** | **bool** | Is this token a static token?  If so, it won&#39;t be purged as part of the normal purge process | [optional] 
**IsSAtoken** | **bool** | Is this an SA token?  If so, it will have access to more system admin functions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

