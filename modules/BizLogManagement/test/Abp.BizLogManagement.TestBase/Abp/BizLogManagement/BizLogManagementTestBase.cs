using Volo.Abp;
using Volo.Abp.Modularity;

namespace Abp.BizLogManagement
{
    public abstract class BizLogManagementTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
