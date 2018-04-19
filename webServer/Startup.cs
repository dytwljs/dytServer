using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using MySql.Data.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;

namespace webServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            try {
           //    testDA();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

         void testDA()
        {
            //140.143.224.214
            var mysqlConStr = "server=140.143.224.214;port=3306;database=test;uid=root;pwd=Gedy_007";

            //var mysqlConStr = "server=127.0.0.1;port=3306;database=test;uid=root;pwd=gedy_007";
            //           var mysqlConStr = "Server=www.dytwljs.com; Port=3306;Database=cAuth; Uid=root; Pwd=Gedy_007;SslMode=None;";

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(mysqlConStr))
            {
                var comm = new MySql.Data.MySqlClient.MySqlCommand("delete from g_test;");
                comm.Connection = conn;
                conn.Open();
                int a = comm.ExecuteNonQuery();


            }
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var constr = Configuration.GetConnectionString("Default");
            services.AddDbContext<dytServer.EntityFrameworkCore.dytServerDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
