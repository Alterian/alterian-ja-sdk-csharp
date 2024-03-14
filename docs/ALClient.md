# Alterian.JA.Model.ALClient
A client represents a distinct set of users, documents and other data within a system.              Users and documents are unique within a client, and are isolated from other clients, so they cannot be shared between clients (except manually by export and import)             Note that multiple clients can use the same customer data by each creating a @see(ALDataSource) to the same customer database.             Each customer will typically have one client, but some large customers may have multiple clients             Each client has it's own SQLServer database to store information in.                The data is returned as a @see(ALClient) object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | The ID of the client. | [optional] 
**Name** | **string** | The name of the client. | [optional] 
**Enabled** | **bool** |  | [optional] 
**Settings** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Packages** | [**List&lt;Package&gt;**](Package.md) |  | [optional] 
**ClientSetID** | **int** |  | [optional] 
**SiteId** | **Guid** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

