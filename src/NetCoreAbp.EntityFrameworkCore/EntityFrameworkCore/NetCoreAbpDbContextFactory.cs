using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NetCoreAbp.Configuration;
using NetCoreAbp.Web;

namespace NetCoreAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NetCoreAbpDbContextFactory : IDesignTimeDbContextFactory<NetCoreAbpDbContext>
    {
        public NetCoreAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NetCoreAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NetCoreAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NetCoreAbpConsts.ConnectionStringName));

            return new NetCoreAbpDbContext(builder.Options);
        }
    }
}
