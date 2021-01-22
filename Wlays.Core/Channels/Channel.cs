using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wlays.Channels
{
    [Table("Channels")]
    public class Channel : Entity<int>, IHasCreationTime, IHasDeletionTime
    {
        public const int MaxDescriptionLength = 256;
        public const int MaxNameLength = 128;

        /// <summary>
        /// 栏目名称
        /// </summary>
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 栏目描述
        /// </summary>
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
