using System;
//using System.ComponentModel.DataAnnotations.Schema;
namespace dytServer.Domain.Entities
{
    public class RoleMenu
    {
        public int RoleId { get; set; }
        public string RoleGUID { get; set; }
        public Role Role { get; set; }

        public int MenuId { get; set; }
        public string MenuGUID { get; set; }
        public Menu Menu { get; set; }
    }
}
