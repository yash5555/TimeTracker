using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TimeTracking.EntityFrameworkCore
{
    public static class TimeTrackingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TimeTrackingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TimeTrackingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}