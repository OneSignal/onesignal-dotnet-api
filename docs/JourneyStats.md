# OneSignalApi.Model.JourneyStats
Journey-level counts plus flat, id-keyed maps of node and branch stats. Contains no definition detail; join it by id against the journey from View journey.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID of the journey these stats belong to. | [optional] 
**Started** | **int** | Users who entered the journey. | [optional] 
**Completed** | **int** | Users who reached the end of the journey normally. | [optional] 
**ExitedEarly** | **int** | Users who left the journey through an early exit rule. | [optional] 
**Nodes** | [**Dictionary&lt;string, JourneyNodeStats&gt;**](JourneyNodeStats.md) | Node stats keyed by node id. Includes every node in the graph, at any nesting depth. | [optional] 
**Branches** | [**Dictionary&lt;string, JourneyBranchStats&gt;**](JourneyBranchStats.md) | Branch stats keyed by branch id. Empty for a journey with no branching nodes. | [optional] 

[[Back to API list]](https://github.com/OneSignal/onesignal-dotnet-api#full-api-reference) [[Back to README]](https://github.com/OneSignal/onesignal-dotnet-api)

