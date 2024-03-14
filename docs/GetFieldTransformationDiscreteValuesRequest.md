# Alterian.JA.Model.GetFieldTransformationDiscreteValuesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnNameEx** | **string** | Source column to which transforms should be applied | [optional] 
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**DataSourceId** | **int** | Id of the datasource to which column belongs. | [optional] 
**IsDataRefreshRequired** | **bool** | Indicate whether the request can be satisfied with an existing cached result or requires recreation with latest data (default false) | [optional] 
**JSONTransforms** | **string** | JSON array of transform to be applied e.g. [{{\\\&quot;FrequencyReplace\\\&quot;:{{\\\&quot;@minimum\\\&quot;:8035,\\\&quot;@replacement\\\&quot;:\\\&quot;My Replacement\\\&quot;}}}}]. Note that attributes must be prefixed with @ | [optional] 
**SampleSettings** | [**FieldTransformationSampleSettings**](FieldTransformationSampleSettings.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

