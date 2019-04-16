using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Abp.BizLogManagement
{
    public interface IBizLogRepository : IBasicRepository<BizLog, Guid>
    {
    }
}
