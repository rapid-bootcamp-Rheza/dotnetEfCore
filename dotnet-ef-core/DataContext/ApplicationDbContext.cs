using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace dotnet_ef_core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=dbcore;uid=root;pwd=@Ketux2412;");
        }

        public DbSet<CategoryEntity> categories { get; set; }
        

    }
}
