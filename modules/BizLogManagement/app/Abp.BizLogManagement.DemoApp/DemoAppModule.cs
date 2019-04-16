using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Abp.BizLogManagement.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using System.Linq;
using Volo.Abp;
using Volo.Abp.Account.Web;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Identity.Web;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.Threading;
using Volo.Abp.VirtualFileSystem;

namespace Abp.BizLogManagement.DemoApp
{
    [DependsOn(
        typeof(BizLogManagementWebModule),
        typeof(BizLogManagementApplicationModule),
        typeof(BizLogManagementEntityFrameworkCoreModule),

        typeof(AbpPermissionManagementEntityFrameworkCoreModule),
        typeof(AbpSettingManagementEntityFrameworkCoreModule),
        typeof(AbpIdentityEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule),

        typeof(AbpAccountWebModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpAutofacModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule)
        )]
    public class DemoAppModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.BuildConfiguration();

            Configure<DbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = configuration.GetConnectionString("Default");
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer();
            });

            if (hostingEnvironment.IsDevelopment())
            {
                Configure<VirtualFileSystemOptions>(options =>
                {
                    options.FileSets.ReplaceEmbeddedByPhysical<BizLogManagementWebModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}Abp.BizLogManagement.Web", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<BizLogManagementDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}Abp.BizLogManagement.Domain", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<BizLogManagementApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}Abp.BizLogManagement.Application", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<BizLogManagementApplicationContractsModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}Abp.BizLogManagement.Application.Contracts", Path.DirectorySeparatorChar)));
                });
            }

            context.Services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new Info { Title = "BizLogManagement API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                    options.CustomSchemaIds(type => type.FullName);
                });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                //...add other languages
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();

            if (context.GetEnvironment().IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseErrorPage();
            }

            app.UseVirtualFiles();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Support APP API");
            });

            app.UseAuthentication();
            app.UseAbpRequestLocalization();
            app.UseAuditing();

            app.UseMvcWithDefaultRouteAndArea();

            using (var scope = context.ServiceProvider.CreateScope())
            {
                AsyncHelper.RunSync(async () =>
                {
                    await scope.ServiceProvider
                        .GetRequiredService<IDataSeeder>()
                        .SeedAsync();
                });
            }
        }
    }
}
