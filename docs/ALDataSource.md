# Alterian.JA.Model.ALDataSource
A data source is a pointer to a database. Therefore, it tells SDL Campaign Manager where the data contained in it should come from, either an Engine repository or an SQL database.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | Unique ID of the datasource | [optional] 
**Name** | **string** | Name of the datasource [must be unique] | [optional] 
**Enabled** | **bool** | Whether or not this datasource is enabled | [optional] 
**Visible** | **bool** | Whether or not this datasource is visible | [optional] 
**AccessView** | **bool** | Can the user view this datasource | [optional] 
**AccessModify** | **bool** | Not currently used | [optional] 
**Attributes** | [**List&lt;DatasourceAttribute&gt;**](DatasourceAttribute.md) | Attributes for this datasource.  @see(DatasourceAttribute) | [optional] 
**DatasourceTypeID** | **int** | @see(ALDataSourceType) of the datasource | [optional] 
**NameEx** | **string** | Full name of this datasource, in the pattern (datasource) | [optional] 
**Databases** | [**List&lt;ALDataSourceDatabase&gt;**](ALDataSourceDatabase.md) | @see(ALDataSourceDatabase)s for this datasource.  Not filled in unless you request the datasource to be fully populated | [optional] 
**LastRefresh** | **DateTime?** | Last date the structure of this datasource was refreshed against the underlying system. | [optional] 
**FullNativeName** | **string** | Name of this datasource | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

