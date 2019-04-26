using Abp.Values;
using Volo.Abp.Domain.Entities.Auditing;

namespace Volo.Abp.Domain.Entities.Auditing
{
    /// <summary>
    /// 通用字典类型的父类实体【分类、标签、数据字典等都可用】
    /// </summary>
    public class GenericDictEntity<TKey> : AuditedEntity<TKey>
    {
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
        /// 排序【越小越靠前】
        /// </summary>
        public virtual int Sort { get; set; } = 10000;

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Remark { get; set; }
    }
}