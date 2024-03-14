# Alterian.JA.Model.GetDatasourceColumnsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**IncludeDisabled** | **bool** | Should disabled columns be included in the output?Default false | [optional] 
**IncludeInvisible** | **bool** | Should invisible columns be included in the output? Default false | [optional] 
**MinimalResults** | **bool** | Exclude attributes, etc. from the results | [optional] 
**NameFilter** | **string** | Optionally filter on the name | [optional] 
**TableID** | **int?** | Supply a table ID to filter the result to just the columns within this table. Ignore this parameter to fetch all columns, which can be very slow. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

