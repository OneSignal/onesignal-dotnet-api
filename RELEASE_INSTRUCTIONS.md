# Release Instructions
1. Generate new client version using OpenApi Generator
2. Create a new PR and merge
   * Carefully review the PR to ensure nothing is overwritten and you are including all desired changes
3. Build Release
   * Run: `dotnet build --configuration Release`
4. Create NuGet Package
   * Run: `dotnet pack --configuration Release`
5. Publish NuGet Pakcage
   * To publish version 0.1.0 of the package, run: `dotnet nuget push src/OneSignalApi/bin/Release/OneSignalApi.0.1.0.nupkg --source https://www.nuget.org/packages/OneSignalApi --api-key $NUGET_APIKEY`
   * To publish a beta version, simply add `-beta1`, `-beta2` etc... after the semantic version (e.g: `OneSignalApi-0.1.0-beta1`)