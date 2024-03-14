# Alterian.JA.Model.EMDownloadMapping
Provides a download mapping into the EM system to a specific EM client and user

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | Unique ID of this mapping | [optional] 
**Name** | **string** | Name of this mapping | [optional] 
**KeyColumnId** | **int?** | Key column Id associated with this client | [optional] 
**KeyColumnNameEx** | **string** | Key column NameEx - readonly | [optional] 
**ResponseTable** | **string** | Name of the response table | [optional] 
**ContactTable** | **string** | Name of the contact table | [optional] 
**EMPrimarykeyId** | **int?** | Primary key for EM to which this EM Client is mapped | [optional] 
**EMUNCOutputLocation** | **string** | UNC path for hosted EM\\CM systems | [optional] 
**EMPrimaryKeyType** | **int** | EM&#39;s primary key type | [optional] 
**DatasourceId** | **int?** | Datasource Id associated with this client | [optional] 
**EMClient** | [**EMClient**](EMClient.md) |  | [optional] 
**EMClientID** | **int** | EM Client ID of this mapping | [optional] 
**DatasourceName** | **string** | Datasource Name - readonly | [optional] 
**OwnerID** | **int** | The owner\\creator of this EMMapping | [optional] 
**CanEdit** | **int** | Does the Mapping have edit permissions for this user - cannot set this value using this property | [optional] 
**IsEnabled** | **bool** | Is mapping enabled | [optional] 
**EmPrimaryKeyName** | **string** | EM Primary Key Name | [optional] 
**GDCTable** | **string** | Name of the table which will store data collection information for this primary key | [optional] 
**PreferencesTable** | **string** | Name of the table which will store Preference OptIn\\OptOut data | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

