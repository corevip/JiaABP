using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using JiaABP.Authorization.Roles;
using JiaABP.Authorization.Users;
using JiaABP.MultiTenancy;

namespace JiaABP.EntityFrameworkCore
{
    public class JiaABPDbContext : AbpZeroDbContext<Tenant, Role, User, JiaABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public JiaABPDbContext(DbContextOptions<JiaABPDbContext> options)
            : base(options)
        {
        }
    }
}
