﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dytServer.Domain.Entities
{

    public class User : EntityIdentity
    {
        
        public string UserGUID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength(100)]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [StringLength(100)]
        public string Password { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [StringLength(255)]
        public string EMail { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [StringLength(255)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(4000)]
        public string Remarks { get; set; }

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
        /// 上次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginTimes { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public int DepartmentId { get; set; }
        [StringLength(36)]
        public string DepartmentGUID { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public int IsDeleted { get; set; }

        /// <summary>
        /// 所属部门实体
        /// </summary>
        public virtual Department Department { get; set; }

        /// <summary>
        /// 角色集合
        /// </summary>

        public virtual ICollection<UserRole> UserRoles { get; set; }

    }


}
