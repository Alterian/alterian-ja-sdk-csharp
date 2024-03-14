# Alterian.JA.Model.GetTokensRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientID** | **int?** | ClientID for which to list tokens.  If \&quot;Token\&quot; parameter is an SA token, \&quot;ClientID\&quot; is used; if the \&quot;Token\&quot; parameter is a regular token, the clientID of the token is used | [optional] 
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**IncludeNonUser** | **bool** | Include tokens which have no user set.  These types of tokens can&#39;t be used for the majority of API requests. | [optional] 
**IncludeSA** | **bool** | Include sa tokens in the returned list of tokens | [optional] 
**IncludeStandard** | **bool** | Include regular tokens in the returned list of tokens - - warning, this can be quite large | [optional] 
**IncludeStatic** | **bool** | Include static tokens in the returned list of tokens | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

