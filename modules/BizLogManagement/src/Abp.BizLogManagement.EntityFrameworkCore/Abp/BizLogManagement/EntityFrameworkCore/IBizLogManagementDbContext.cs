using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.BizLogManagement.EntityFrameworkCore
{
    [ConnectionStringName("BizLogManagement")]
    public interface IBizLogManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}