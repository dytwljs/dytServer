using System;
namespace dytServer.Domain.Entities
{
    public class UserRole
    {
        public int UserId { get; set; }
        public string UserGUID { get; set; }
        public User User { get; set; }

        public int RoleId { get; set; }
        public string RoleGUID { get; set; }
        public Role Role { get; set; }

    }
}
