# COMMON PATHS

$buildFolder = (Get-Item -Path "./" -Verbose).FullName
$slnFolder = Join-Path $buildFolder "../"
$outputFolder = Join-Path $buildFolder "outputs"
$outputHostFolder = Join-Path $outputFolder "DemoApp"
$webHostFolder = Join-Path $slnFolder "app/Abp.DataDictionaryManagement.DemoApp"

## CLEAR ######################################################################

Remove-Item $outputHostFolder -Force -Recurse -ErrorAction Ignore
New-Item -Path $outputHostFolder -ItemType Directory

## RESTORE NUGET PACKAGES #####################################################

Set-Location $slnFolder
dotnet restore

## PUBLISH WEB HOST PROJECT ###################################################

Set-Location $webHostFolder
dotnet publish --output $outputHostFolder --configuration Release

## FINALIZE ###################################################################

Set-Location $outputHostFolder