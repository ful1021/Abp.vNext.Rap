using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace DataDictionaryManagement.MongoDB
{
    public static class DataDictionaryManagementMongoDbContextExtensions
    {
        public static void ConfigureDataDictionaryManagement(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DataDictionaryManagementMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}