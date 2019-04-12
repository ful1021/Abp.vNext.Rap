using Abp.DataDictionaryManagement.Values;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.DataDictionaryManagement
{
    /// <summary>
    /// 数据字典
    /// </summary>
    public class DataDictionary : AuditedAggregateRoot<int>
    {
        /// <summary>
        /// 上级id
        /// </summary>
        public virtual int ParentId { get; set; }

        /// <summary>
        /// 类型编码
        /// </summary>
        public virtual string TypeCode { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public virtual string TypeName { get; set; }

        /// <summary>
        /// 字典编码
        /// </summary>
        public virtual string DictCode { get; set; }

        /// <summary>
        /// 字典值
        /// </summary>
        public virtual string DictValue { get; set; }

        /// <summary>
        /// 字典值类型
        /// </summary>
        public virtual DictValueType DictValueType { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public virtual int Sort { get; set; }
    }
}