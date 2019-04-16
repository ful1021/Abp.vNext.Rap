using Volo.Abp.Application.Dtos;

namespace Abp.BizLogManagement.Dtos
{
    /// <summary>
    ///    获取所有 输入参数
    /// </summary>
    public class BizLogGetAllInput : PagedAndSortedResultRequestDto
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public BizLogGetAllInput()
        {
            Sorting = "CreationTime DESC";
        }

        /// <summary>
        /// 业务单号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        public string BizName { get; set; }
    }
}