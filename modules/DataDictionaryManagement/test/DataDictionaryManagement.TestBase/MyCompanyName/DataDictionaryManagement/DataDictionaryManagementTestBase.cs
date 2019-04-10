using Volo.Abp;
using Volo.Abp.Modularity;

namespace DataDictionaryManagement
{
    public abstract class DataDictionaryManagementTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
