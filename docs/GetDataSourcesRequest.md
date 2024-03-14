# Alterian.JA.Model.GetDataSourcesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**DatasourceTypeID** | **int?** | Include only datasources of this type | [optional] 
**FullyPopulate** | **bool** | Fully populate the datasource structure - - including databases, tables and columns.  For complicated structures, this might take a while to invoke. | [optional] 
**IncludeDisabled** | **bool** | Include disabled datasources in the list [default is to not include] | [optional] 
**IncludeInvisible** | **bool** | Include invisible datasources in the list [default is to not include] | [optional] 
**MinimalResults** | **bool** | Exclude attributes, etc. from the results | [optional] 
**NameFilter** | **string** | Optionally filter on the name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

