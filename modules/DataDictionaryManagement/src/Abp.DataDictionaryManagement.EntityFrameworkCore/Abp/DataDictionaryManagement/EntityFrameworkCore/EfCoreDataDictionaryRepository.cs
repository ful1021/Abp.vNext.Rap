using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.DataDictionaryManagement.EntityFrameworkCore
{
    public class EfCoreDataDictionaryRepository : EfCoreRepository<IDataDictionaryManagementDbContext, DataDictionary, int>, IDataDictionaryRepository
    {
        public EfCoreDataDictionaryRepository(IDbContextProvider<IDataDictionaryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}