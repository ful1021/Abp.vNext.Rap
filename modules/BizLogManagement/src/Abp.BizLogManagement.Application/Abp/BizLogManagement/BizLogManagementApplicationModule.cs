using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace Abp.BizLogManagement
{
    [DependsOn(
        typeof(BizLogManagementDomainModule),
        typeof(BizLogManagementApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class BizLogManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<BizLogManagementApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
