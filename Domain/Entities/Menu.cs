using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace dytServer.Domain.Entities
{
    /// <summary>
    /// 功能菜单实体
    /// </summary>
    public class Menu : Entity
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        /// <value>The menu identifier.</value>
        //public int MenuId { get; set; }

        [StringLength(50)]
        public string MenuGUID { get; set; }
        /// <summary>
        /// 父级ID
        /// </summary>
        public int ParentId { get; set; }
        [StringLength(36)]
        public string ParentGUID { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int SerialNumber { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 菜单编码
        /// </summary>
        [StringLength(50)]
        public string Code { get; set; }

        /// <summary>
        /// 菜单地址
        /// </summary>
        [StringLength(255)]
        public string Url { get; set; }

        /// <summary>
        /// 类型：0导航菜单；1操作按钮。
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        [StringLength(255)]
        public string Icon { get; set; }

        /// <summary>
        /// 菜单备注
        /// </summary>
        [StringLength(4000)]
        public string Remarks { get; set; }
    }
}
