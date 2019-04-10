using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace Abp.DataDictionaryManagement
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : DataDictionaryManagementTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
