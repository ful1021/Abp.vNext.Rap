using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace Abp.BizLogManagement
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : BizLogManagementTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
