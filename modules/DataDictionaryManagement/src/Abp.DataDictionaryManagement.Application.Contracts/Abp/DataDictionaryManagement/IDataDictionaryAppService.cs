using Abp.DataDictionaryManagement.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.DataDictionaryManagement
{
    public interface IDataDictionaryAppService : IAsyncCrudAppService<DataDictionaryDto, int>
    {
    }
}