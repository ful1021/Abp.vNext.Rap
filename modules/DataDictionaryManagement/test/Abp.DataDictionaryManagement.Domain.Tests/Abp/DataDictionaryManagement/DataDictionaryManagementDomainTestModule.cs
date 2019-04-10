using Abp.DataDictionaryManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementEntityFrameworkCoreTestModule)
        )]
    public class DataDictionaryManagementDomainTestModule : AbpModule
    {
        
    }
}
