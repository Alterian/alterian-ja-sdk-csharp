# Alterian.JA.Model.APIMetadata
A class that contains information about the API itself in a format suitable for parsing by another application

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the method or class that the validation rules apply to | [optional] 
**ValidationRules** | **Dictionary&lt;string, string&gt;** | A list of name-object pairs. The name is the parameter (of the method) or property name (of the class), and the object is the list of @see(ValidationRule) rules that apply to it             Each rule has it&#39;s own type to determine how it is evaluated, but if they all pass then the data is valid. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

