using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SinglePageDemo.EntityFrameworkCore
{
    public static class SinglePageDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SinglePageDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SinglePageDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
