using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.DataDictionaryManagement.EntityFrameworkCore
{
    [ConnectionStringName("DataDictionaryManagement")]
    public class DataDictionaryManagementDbContext : AbpDbContext<DataDictionaryManagementDbContext>, IDataDictionaryManagementDbContext
    {
        public static string TablePrefix { get; set; } = DataDictionaryManagementConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = DataDictionaryManagementConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DataDictionaryManagementDbContext(DbContextOptions<DataDictionaryManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDataDictionaryManagement(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}