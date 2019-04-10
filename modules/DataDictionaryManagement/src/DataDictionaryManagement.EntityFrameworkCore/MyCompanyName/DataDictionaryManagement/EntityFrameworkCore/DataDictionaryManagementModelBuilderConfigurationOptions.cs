using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace DataDictionaryManagement.EntityFrameworkCore
{
    public class DataDictionaryManagementModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public DataDictionaryManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = DataDictionaryManagementConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = DataDictionaryManagementConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}