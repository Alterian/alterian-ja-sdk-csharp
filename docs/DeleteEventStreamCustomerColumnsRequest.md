# Alterian.JA.Model.DeleteEventStreamCustomerColumnsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldNames** | **List&lt;string&gt;** | A list of @see(EventStreamCustomerField) names to remove from the event stream | [optional] 
**Id** | **int** | Id of the event stream from which you wish to delete the attribute data | [optional] 
**KeyColumnName** | **string** | In your list of columns, you must specify which column contains the key field for your customer (for instance, email address).  If you do not, the loader rule created will expect a cxid to be provided | [optional] 
**PersonaColumnName** | **string** | If your data is going to have persona data, specify the column which holds the persona information.  Note that personas must be separated by a pipe character if there are multiples | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

