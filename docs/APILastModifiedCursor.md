# Alterian.JA.Model.APILastModifiedCursor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastModified** | **DateTime** | Indicates when the data structure last changed | [optional] 
**From** | **int?** | What is the first result that should be returned? Note that this is 0-based (0 is the very first row). If this value is not supplied then 0 is assumed. | [optional] 
**To** | **int?** | What is the last result that should be returned? If this value is not supplied then all results are assumed. It is safe to provide a number that is larger than the total number of results.             available. | [optional] 
**Total** | **long?** | How many results are available in total? This is not used when passing the cursor to a method; it is populated (read only) when the cursor is returned from any method that uses a cursor. | [optional] 
**SortDescending** | **bool?** | If we want to sort the resulting list, do we want it sorted in descending order?  The default is ascending. | [optional] 
**SortProperty** | **string** | Property on the object by which you would like to sort.  If an invalid or null property is provided, default sorting will be applied as defined in each API method. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

