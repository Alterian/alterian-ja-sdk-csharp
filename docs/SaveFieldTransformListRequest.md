# Alterian.JA.Model.SaveFieldTransformListRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Optional ID for use when creating a new version of an existing transform list | [optional] 
**JSONTransforms** | **string** | Assumed to be a JSON array of single level objects e.g. [{{\\\&quot;FrequencyReplace\\\&quot;:{{\\\&quot;@minimum\\\&quot;:8035,\\\&quot;@replacement\\\&quot;:\\\&quot;My Replacement\\\&quot;}}}}]. Note that attributes must be prefixed with @ | [optional] 
**Metadata** | **string** | JSON Blob used by the UI to store sampling settings / screen layout when editing the transform | [optional] 
**Name** | **string** | Name of the list (required for new lists) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

