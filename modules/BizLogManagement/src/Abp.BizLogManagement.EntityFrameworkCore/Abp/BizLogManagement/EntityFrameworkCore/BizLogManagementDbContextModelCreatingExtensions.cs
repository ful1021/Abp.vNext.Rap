using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.BizLogManagement.EntityFrameworkCore
{
    public static class BizLogManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureBizLogManagement(
            this ModelBuilder builder,
            Action<BizLogManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BizLogManagementModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);

            builder.Entity<BizLog>(b =>
            {
                //Configure table &schema name
                b.ToTable(options.TablePrefix + "BizLog", options.Schema);

                b.ConfigureExtraProperties();
                b.ConfigureCreationAudited();

                //Properties
                b.Property(q => q.BizData);
                b.Property(q => q.BizDescription).HasMaxLength(BizLogConsts.MaxBizDescriptionLength);
                b.Property(q => q.BizName).HasMaxLength(BizLogConsts.MaxBizNameLength);
                b.Property(q => q.BizNo).HasMaxLength(BizLogConsts.MaxBizNoLength);
                b.Property(q => q.BizType).HasMaxLength(BizLogConsts.MaxBizTypeLength);
                b.Property(q => q.Id);

                //Configure relations
                //b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Configure indexes
                b.HasIndex(q => q.BizNo);
            });
        }
    }
}