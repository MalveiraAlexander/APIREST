using APIRest.Models;
using Microsoft.EntityFrameworkCore;

namespace APIRest.Data
{
    public class ContextDB : DbContext
    {
        public DbSet<Auto> Autos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Database.db", options =>
            {
                options.MigrationsAssembly("APIRest");
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
