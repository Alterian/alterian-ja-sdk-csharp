# Alterian.JA.Model.Opportunity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | ID of the opportunity as stored in the database | [optional] 
**Name** | **string** | The (arbitrary) name of the Opportunity as decided by the marketer | [optional] 
**Description** | **string** | A desciption of the Opportunity to explain it&#39;s purpose to the user | [optional] 
**Group** | **string** | Group Name used to give some structure to the Opportunities within the Matrix - this should probably be an ID to another table but meh! | [optional] 
**Colour** | **string** | Let&#39;s liven things up with a bit of colour | [optional] 
**Icon** | **string** | Icon for quick reference and to make the grid look a bit more shiny | [optional] 
**Items** | [**List&lt;OpportunityItem&gt;**](OpportunityItem.md) | List of the associated items (i.e. Campaigns / Journeys) linked to this Opportunity | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

