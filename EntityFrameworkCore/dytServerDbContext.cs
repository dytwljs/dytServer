using System;
using System.Data;
using dytServer.Domain;
using dytServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;
namespace dytServer.EntityFrameworkCore
{
    public class dytServerDbContext:DbContext
    {
        
        public dytServerDbContext(DbContextOptions<dytServerDbContext> options) : base(options)
        {           
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseMySQL("xxxx");

        public DbSet<Department> Departments { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasKey(de => de.Id);
            //UserRole关联配置
            modelBuilder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });

            //RoleMenu关联配置
            modelBuilder.Entity<RoleMenu>().HasKey(rm => new { rm.RoleId, rm.MenuId });
            modelBuilder.Entity<RoleMenu>()
                        .HasOne(rm => rm.Role)
                        .WithMany(r => r.RoleMenus)
                        .HasForeignKey(rm => rm.RoleId).HasForeignKey(rm => rm.MenuId);

            //启用Guid主键类型扩展
            ////   modelBuilder.HasPostgresExtension("uuid-ossp");
         //   modelBuilder.Entity<Department>().ToTable("Department");
            base.OnModelCreating(modelBuilder);
        }
	}
}
