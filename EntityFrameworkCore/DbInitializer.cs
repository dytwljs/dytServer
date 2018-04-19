using System;
using dytServer.Domain;
using dytServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace dytServer.EntityFrameworkCore
{
    public static class DbInitializer
    {
        public static void Initialize(dytServerDbContext context)
        {
            context.Database.EnsureCreated();
            //if (context.Departments.Any())
            //{
            //    return;
            //}
            var dept = new Department { Id = 1, Code = "1", DepartmentGUID = System.Guid.NewGuid().ToString(),ParentId=1,Name="aa" };
            context.Departments.Add(dept);
            //// Look for any students.
            //var roles = new Role[]{
            //    new Role{ Name="管理员", Code="aa",RoleId=9999},
            //    new Role{Name="员工",Code="bb",RoleId=100}
            //};

            //if (context.Roles.Find(new object[]{"管理员","aa"})!=null)
            //{
            //    return;   // DB has been seeded
            //}
                
            //foreach (Role r in roles)
            //{
            //    context.Roles.Add(r);
            //}
            context.SaveChanges();
        }
    }
}
