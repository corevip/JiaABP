using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace JiaABP.EntityFrameworkCore
{
    public static class JiaABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<JiaABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<JiaABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
