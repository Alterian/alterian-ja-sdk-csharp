# Alterian.JA.Model.ALDataSourceTable
Contains information about a database table.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | Unique ID of the datasource | [optional] 
**Name** | **string** | Name of the datasource [must be unique] | [optional] 
**NameEx** | **string** | Full name of this table, which includes in the datasource and the native name for the table in the pattern (datasource).[database].[table] | [optional] 
**Enabled** | **bool** | Whether or not this datasource is enabled | [optional] 
**Visible** | **bool** | Whether or not this datasource is visible | [optional] 
**AccessView** | **bool** | Can the user view this datasource | [optional] 
**AccessModify** | **bool** | Not currently used | [optional] 
**Attributes** | [**List&lt;DatasourceAttribute&gt;**](DatasourceAttribute.md) | Attributes for this datasource.  @see(DatasourceAttribute) | [optional] 
**DatabaseID** | **int** | The ID of the database that this table belongs to. | [optional] 
**NativeName** | **string** | The fully qualified name as used by the underlying datasource type. | [optional] 
**Columns** | [**List&lt;ALDataSourceColumn&gt;**](ALDataSourceColumn.md) |  | [optional] 
**DatasourceTypeID** | **int** | What kind of datasource is this a table from?  See @see(GetDataSourceTypes) to fetch a list of the available datasource types. | [optional] 
**PrimaryKey** | [**ALDatasourcePrimaryKey**](ALDatasourcePrimaryKey.md) |  | [optional] 
**ResolverTableID** | **int?** |  | [optional] 
**Joins** | [**List&lt;ALDatasourceJoin&gt;**](ALDatasourceJoin.md) | List which columns are part of any defined join between this table and linked tables. | [optional] 
**Links** | [**List&lt;ALDatasourceLink&gt;**](ALDatasourceLink.md) | What other tables can this table be linked to? | [optional] 
**FullNativeName** | **string** | The entire native name of this item - - usually includes database and table | [optional] 
**DatasourceId** | **int** | ID of the Datasource | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

