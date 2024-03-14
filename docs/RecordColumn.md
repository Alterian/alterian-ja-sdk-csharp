# Alterian.JA.Model.RecordColumn
Structure for holding the basic column information for a record

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Handle** | **int** | The Engine Handle | [optional] 
**NameEx** | **string** | The NameEx | [optional] 
**Name** | **string** | The Short Name | [optional] 
**Description** | **string** | The Description | [optional] 
**Type** | **string** | The column type expressed as a textual description (as per Engine sheet) | [optional] 
**DataType** | **ColumnDataType** |  | [optional] 
**IsIndexed** | **bool** |  | [optional] 
**IsSortable** | **bool** | Flag indicating if the column is sortable | [optional] 
**Width** | **int** | Current maximum width of this column. | [optional] 
**RecordCount** | **long** | The total number of records in this column | [optional] 
**Precision** | **int?** | Precision of this column, if it is a decimal type | [optional] 
**Snapshot** | **bool** | Is this column a snapshotted column? | [optional] 
**DeleteOnDataChange** | **bool** | Will this column get deleted on data change? | [optional] 
**NumberofNulls** | **long** | The number of nulls in this column; if the column is engineered, etc. and has not been calculated, this will be -1 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

