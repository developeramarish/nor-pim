rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 3/11/2020 10:30:47 PM
rem Template: sql2x.Azure.ExecuteDOSIncognito
rem From: SQL2XExtension.SQL2XExtensionCreatorCoreV0.PublishDotNetCoreLayerToAzure
"C:\Program Files (x86)\IIS\Microsoft Web Deploy V3\msdeploy.exe" ^
 -source:manifest='C:\SQL2XProjects\SolutionNorSolutionPim\PrototypeASPNetCoreTemplateWebApplicationWithCrude\Operational\SourceManifest.xml'  -dest:manifest='C:\SQL2XProjects\SolutionNorSolutionPim\PrototypeASPNetCoreTemplateWebApplicationWithCrude\Operational\DestinationManifest.xml',ComputerName='https://NorSolutionPimCore.scm.azurewebsites.net/msdeploy.axd?site=NorSolutionPimCore',UserName='$NorSolutionPimCore',Password='xxx',IncludeAcls='False',AuthType='Basic'  -verb:sync  -enablerule:AppOffline  -retryAttempts:20