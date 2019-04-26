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
    "modules/DataDictionaryManagement/src/Abp.DataDictionaryManagement.Web",
	
	
    # modules/BizLogManagement
    "modules/BizLogManagement/src/Abp.BizLogManagement.Application",
    "modules/BizLogManagement/src/Abp.BizLogManagement.Application.Contracts",    
    "modules/BizLogManagement/src/Abp.BizLogManagement.Domain",
    "modules/BizLogManagement/src/Abp.BizLogManagement.Domain.Shared",
    "modules/BizLogManagement/src/Abp.BizLogManagement.EntityFrameworkCore",    
    "modules/BizLogManagement/src/Abp.BizLogManagement.HttpApi",
    "modules/BizLogManagement/src/Abp.BizLogManagement.HttpApi.Client",
    "modules/BizLogManagement/src/Abp.BizLogManagement.MongoDB",
    "modules/BizLogManagement/src/Abp.BizLogManagement.Web"
)