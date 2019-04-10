using Volo.Abp.Modularity;

namespace Abp.DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementApplicationModule),
        typeof(DataDictionaryManagementDomainTestModule)
        )]
    public class DataDictionaryManagementApplicationTestModule : AbpModule
    {

    }
}
