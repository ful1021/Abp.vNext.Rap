using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.DataDictionaryManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(DataDictionaryManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class DataDictionaryManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DataDictionaryManagementDbContext>(options =>
            {
                options.AddDefaultRepositories<IDataDictionaryManagementDbContext>();
                options.AddRepository<DataDictionary, EfCoreDataDictionaryRepository>();
            });
        }
    }
}