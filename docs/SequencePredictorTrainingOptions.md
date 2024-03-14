# Alterian.JA.Model.SequencePredictorTrainingOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelName** | **string** | Name for the generated model | [optional] 
**TrainingRatio** | **double?** | Percentage ratio of training examples to test examples | [optional] 
**EncodingPadMode** | **int?** | For shorter sequences, choose whether to pad with nulls on the left or right             1&#x3D;left padding,2&#x3D;right padding | [optional] 
**RandomSeed** | **int?** | Specify a random seed to initialise the random number generator with | [optional] 
**EmbeddingLayerSize** | **int?** | Defines the number of output nodes the embedding layer has - defaults to dictionary size (number of distinct event names + 2) | [optional] 
**LstmLayerSize** | **int?** | Defines the number of units used in the LSTM layer (long short term memory) | [optional] 
**NumberOfEpochs** | **int?** | Number of epochs that training will attempt (an epoch is an iteration of all training samples through the training process) | [optional] 
**BatchSize** | **int?** | Number of training samples to include in a single model update                          The batch size influences the performance of training at the expense of accuracy. A lower batch size may produce a more accurate model, but will training more slowly, a large batch size has the opposite affect | [optional] 
**CategoricalFeatures** | **List&lt;string&gt;** | Column names of any additional categorical features on the event stream table that are to be used in training e.g. Initiative (Location is implied) | [optional] 
**IsDataDebugRequired** | **bool** | Turn this on to leave intermediate tables in place for the purposes of debugging a model | [optional] 
**IsCombineCategoriesRequired** | **bool** | Turn this on to combine categorical features into a single composite state and avoid generating mutually exclusive combinations | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

