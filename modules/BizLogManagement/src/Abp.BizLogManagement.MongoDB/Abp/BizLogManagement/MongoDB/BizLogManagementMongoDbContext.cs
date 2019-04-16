using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.BizLogManagement.MongoDB
{
    [ConnectionStringName("BizLogManagement")]
    public class BizLogManagementMongoDbContext : AbpMongoDbContext, IBizLogManagementMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = BizLogManagementConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureBizLogManagement(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}