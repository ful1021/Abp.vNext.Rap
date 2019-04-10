using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace DataDictionaryManagement.MongoDB
{
    [ConnectionStringName("DataDictionaryManagement")]
    public class DataDictionaryManagementMongoDbContext : AbpMongoDbContext, IDataDictionaryManagementMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = DataDictionaryManagementConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureDataDictionaryManagement(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}