using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Abp.BizLogManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AutoMapper;
using Volo.Abp.Localization;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;

namespace Abp.BizLogManagement
{
    [DependsOn(typeof(BizLogManagementHttpApiModule))]
    [DependsOn(typeof(AbpAspNetCoreMvcUiThemeSharedModule))]
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class BizLogManagementWebModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
            {
                options.AddAssemblyResource(typeof(BizLogManagementResource), typeof(BizLogManagementWebModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<NavigationOptions>(options =>
            {
                options.MenuContributors.Add(new BizLogManagementMenuContributor());
            });

            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BizLogManagementWebModule>("Abp.BizLogManagement");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<BizLogManagementResource>()
                    .AddBaseTypes(
                        typeof(AbpValidationResource),
                        typeof(AbpUiResource)
                    ).AddVirtualJson("/Localization/Resources/BizLogManagement");
            });

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<BizLogManagementWebAutoMapperProfile>(validate: true);
            });

            Configure<RazorPagesOptions>(options =>
            {
                //Configure authorization.
            });
        }
    }
}
