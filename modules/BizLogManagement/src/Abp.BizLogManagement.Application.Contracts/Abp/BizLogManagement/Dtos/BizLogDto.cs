using System;
using Volo.Abp.Application.Dtos;

namespace Abp.BizLogManagement.Dtos
{
    /// <summary>
    ///  Dto
    /// </summary>
    public class BizLogDto : EntityDto<Guid>
    {
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

        /// <summary>
        /// 业务描述
        /// </summary>
        public string BizDescription { get; set; }

        /// <summary>
        /// 业务单据数据
        /// </summary>
        public string BizData { get; set; }
    }
}