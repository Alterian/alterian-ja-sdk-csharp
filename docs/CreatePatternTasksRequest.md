# Alterian.JA.Model.CreatePatternTasksRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsReplace** | **bool?** | When true, first request cancellation of any existing tasks which are dependent on any new of the new ones that have been submitted | [optional] 
**IsSynchronousExecution** | **bool?** | Process a short task synchronously and return the result. Currently only supported for Task &#39;Upload&#39; | [optional] 
**PatternId** | **int** | Pattern to run tasks against | [optional] 
**Tasks** | [**List&lt;PatternTaskType&gt;**](PatternTaskType.md) | Tasks to perform | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

