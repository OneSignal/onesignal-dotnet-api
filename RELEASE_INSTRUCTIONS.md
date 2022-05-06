# Release Instructions
1. Generate new client version using OpenApi Generator
2. Create a new PR and merge
   * Carefully review the PR to ensure nothing is overwritten and you are including all desired changes
3. Build Release
   * Run: `dotnet build --configuration Release`
4. Create NuGet Package
   * Run: `dotnet pack --configuration Release`