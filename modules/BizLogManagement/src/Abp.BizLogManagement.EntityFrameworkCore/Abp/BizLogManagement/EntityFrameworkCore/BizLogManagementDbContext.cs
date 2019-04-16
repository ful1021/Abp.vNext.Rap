using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.BizLogManagement.EntityFrameworkCore
{
    [ConnectionStringName("BizLogManagement")]
    public class BizLogManagementDbContext : AbpDbContext<BizLogManagementDbContext>, IBizLogManagementDbContext
    {
        public static string TablePrefix { get; set; } = BizLogManagementConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = BizLogManagementConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public BizLogManagementDbContext(DbContextOptions<BizLogManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureBizLogManagement(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}