# Alterian.JA.Model.CreateClientRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientName** | **string** | The name of the new client. Method will fail if this client name already exists within the specified @see(ALClientSet) | [optional] 
**ClientSetID** | **int** | The identifier of the @see(ALClientSet) that this client will be created within. Method will fail if this clientset cannot be found | [optional] 
**DatabaseName** | **string** | The name of the SQLServer database that this client will create. Method will fail if this database already exists on the specified database server ID.  May only be 50 characters long and must not start with a number nor have special characters | [optional] 
**DatabaseServerID** | **int** | The identifier of the database server that the database will be created within. Method will fail if this database server cannot be found | [optional] 
**SourceClientID** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

