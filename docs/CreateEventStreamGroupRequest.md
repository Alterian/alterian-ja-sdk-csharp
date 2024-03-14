# Alterian.JA.Model.CreateEventStreamGroupRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DDEClient** | **string** | Client in DDE in which you would like to create the event stream | [optional] 
**DDESiteId** | **int** | An integer uniquely identifying the DDE system.  This site id is provided when it has been added via the SysAdminApp&#39;s AddDDESite command. | [optional] 
**EventStreamDatabase** | **string** | Name of the engine database into which to place the event stream data | [optional] 
**IsFifoQueueRequired** | **bool** | (default false) | [optional] 
**Name** | **string** | Name of the event stream you would like to create | [optional] 
**Project** | **string** | Engine project into which to place the Event tables | [optional] 
**QueueLockIds** | **List&lt;string&gt;** | If the event stream is to be attached to an existing set of queues then the lock ids must be specified (in any order). This pre-supposes that any existing consumer event streams have been deleted/disconnected | [optional] 
**Server** | **string** | Engine server on which to install the Event tables | [optional] 
**SkipDefaultQueueSetup** | **bool** | If this is true then the AlterianCX_defaultQueue global parameter will not be set (default false) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

