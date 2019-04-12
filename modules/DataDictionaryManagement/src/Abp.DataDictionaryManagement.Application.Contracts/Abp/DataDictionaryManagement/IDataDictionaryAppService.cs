using Abp.DataDictionaryManagement.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.DataDictionaryManagement
{
    /// <summary>
    ///   服务契约
    /// </summary>
    public interface IDataDictionaryAppService : IAsyncCrudAppService<DataDictionaryQueryDto, int, DataDictionaryGetAllInput, DataDictionaryDto, DataDictionaryDto>
    {
    }
}