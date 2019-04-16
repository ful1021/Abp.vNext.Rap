using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.DataDictionaryManagement.EntityFrameworkCore
{
    public static class DataDictionaryManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureDataDictionaryManagement(
            this ModelBuilder builder,
            Action<DataDictionaryManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DataDictionaryManagementModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);

            builder.Entity<DataDictionary>(b =>
            {
                //Configure table &schema name
                b.ToTable(options.TablePrefix + "DataDictionary", options.Schema);

                b.ConfigureExtraProperties();
                b.ConfigureAudited();
                b.ConfigureConcurrencyStamp();

                //Properties
                b.Property(q => q.DictCode).HasMaxLength(DataDictionaryConsts.MaxDictCodeLength).IsRequired();
                b.Property(q => q.DictValue).HasMaxLength(DataDictionaryConsts.MaxDictValueLength);
                b.Property(q => q.DictValueType);
                b.Property(q => q.Id);
                b.Property(q => q.ParentId);
                b.Property(q => q.Sort);
                b.Property(q => q.TypeCode).HasMaxLength(DataDictionaryConsts.MaxTypeCodeLength);
                b.Property(q => q.TypeName).HasMaxLength(DataDictionaryConsts.MaxTypeNameLength);

                //Configure indexes
                b.HasIndex(q => q.TypeCode);
            });
        }
    }
}