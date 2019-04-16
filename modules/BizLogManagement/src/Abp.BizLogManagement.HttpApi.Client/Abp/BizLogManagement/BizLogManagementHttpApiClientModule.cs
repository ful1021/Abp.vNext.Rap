using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Abp.BizLogManagement
{
    [DependsOn(
        typeof(BizLogManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class BizLogManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "BizLogManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BizLogManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
