# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of solutions
$solutions = (
    "modules/DataDictionaryManagement"
)

# List of projects
$projects = (

    # modules/DataDictionaryManagement
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.Application",
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.Application.Contracts",    
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.Domain",
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.Domain.Shared",
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.EntityFrameworkCore",    
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.HttpApi",
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.HttpApi.Client",
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.MongoDB",
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.Web"
)