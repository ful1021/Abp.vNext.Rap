using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace DataDictionaryManagement.MongoDB
{
    [ConnectionStringName("DataDictionaryManagement")]
    public interface IDataDictionaryManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
