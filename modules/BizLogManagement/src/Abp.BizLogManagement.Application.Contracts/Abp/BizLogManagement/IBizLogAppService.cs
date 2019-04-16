using System;
using System.Threading.Tasks;
using Abp.BizLogManagement.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.BizLogManagement
{
    /// <summary>
    ///   服务契约
    /// </summary>
    public interface IBizLogAppService : IApplicationService
    {
        Task<BizLogQueryDto> GetAsync(Guid Id);

        Task<PagedResultDto<BizLogQueryDto>> GetListAsync(BizLogGetAllInput input);
    }
}