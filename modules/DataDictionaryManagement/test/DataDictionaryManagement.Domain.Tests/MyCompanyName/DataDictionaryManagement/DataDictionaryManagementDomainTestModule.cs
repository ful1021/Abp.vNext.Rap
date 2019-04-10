using DataDictionaryManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementEntityFrameworkCoreTestModule)
        )]
    public class DataDictionaryManagementDomainTestModule : AbpModule
    {
        
    }
}
