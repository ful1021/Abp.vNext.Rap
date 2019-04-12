using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.DataDictionaryManagement.EntityFrameworkCore
{
    [ConnectionStringName("DataDictionaryManagement")]
    public interface IDataDictionaryManagementDbContext : IEfCoreDbContext
    {
        DbSet<DataDictionary> DataDictionaries { get; set; }
    }
}