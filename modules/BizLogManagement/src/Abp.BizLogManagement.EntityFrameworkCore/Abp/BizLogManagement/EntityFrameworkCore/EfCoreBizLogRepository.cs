using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.BizLogManagement.EntityFrameworkCore
{
    public class EfCoreBizLogRepository : EfCoreRepository<IBizLogManagementDbContext, BizLog, Guid>, IBizLogRepository
    {
        public EfCoreBizLogRepository(IDbContextProvider<IBizLogManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}