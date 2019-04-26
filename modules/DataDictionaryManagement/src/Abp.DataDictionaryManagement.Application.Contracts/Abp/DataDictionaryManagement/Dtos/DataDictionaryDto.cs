using Abp.DataDictionaryManagement.Values;
using Volo.Abp.Application.Dtos;

namespace Abp.DataDictionaryManagement.Dtos
{
    /// <summary>
    /// 数据字典
    /// </summary>
    public class DataDictionaryDto : EntityDto<int>
    {
        /// <summary>
        /// 上级id
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 类型编码
        /// </summary>
        public string TypeCode { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 字典编码
        /// </summary>
        public string DictCode { get; set; }

        /// <summary>
        /// 字典值
        /// </summary>
        public string DictValue { get; set; }

        /// <summary>
        /// 字典值类型
        /// </summary>
        public DictValueType DictValueType { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Remark { get; set; }
    }
}