using System;
using System.Threading.Tasks;
using Abp.BizLogManagement.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.BizLogManagement
{
    [RemoteService]
    [Area("BizLogManagement")]
    [Route("api/BizLogManagement/bizLog")]
    public class BizLogController : AbpController, IBizLogAppService
    {
        private readonly IBizLogAppService _bizLogAppService;

        /// <summary>
        /// 构造函数
        /// </summary>
        public BizLogController(IBizLogAppService bizLogAppService)
        {
            _bizLogAppService = bizLogAppService;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<BizLogQueryDto> GetAsync(Guid Id)
        {
            return _bizLogAppService.GetAsync(Id);
        }

        [HttpGet]
        [Route("all")]
        public Task<PagedResultDto<BizLogQueryDto>> GetListAsync(BizLogGetAllInput input)
        {
            return _bizLogAppService.GetListAsync(input);
        }
    }
}