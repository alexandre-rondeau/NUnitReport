$currentDirectory = (pwd).path
Write-Host "Current Directory: $currentDirectory"

Update-Database -ConfigurationTypeName "NUnitReportDbConfiguration" -Verbose -ProjectName "Solirus.NUnitReport.Database"  -StartUpProject "Solirus.NUnitReport.Presentation"