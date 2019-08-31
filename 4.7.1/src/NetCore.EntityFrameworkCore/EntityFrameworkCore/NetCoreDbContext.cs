using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NetCore.Authorization.Roles;
using NetCore.Authorization.Users;
using NetCore.MultiTenancy;

namespace NetCore.EntityFrameworkCore
{
    public class NetCoreDbContext : AbpZeroDbContext<Tenant, Role, User, NetCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NetCoreDbContext(DbContextOptions<NetCoreDbContext> options)
            : base(options)
        {
        }
    }
}
