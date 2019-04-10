using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace DataDictionaryManagement.MongoDB
{
    public class DataDictionaryManagementMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public DataDictionaryManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = DataDictionaryManagementConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}