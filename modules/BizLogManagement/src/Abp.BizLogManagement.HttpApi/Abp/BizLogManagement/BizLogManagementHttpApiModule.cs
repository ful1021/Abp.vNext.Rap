using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Abp.BizLogManagement
{
    [DependsOn(
        typeof(BizLogManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class BizLogManagementHttpApiModule : AbpModule
    {
        
    }
}
