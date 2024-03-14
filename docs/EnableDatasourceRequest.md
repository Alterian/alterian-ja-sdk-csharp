# Alterian.JA.Model.EnableDatasourceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatasourceId** | **int** | The id of the datasource that you want to enable. | [optional] 
**Refresh** | **bool** | pass True if you would like the datasource cache to be updated with a new structure or new data based upon a dataload.  Setting this to True will ask the engine listener service to refresh this datasource in the next polling cycle.  It make take several minutes for the refresh to happen.  You can call @see(GetDatasource) to get the last refresh date and see if it has happened successfully. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

