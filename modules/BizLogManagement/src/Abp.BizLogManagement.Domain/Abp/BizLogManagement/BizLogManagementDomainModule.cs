using Microsoft.Extensions.DependencyInjection;
using Abp.BizLogManagement.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.BizLogManagement
{
    [DependsOn(
        typeof(BizLogManagementDomainSharedModule)
        )]
    public class BizLogManagementDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BizLogManagementDomainModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<BizLogManagementResource>().AddVirtualJson("/Abp/BizLogManagement/Localization/Domain");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("BizLogManagement", typeof(BizLogManagementResource));
            });
        }
    }
}
