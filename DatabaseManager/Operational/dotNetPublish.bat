rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 10/16/2020 2:53:44 PM
rem From Machine: DESKTOP-517I8BU
rem Template: SQL2XExtensionV3.SQL2XExtensionCreatorNorSolution.ExecuteDatabaseManager
cd C:\SQL2XProjects\SolutionNorSolutionPim\DatabaseManager
dotnet restore DatabaseManager.csproj
dotnet build DatabaseManager.csproj
dotnet publish DatabaseManager.csproj
dotnet bin\Debug\netcoreapp2.0\DatabaseManager.dll
