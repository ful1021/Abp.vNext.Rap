using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.BizLogManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(BizLogManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class BizLogManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BizLogManagementDbContext>(options =>
            {
                options.AddDefaultRepositories<IBizLogManagementDbContext>();
                options.AddRepository<BizLog, EfCoreBizLogRepository>();
            });
        }
    }
}