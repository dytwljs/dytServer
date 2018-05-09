using System;
using System.ComponentModel.DataAnnotations;
namespace dytServer.Domain.Entities
{
    public class UserRole
    {
        public int UserId { get; set; }
        [StringLength(36)]
        public string UserGUID { get; set; }
        public User User { get; set; }

        public int RoleId { get; set; }
        [StringLength(36)]
        public string RoleGUID { get; set; }
        public Role Role { get; set; }

    }
}
