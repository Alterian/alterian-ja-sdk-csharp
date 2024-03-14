# Alterian.JA.Model.ALDataSourceColumn
Contains information about a database column.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | Unique ID of the datasource | [optional] 
**Name** | **string** | Name of the datasource [must be unique] | [optional] 
**NameEx** | **string** | Full name of this column, which includes in the datasource and the native name for the column in the pattern (datasource).[database].[table].[column] | [optional] 
**Enabled** | **bool** | Whether or not this datasource is enabled | [optional] 
**Visible** | **bool** | Whether or not this datasource is visible | [optional] 
**AccessView** | **bool** | Can the user view this datasource | [optional] 
**AccessModify** | **bool** | Not currently used | [optional] 
**Attributes** | [**List&lt;DatasourceAttribute&gt;**](DatasourceAttribute.md) | Attributes for this datasource.  @see(DatasourceAttribute) | [optional] 
**TableID** | **int** |  | [optional] 
**DatasourceId** | **int** |  | [optional] 
**NativeName** | **string** | The fully qualified name as used by the underlying datasource type. | [optional] 
**AlchemyFieldTypeID** | **int** | What type of data is contained within the column? Call @see(GetDatasourceFieldTypes) to fetch the mappings between this Type ID and name | [optional] 
**DatasourceTypeID** | **int** | What kind of datasource is this a column from?  See @see(GetDataSourceTypes) to fetch a list of the available datasource types. | [optional] 
**FullNativeName** | **string** | The entire native name of this item - - usually includes database, table and column name | [optional] 
**Precision** | **int** | If the column is a real type, this will be the precision, otherwise, it is meaningless | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

