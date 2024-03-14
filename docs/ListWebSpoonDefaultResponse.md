# Alterian.JA.Model.ListWebSpoonDefaultResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusCode** | **string** | A string constant representing the success or failure of the method call. See the status codes table below. | [optional] 
**DebugMessage** | **string** | By default, an empty array []. Internal debug messages can be exposed by changing a configuration setting on the server, but be aware that this can leak internal implementation details such as stack calls or method names to the caller. | [optional] 
**Detail** | **List&lt;List&lt;string&gt;&gt;** | Optionally return additional information about this API call             This will typically contain the reason WHY a method failed (if it fails), warnings if success, and other bits of data that             are NOT part of the main result. | [optional] 
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**Result** | [**List&lt;WebSpoonStatus&gt;**](WebSpoonStatus.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

