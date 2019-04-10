using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace DataDictionaryManagement
{
    public class DataDictionaryManagementTestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private DataDictionaryManagementTestData _testData;

        public DataDictionaryManagementTestDataBuilder(
            IGuidGenerator guidGenerator,
            DataDictionaryManagementTestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}