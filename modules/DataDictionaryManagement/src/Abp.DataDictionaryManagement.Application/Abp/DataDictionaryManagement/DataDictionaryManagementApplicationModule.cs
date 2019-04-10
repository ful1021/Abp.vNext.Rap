using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace Abp.DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementDomainModule),
        typeof(DataDictionaryManagementApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class DataDictionaryManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<DataDictionaryManagementApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
