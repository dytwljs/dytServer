using System;
using System.ComponentModel.DataAnnotations;
namespace dytServer.Domain.Entities
{
    public class RoleMenu
    {
        public int RoleId { get; set; }
        [StringLength(36)]
        public string RoleGUID { get; set; }
        public Role Role { get; set; }

        public int MenuId { get; set; }
        [StringLength(36)]
        public string MenuGUID { get; set; }
        public  Menu Menu { get; set; }
    }
}
