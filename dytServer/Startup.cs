using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using gedy.Utils;
using dytServer.Domain;
using dytServer.EntityFrameworkCore;
//using MySql.Data.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;        //option.UseMySQL 才能使用

namespace dytServer.dytServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ////var t   =   ConfigurationManager.AppSettings["mysqlConStr"];
            ////添加数据上下文
            //services.AddDbContext<dytServerDbContext>(options =>
                                                      //options.UseMySQL(mysqlConStr));
            services.AddMvc();

        }
        public void test(){
            //获取数据库连接字符串
            var mysqlConStr = Configuration.GetConnectionString("Default");

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(mysqlConStr))
            {
                var comm = new MySql.Data.MySqlClient.MySqlCommand("delete from g_test;");
                comm.Connection = conn;
                conn.Open();
                comm.ExecuteNonQuery();

            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.      
                                                      //, ILoggerFactory loggerFactory, SchoolContext context
        //改造Configure方法签名，添加SchoolContext参数
                                                      public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, dytServerDbContext context)
        {
            //Configure方法末尾添加数据库初始化代码
          //  DbInitializer.Initialize(context);
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
            test();
        }
    }
}
