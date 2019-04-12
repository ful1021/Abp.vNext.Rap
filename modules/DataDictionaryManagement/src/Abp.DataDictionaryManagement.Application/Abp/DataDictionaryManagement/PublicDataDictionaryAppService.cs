using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.DataDictionaryManagement
{
    public class PublicDataDictionaryAppService : ApplicationService, IPublicDataDictionaryAppService
    {
        private readonly IRepository<DataDictionary, int> _dataDictionaryRepository;

        public PublicDataDictionaryAppService(IRepository<DataDictionary, int> dataDictionaryRepository)
        {
            _dataDictionaryRepository = dataDictionaryRepository;
        }
    }
}