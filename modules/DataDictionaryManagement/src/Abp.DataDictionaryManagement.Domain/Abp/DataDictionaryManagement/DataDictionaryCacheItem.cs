using System;
using Abp.DataDictionaryManagement.Values;

namespace Abp.DataDictionaryManagement
{
    /// <summary>
    /// 数据字典
    /// </summary>
    [Serializable]
    public class DataDictionaryCacheItem
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

        public static string CalculateCacheKey(string name, string providerName, string providerKey)
        {
            return "pn:" + providerName + ",pk:" + providerKey + ",n:" + name;
        }
    }
}