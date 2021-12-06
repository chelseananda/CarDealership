using CarDealership.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership
{
        public class Startup
        {

            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }
            //reading the connection we put inside the appsettings.json 
            //initialize our web application to use sql server database

            public void ConfigureServices(IServiceCollection services)
            {
                string connectionString = Configuration.GetConnectionString("default");
                services.AddDbContext<AppDBContext>(c => c.UseSqlServer(connectionString));

                //this will help us to use identtity functionality and handle our database
                services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDBContext>();


                //this part of the code is dealing with client request
                services.ConfigureApplicationCookie(options =>
                {
                    options.LoginPath = "/Account/Login";
                });
                //to specify iservices collection which means it will not register the services used for the page
                services.AddControllersWithViews();
            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

                app.UseRouting();
                //enabling the authentication for our web application
                app.UseAuthentication();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                });
            }

            private static IApplicationBuilder GetApp(IApplicationBuilder app)
            {
                return app;
            }
        }
    }
