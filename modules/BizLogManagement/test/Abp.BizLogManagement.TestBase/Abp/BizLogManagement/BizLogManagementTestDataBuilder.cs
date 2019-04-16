using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace Abp.BizLogManagement
{
    public class BizLogManagementTestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private BizLogManagementTestData _testData;

        public BizLogManagementTestDataBuilder(
            IGuidGenerator guidGenerator,
            BizLogManagementTestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}