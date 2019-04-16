using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Abp.BizLogManagement.MongoDB
{
    public static class BizLogManagementMongoDbContextExtensions
    {
        public static void ConfigureBizLogManagement(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BizLogManagementMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}