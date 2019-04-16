using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.BizLogManagement.MongoDB
{
    [ConnectionStringName("BizLogManagement")]
    public interface IBizLogManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
