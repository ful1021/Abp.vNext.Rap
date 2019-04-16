using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Abp.BizLogManagement.MongoDB
{
    public class BizLogManagementMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public BizLogManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = BizLogManagementConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}