# Alterian.JA.Model.OpportunityMatrix
A Data transfer object (DTO) to move information about campaigns within the opportunity matrix to and from the UI             We will have one of these instances for each cell in the matrix that contains a campaign             At time of writing, we will always get and update the entire list of Opportunity Matrix elements in one go

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessGoalID** | **int** | The Id of the story that this campaign is appearing in. Basically the Y coordinate of the matrix             If the Story has been deleted then the UI will not display this campaign | [optional] 
**OpportunityID** | **int** | The Id of the opportunity that this campaign is appearing in. Basically the X coordinate of the matrix             If the Opportunity has been deleted then the UI will not display this campaign | [optional] 
**DocumentID** | **int** | The id of the campaign document that is referenced in the cell. Required when updating | [optional] 
**CampaignName** | **string** | The name of the campaign in this cell. Read only, provided as a convenience for populating the Opportunity matrix UI | [optional] 
**CampaignDescription** | **string** | The description of the campaign in this cell. Read only, provided as a convenience for populating the Opportunity matrix UI | [optional] 
**Author** | **string** | The Author of the campaign in this cell. Read only, provided as a convenience for populating the Opportunity matrix UI | [optional] 
**LastUpdated** | **DateTime** | The Date/Time the campaign was last updated. Read only, provided as a convenience for populating the Opportunity matrix UI | [optional] 
**SubType** | **string** | What kind of thing is this? Used to distinguish between Silverlight campaigns (&#x3D;\&quot;Campaign\&quot;) and Campaign360 (&#x3D;\&quot;Campaign.BuildACampaign\&quot;) objects when deeplinking | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

