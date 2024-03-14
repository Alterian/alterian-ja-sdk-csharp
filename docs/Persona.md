# Alterian.JA.Model.Persona
Provides data about a specific persona.               https://alterian.atlassian.net/l/cp/kQa2X8yb

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal identifier for the persona | [optional] 
**Icon** | **string** | Icon | [optional] 
**Name** | **string** | Name of the persona | [optional] 
**Created** | **DateTime** | Date the persona was created | [optional] 
**Modified** | **DateTime** | Date the persona was last modified | [optional] 
**Description** | **string** | Description for the persona | [optional] 
**Hidden** | **bool** | Should this Persona be hidden by default in the UI (as an alternative to deleting it) | [optional] 
**Links** | [**List&lt;PersonaLink&gt;**](PersonaLink.md) | Provides a link to other objects which this persona is being linked to (eg. playbooks, etc.) | [optional] 
**UsageCounter** | **int** | As events flow through the system, if this persona is detected in the inbound event stream, the usage counter will be incremented.  Note that this             will not be exact but will get an approximation on how often the persona is being used.  Personas which are manually added start with a usage of zero.             Anything with a value greater than zero means that it has been seen in inbound events. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

