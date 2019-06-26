using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NetCoreAbp.Authorization.Roles;
using NetCoreAbp.Authorization.Users;
using NetCoreAbp.MultiTenancy;

namespace NetCoreAbp.EntityFrameworkCore
{
    public class NetCoreAbpDbContext : AbpZeroDbContext<Tenant, Role, User, NetCoreAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NetCoreAbpDbContext(DbContextOptions<NetCoreAbpDbContext> options)
            : base(options)
        {
        }
    }
}
