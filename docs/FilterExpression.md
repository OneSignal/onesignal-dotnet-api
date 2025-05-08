# OneSignalApi.Model.FilterExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Required. Name of the field to use as the first operand in the filter expression. | [optional] 
**Key** | **string** | If &#x60;field&#x60; is &#x60;tag&#x60;, this field is *required* to specify &#x60;key&#x60; inside the tags. | [optional] 
**Value** | **string** | Constant value to use as the second operand in the filter expression. This value is *required* when the relation operator is a binary operator. | [optional] 
**HoursAgo** | **string** | If &#x60;field&#x60; is session-related, this is *required* to specify the number of hours before or after the user&#39;s session. | [optional] 
**Radius** | **decimal** | If &#x60;field&#x60; is &#x60;location&#x60;, this will specify the radius in meters from a provided location point. Use with &#x60;lat&#x60; and &#x60;long&#x60;. | [optional] 
**Lat** | **decimal** | If &#x60;field&#x60; is &#x60;location&#x60;, this is *required* to specify the user&#39;s latitude. | [optional] 
**Long** | **decimal** | If &#x60;field&#x60; is &#x60;location&#x60;, this is *required* to specify the user&#39;s longitude. | [optional] 
**Relation** | **string** | Required. Operator of a filter expression. | [optional] 
**Operator** | **string** | Strictly, this must be either &#x60;\&quot;OR\&quot;&#x60;, or &#x60;\&quot;AND\&quot;&#x60;.  It can be used to compose Filters as part of a Filters object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

