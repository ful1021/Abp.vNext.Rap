using Microsoft.Extensions.DependencyInjection;
using Abp.BizLogManagement.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.BizLogManagement
{
    [DependsOn(
        typeof(BizLogManagementDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class BizLogManagementApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BizLogManagementApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<BizLogManagementResource>()
                    .AddVirtualJson("/Abp/BizLogManagement/Localization/ApplicationContracts");
            });
        }
    }
}
