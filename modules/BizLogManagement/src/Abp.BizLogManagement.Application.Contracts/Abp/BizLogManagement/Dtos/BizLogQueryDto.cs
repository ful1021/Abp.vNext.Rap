using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Abp.BizLogManagement.Dtos
{
    /// <summary>
    ///   查询Dto
    /// </summary>
    public class BizLogQueryDto : BizLogDto
    {
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
    }    
}
