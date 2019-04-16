using Volo.Abp.Modularity;

namespace Abp.BizLogManagement
{
    [DependsOn(
        typeof(BizLogManagementApplicationModule),
        typeof(BizLogManagementDomainTestModule)
        )]
    public class BizLogManagementApplicationTestModule : AbpModule
    {

    }
}
