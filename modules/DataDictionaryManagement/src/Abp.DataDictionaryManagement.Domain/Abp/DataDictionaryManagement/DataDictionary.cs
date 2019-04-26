using Volo.Abp.Domain.Entities;

namespace Abp.DataDictionaryManagement
{
    /// <summary>
    /// 数据字典
    /// </summary>
    public class DataDictionary : GenericDictEntity<int>
    {
        ///// <summary>
        ///// 上级，根节点时等于null
        ///// </summary>
        //public virtual DataDictionary Parent { get; set; }
    }
}