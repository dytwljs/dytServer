using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace dytServer.Domain.Entities
{
    /// <summary>
    /// 部门实体
    /// </summary>
//    [Table("Department")]
    public class Department:Entity
    {
   //     [Key]
   //     public int DepartmentId { get; set; }
        public string DepartmentGUID { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        [StringLength(50)]
        public string Code { get; set; }

        /// <summary>
        /// 部门负责人
        /// </summary>
        [StringLength(100)]
        public string Manager { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [StringLength(255)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(4000)]
        public string Remarks { get; set; }

        /// <summary>
        /// 父级部门ID
        /// </summary>
        public int ParentId { get; set; }
        [MaxLength(36)]
        public string ParentGUID { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public int CreateUserId { get; set; }
        [StringLength(36)]
        public string CreateUserGUID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public int IsDeleted { get; set; }

        /// <summary>
        /// 包含用户
        /// </summary>
        public virtual ICollection<User> Users { get; set; }
    }

}
