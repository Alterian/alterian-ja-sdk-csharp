# Alterian.JA.Model.UpdateRepeatingPatternItemScoresRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DecodeId** | **int?** | Optional. Only required if the scores are to be recorded against a transform | [optional] 
**DecodeVersion** | **int?** | Optional. Only required if the scores are to be recorded against a transform | [optional] 
**Items** | **List&lt;string&gt;** | List of the sequence items to be re-scored | [optional] 
**PatternId** | **int** | Pattern Id | [optional] 
**ReplaceExistingScores** | **bool** | Defaults to False meaning that the update acts in a &#39;cursored&#39; mode - the UI can submit only the modified scores and any existing scores from the previous list version are preserved. When set to true then any existing scores are completely replaced | [optional] 
**Scores** | **List&lt;double&gt;** | List of the scores (must have a 1:1 relationship with Items) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

