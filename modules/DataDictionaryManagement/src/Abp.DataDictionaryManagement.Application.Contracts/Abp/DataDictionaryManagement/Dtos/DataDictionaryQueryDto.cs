using System;

namespace Abp.DataDictionaryManagement.Dtos
{
    /// <summary>
    /// 数据字典
    /// </summary>
    public class DataDictionaryQueryDto : DataDictionaryDto
    {
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
    }
}