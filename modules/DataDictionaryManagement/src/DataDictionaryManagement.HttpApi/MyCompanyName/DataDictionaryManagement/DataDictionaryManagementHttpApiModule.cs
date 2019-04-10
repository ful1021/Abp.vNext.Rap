using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class DataDictionaryManagementHttpApiModule : AbpModule
    {
        
    }
}
