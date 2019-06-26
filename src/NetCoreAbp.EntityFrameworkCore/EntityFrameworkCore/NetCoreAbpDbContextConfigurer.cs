using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NetCoreAbp.EntityFrameworkCore
{
    public static class NetCoreAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NetCoreAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NetCoreAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
