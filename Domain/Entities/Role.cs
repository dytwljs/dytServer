using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace dytServer.Domain.Entities
{
    public class Role : Entity
    {

        //public int RoleId { get; set; }
        [StringLength(36)]
        public string RoleGUID { get; set; }
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int CreateUserId { get; set; }
        [StringLength(36)]
        public string CreateUserGUID { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(4000)]
        public string Remarks { get; set; }

        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
