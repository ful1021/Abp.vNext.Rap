using System;
using Abp.BizLogManagement.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.BizLogManagement
{
    /// <summary>
    ///   服务实现
    /// </summary>
    public class BizLogAppService : AsyncCrudAppService<BizLog, BizLogQueryDto, Guid, BizLogGetAllInput, BizLogDto, BizLogDto>, IBizLogAppService
    {
        private readonly IRepository<BizLog, Guid> _bizLogRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        public BizLogAppService(IRepository<BizLog, Guid> bizLogRepository) : base(bizLogRepository)
        {
            _bizLogRepository = bizLogRepository;
        }
    }
}