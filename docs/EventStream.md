# Alterian.JA.Model.EventStream

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**GroupId** | **int?** |  | [optional] 
**Name** | **string** |  | [optional] 
**DataSourceId** | **int** |  | [optional] 
**Table** | **string** | Returns back the full name of the table which stored the event stream information (includes the database name) | [optional] 
**NumRows** | **long** |  | [optional] 
**IsFIFO** | **bool** |  | [optional] 
**Keys** | [**List&lt;EventStreamKey&gt;**](EventStreamKey.md) |  | [optional] 
**Models** | [**List&lt;EventStreamModel&gt;**](EventStreamModel.md) |  | [optional] 
**DDEQueueName** | **string** |  | [optional] 
**DDESiteId** | **int** |  | [optional] 
**CreationDate** | **DateTime** |  | [optional] 
**QueueLockId** | **Guid** |  | [optional] 
**DatabaseName** | **string** |  | [optional] 
**DDEClient** | **string** |  | [optional] 
**DDETarget** | **string** |  | [optional] 
**Fields** | [**List&lt;EventStreamField&gt;**](EventStreamField.md) |  | [optional] 
**Patterns** | [**List&lt;Pattern&gt;**](Pattern.md) |  | [optional] 
**Status** | **int** | Quick status on the stream.  Currently 0 &#x3D; created, -1 means there is a problem and 1 means the stream is pulling data | [optional] 
**QueueURL** | **string** | URL for the queue, based upon your DDE instance details | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

