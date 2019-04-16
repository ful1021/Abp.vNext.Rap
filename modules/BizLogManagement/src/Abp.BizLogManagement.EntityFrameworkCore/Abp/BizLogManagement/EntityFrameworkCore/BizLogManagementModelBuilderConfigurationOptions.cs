using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.BizLogManagement.EntityFrameworkCore
{
    public class BizLogManagementModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public BizLogManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = BizLogManagementConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = BizLogManagementConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}