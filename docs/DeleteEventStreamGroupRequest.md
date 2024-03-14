# Alterian.JA.Model.DeleteEventStreamGroupRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteDDEGlobalParameters** | **bool** | Use this to delete any global parameters set up in DDE to reference queues. Only do this if this is the &#39;default queue&#39; | [optional] 
**DeleteDDEQueue** | **bool** | Pass true if you would like to delete the queue in DDE; note, if this queue is in use in a rule, the rule will fail. | [optional] 
**GroupId** | **int** |  | [optional] 
**PurgeDDEQueue** | **bool** | The deletion of the queue in DDE will fail if the queue is not empty; pass true if you want to purge the queue first | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

