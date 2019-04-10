using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using DataDictionaryManagement.Localization;

namespace DataDictionaryManagement
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class DataDictionaryManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<DataDictionaryManagementResource>("en");
            });
        }
    }
}
