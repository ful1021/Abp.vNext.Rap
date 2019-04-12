using Abp.DataDictionaryManagement.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.DataDictionaryManagement
{
    public class DataDictionaryAppService : AsyncCrudAppService<DataDictionary, DataDictionaryDto, int>
    {
        public DataDictionaryAppService(IRepository<DataDictionary, int> dataDictionaryRepository)
            : base(dataDictionaryRepository)
        {
            
        }
    }
}