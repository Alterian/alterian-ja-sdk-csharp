# Alterian.JA.Model.SaveDecodeListRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CopyVersion** | **int?** | When CreateCopy is true provides a version to copy from (or latest if set to NULL) | [optional] 
**CreateCopy** | **bool?** | When false allows rename for an existing list Id. When true provides &#39;Save As&#39; functionality for the specified source id (a new name must be supplied) - note that ReplaceExisting determines whether any saved labels are copied across from the source | [optional] 
**DefaultLabel** | **string** | Optional default label to be applied for any non-matched source labels. Note that the distinction between NULL and empty string is significant - NULL means remove the current default, Empty string causes existing value to be replace with empty string (&#x3D;&#x3D;NULL in Engine) | [optional] 
**Id** | **int?** | Optional ID for use when updating an existing decode list | [optional] 
**Metadata** | **string** | JSON Blob used by the UI to store sampling settings / screen layout when editing the transform | [optional] 
**Name** | **string** | Optional Name of the decode list (required for new lists) | [optional] 
**ReplaceExisting** | **bool?** | Defaults to False meaning that the update acts in a &#39;cursored&#39; mode - the UI can submit only the deltas and any existing decodes from the previous list version are preserved. When set to true then any existing decodes are completely replaced | [optional] 
**SourceLabels** | **List&lt;string&gt;** | Source labels to be decoded. To map from NULL use empty string or NULL | [optional] 
**TargetLabels** | **List&lt;string&gt;** | Decoded versions of the source labels. Note that the distinction between NULL and empty string is significant - NULL means remove any existing decode (default will still apply), Empty string causes existing value to be replace with empty string (&#x3D;&#x3D;NULL in Engine) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

