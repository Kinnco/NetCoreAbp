using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NetCore.Configuration;
using NetCore.Web;

namespace NetCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NetCoreDbContextFactory : IDesignTimeDbContextFactory<NetCoreDbContext>
    {
        public NetCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NetCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NetCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NetCoreConsts.ConnectionStringName));

            return new NetCoreDbContext(builder.Options);
        }
    }
}
