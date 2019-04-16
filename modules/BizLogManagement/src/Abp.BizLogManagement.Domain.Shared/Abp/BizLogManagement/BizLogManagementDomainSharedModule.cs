using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Abp.BizLogManagement.Localization;

namespace Abp.BizLogManagement
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class BizLogManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<BizLogManagementResource>("en");
            });
        }
    }
}
