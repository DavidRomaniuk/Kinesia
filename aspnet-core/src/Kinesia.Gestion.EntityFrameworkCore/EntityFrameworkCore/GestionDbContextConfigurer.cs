using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Kinesia.Gestion.EntityFrameworkCore
{
    public static class GestionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GestionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GestionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}