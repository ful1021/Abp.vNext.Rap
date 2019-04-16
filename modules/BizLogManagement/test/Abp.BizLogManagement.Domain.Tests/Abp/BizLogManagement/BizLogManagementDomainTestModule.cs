using Abp.BizLogManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.BizLogManagement
{
    [DependsOn(
        typeof(BizLogManagementEntityFrameworkCoreTestModule)
        )]
    public class BizLogManagementDomainTestModule : AbpModule
    {
        
    }
}
