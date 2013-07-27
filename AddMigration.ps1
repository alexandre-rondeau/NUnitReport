param([String]$migrationName)

$currentDirectory = (pwd).path
Write-Host "Current Directory: $currentDirectory"
Write-Host "MigrationName: $migrationName"

Write-Host "Project file is latest. Adding migration..." 
Add-Migration -Name $migrationName -ConfigurationTypeName "NUnitReportDbConfiguration" -ProjectName "Solirus.NUnitReport.Database"  -StartUpProject "Solirus.NUnitReport.Presentation"

