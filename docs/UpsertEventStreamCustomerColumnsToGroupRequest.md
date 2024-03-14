# Alterian.JA.Model.UpsertEventStreamCustomerColumnsToGroupRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fields** | [**List&lt;EventStreamCustomerField&gt;**](EventStreamCustomerField.md) | A list of @see(EventStreamCustomerField) instances to upsert | [optional] 
**GroupId** | **int** | Id of the group of event streams you want to update, obtained via @see(GetEventStreams) | [optional] 
**KeyColumnName** | **string** | In your list of columns, you must specify which column contains the key field for your customer (for instance, email address).  If you do not, the loader rule created will expect a cxid to be provided | [optional] 
**PersonaColumnName** | **string** | If your data is going to have persona data, specify the column which holds the persona information.  Note that personas must be separated by a pipe character if there are multiples | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

