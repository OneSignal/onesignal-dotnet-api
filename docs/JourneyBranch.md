# OneSignalApi.Model.JourneyBranch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Server-assigned branch identifier. Read-only on create; echo it on update to keep the branch. | [optional] 
**Condition** | [**JourneyCondition**](JourneyCondition.md) |  | [optional] 
**Weight** | **decimal** | Branch weight for split_range nodes. Weights across a node&#39;s branches must sum to 100. | [optional] 
**Nodes** | [**List&lt;JourneyNode&gt;**](JourneyNode.md) | Nodes run when this branch is taken, before flow converges to the next sibling node. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

