using System;
using System.Collections;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
namespace dytServer.Domain.Entities
{
    public class Role : Entity
    {

        public int RoleId { get; set; }
        public string RoleGUID { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }

        public int CreateUserId { get; set; }
        public string CreateUserGUID { get; set; }

        public DateTime? CreateTime { get; set; }

        public string Remarks { get; set; }

        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
