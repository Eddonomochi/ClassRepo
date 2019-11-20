using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Identity;

namespace Dapper101AHBCJULY2019.DAL.Identity
{
    public class UsersTable
    {
        private readonly Database _config;

        public UsersTable(Dapper101AHBCJULY2019Configuration config)
        {
            _config = config.Database;
        }

        #region createuser
        public async Task<IdentityResult> CreateAsync(ApplicationUser user)
        {
            string sql = "INSERT INTO dbo.CustomUser " +
                         "VALUES (@id, @Email, @EmailConfirmed, @PasswordHash, @UserName)";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                int rows = await connection.ExecuteAsync(sql, new { user.Id, user.Email, user.EmailConfirmed, user.PasswordHash, user.UserName });
                if (rows > 0)
                {
                    return IdentityResult.Success;
                }

                return IdentityResult.Failed(new IdentityError { Description = $"Could not insert user {user.Email}." });
            }
        }
        #endregion

        public async Task<IdentityResult> DeleteAsync(ApplicationUser user)
        {
            string sql = "DELETE FROM dbo.CustomUser WHERE Id = @Id";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                int rows = await connection.ExecuteAsync(sql, new { user.Id });

                if (rows > 0)
                {
                    return IdentityResult.Success;
                }
                return IdentityResult.Failed(new IdentityError { Description = $"Could not delete user {user.Email}." });
            }
        }


        public async Task<ApplicationUser> FindByIdAsync(Guid userId)
        {
            string sql = "SELECT * " +
                         "FROM dbo.CustomUsers " +
                         "WHERE Id = @Id;";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                return await connection.QuerySingleOrDefaultAsync<ApplicationUser>(sql, new
                {
                    Id = userId
                });
            }
        }


        public async Task<ApplicationUser> FindByNameAsync(string userName)
        {
            string sql = "SELECT * " +
                         "FROM dbo.CustomUser " +
                         "WHERE UserName = @UserName;";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                return await connection.QuerySingleOrDefaultAsync<ApplicationUser>(sql, new
                {
                    UserName = userName
                });
            }
        }
    } 
}
