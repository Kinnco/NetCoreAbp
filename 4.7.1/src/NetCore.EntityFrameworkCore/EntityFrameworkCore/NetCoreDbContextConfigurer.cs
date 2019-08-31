using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NetCore.EntityFrameworkCore
{
    public static class NetCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NetCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NetCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
