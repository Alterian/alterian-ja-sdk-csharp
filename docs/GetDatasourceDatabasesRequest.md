# Alterian.JA.Model.GetDatasourceDatabasesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**DatasourceID** | **int?** | Supply a datasource ID to filter the result to just the databases within this datasource. Ignore this parameter to fetch all databases. | [optional] 
**IncludeDisabled** | **bool** | Should disabled databases be included in the output?Default false | [optional] 
**IncludeInvisible** | **bool** | Should invisible databases be included in the output? Default false | [optional] 
**MinimalResults** | **bool** | Exclude attributes, etc. from the results | [optional] 
**NameFilter** | **string** | Optionally filter on the name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

