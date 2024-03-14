# Alterian.JA.Model.RunSequencePredictorRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventStreamId** | **int** | Event Stream ID | [optional] 
**IsPublic** | **bool** | Set to true for a public model or prediction that should be shared across users. Set to false for the model and prediction to be associated with the token&#39;s user | [optional] 
**IsSynchronous** | **bool** | Set to false to run asynchronously. In this mode, the ProcessQueueId result property will be populated and can be passed to GetProcessStatus to check for completion | [optional] 
**ModelId** | **int?** | Specify this to use an existing model rather than training a new one | [optional] 
**PredictionOptions** | [**SequencePredictorPredictionOptions**](SequencePredictorPredictionOptions.md) |  | [optional] 
**PredictionSnapshotOptions** | [**ModelSnapshotOptions**](ModelSnapshotOptions.md) |  | [optional] 
**TrainingOptions** | [**SequencePredictorTrainingOptions**](SequencePredictorTrainingOptions.md) |  | [optional] 
**TrainingSnapshotOptions** | [**ModelSnapshotOptions**](ModelSnapshotOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

