using Volo.Abp.Modularity;

namespace DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementApplicationModule),
        typeof(DataDictionaryManagementDomainTestModule)
        )]
    public class DataDictionaryManagementApplicationTestModule : AbpModule
    {

    }
}
