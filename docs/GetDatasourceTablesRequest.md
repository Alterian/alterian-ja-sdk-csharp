# Alterian.JA.Model.GetDatasourceTablesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | [**APICursor**](APICursor.md) |  | [optional] 
**DatabaseID** | **int?** | Supply a database ID to filter the result to just the tables within this database. Ignore this parameter to fetch all tables, which can be slow. | [optional] 
**IncludeDisabled** | **bool** | Should disabled tables be included in the output?Default false | [optional] 
**IncludeInvisible** | **bool** | Should invisible tables be included in the output? Default false | [optional] 
**IncludeJoins** | **bool** | Should joined table information be included in the output? Default false, as this can be large | [optional] 
**IncludeLinks** | **bool** | Should linked table information be included in the output? Default false, as this can be large | [optional] 
**MinimalResults** | **bool** | Exclude attributes, etc. from the results | [optional] 
**NameFilter** | **string** | Optionally filter on the name | [optional] 
**ResolutionTableID** | **int?** | Optionally filter to include only those results that can be directly resolved to the specified table (i.e those that are 1:1 or *:1 joined such that there is a maximum of one linked candidate row per resolution row | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

