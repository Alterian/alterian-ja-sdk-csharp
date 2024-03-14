# Alterian.JA.Model.ALDataSourceDatabase
Represents a database in the system, which is a collection of tables.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | Unique ID of the datasource | [optional] 
**Name** | **string** | Name of the datasource [must be unique] | [optional] 
**NameEx** | **string** | Full name of this database, which includes in the datasource and the native name for the database in the pattern (datasource).[database] | [optional] 
**Enabled** | **bool** | Whether or not this datasource is enabled | [optional] 
**Visible** | **bool** | Whether or not this datasource is visible | [optional] 
**AccessView** | **bool** | Can the user view this datasource | [optional] 
**AccessModify** | **bool** | Not currently used | [optional] 
**Attributes** | [**List&lt;DatasourceAttribute&gt;**](DatasourceAttribute.md) | Attributes for this datasource.  @see(DatasourceAttribute) | [optional] 
**DataSourceID** | **int** | The ID of the datasource that this database belongs to. | [optional] 
**NativeName** | **string** | The fully qualified name as used by the underlying datasource type. | [optional] 
**Tables** | [**List&lt;ALDataSourceTable&gt;**](ALDataSourceTable.md) |  | [optional] 
**DatasourceTypeID** | **int** | What kind of datasource is this a database from?  See @see(GetDataSourceTypes) to fetch a list of the available datasource types. | [optional] 
**FullNativeName** | **string** | Full native name for this; since this is a database, just returns the name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

