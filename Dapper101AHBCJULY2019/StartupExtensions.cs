using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper101AHBCJULY2019.DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Dapper101AHBCJULY2019
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            // Add identity types
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddDefaultTokenProviders();

            services.AddTransient<IUserStore<ApplicationUser>, CustomUserStore>();
            services.AddTransient<IRoleStore<ApplicationRole>, CustomRoleStore>();
            services.AddTransient<UsersTable>();

            return services;
        }
    }
}
