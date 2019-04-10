﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DataDictionaryManagement.EntityFrameworkCore
{
    [ConnectionStringName("DataDictionaryManagement")]
    public interface IDataDictionaryManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}