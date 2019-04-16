using System.Threading.Tasks;
using Abp.DataDictionaryManagement.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.DataDictionaryManagement
{
    [RemoteService]
    [Area("DataDictionaryManagement")]
    [Route("api/DataDictionaryManagement/dataDictionary")]
    public class DataDictionaryController : AbpController, IDataDictionaryAppService
    {
        private readonly IDataDictionaryAppService _dataDictionaryAppService;

        public DataDictionaryController(IDataDictionaryAppService dataDictionaryAppService)
        {
            _dataDictionaryAppService = dataDictionaryAppService;
        }

        [HttpPost]
        public Task<DataDictionaryQueryDto> CreateAsync(DataDictionaryDto input)
        {
            return _dataDictionaryAppService.CreateAsync(input);
        }

        [HttpDelete]
        public Task DeleteAsync(int id)
        {
            return _dataDictionaryAppService.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<DataDictionaryQueryDto> GetAsync(int id)
        {
            return _dataDictionaryAppService.GetAsync(id);
        }

        [HttpGet]
        [Route("all")]
        public Task<PagedResultDto<DataDictionaryQueryDto>> GetListAsync(DataDictionaryGetAllInput input)
        {
            return _dataDictionaryAppService.GetListAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<DataDictionaryQueryDto> UpdateAsync(int id, DataDictionaryDto input)
        {
            return _dataDictionaryAppService.UpdateAsync(id, input);
        }
    }
}