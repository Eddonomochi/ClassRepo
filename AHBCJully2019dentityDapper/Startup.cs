﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHBCJully2019dentityDapper.Services;
using Identity.Dapper;
using Identity.Dapper.Entities;
using Identity.Dapper.Models;
using Identity.Dapper.SqlServer.Connections;
using Identity.Dapper.SqlServer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AHBCJully2019dentityDapper
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);


            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDapperConnectionProvider<SqlServerConnectionProvider>(
                Configuration.GetSection("ConnectionStrings"))
                .ConfigureDapperIdentityCryptography(Configuration.GetSection("DapperIdentityCryptography"))
                .ConfigureDapperIdentityOptions(new DapperIdentityOptions { UseTransactionalBehavior = false }); //Change to True to use Transactions in all operations

            //services.ConfigureDapperConnectionProvider<MySqlConnectionProvider>(Configuration.GetSection("DapperIdentity"))
            //        .ConfigureDapperIdentityCryptography(Configuration.GetSection("DapperIdentityCryptography"))
            //        .ConfigureDapperIdentityOptions(new DapperIdentityOptions { UseTransactionalBehavior = false }); //Change to True to use Transactions in all operations

            //services.ConfigureDapperConnectionProvider<PostgreSqlConnectionProvider>(Configuration.GetSection("ConnectionStrings"))
            //services.ConfigureDapperConnectionProvider<PostgreSqlConnectionProvider>(Configuration.GetSection("DapperIdentity"))
            //        .ConfigureDapperIdentityCryptography(Configuration.GetSection("DapperIdentityCryptography"))
            //        .ConfigureDapperIdentityOptions(new DapperIdentityOptions { UseTransactionalBehavior = false }); //Change to True to use Transactions in all operations

            services.AddIdentity<DapperIdentityUser, DapperIdentityRole>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 1;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireUppercase = false;
            })
                    //.AddDapperIdentityFor<PostgreSqlConfiguration>()
                    .AddDapperIdentityFor<SqlServerConfiguration>()
                    //.AddDapperIdentityFor<MySqlConfiguration>()
                    .AddDefaultTokenProviders();

            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}