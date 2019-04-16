using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Abp.BizLogManagement.MongoDB
{
    [DependsOn(
        typeof(BizLogManagementDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class BizLogManagementMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<BizLogManagementMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
