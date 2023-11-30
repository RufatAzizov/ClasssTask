using Microsoft.EntityFrameworkCore;
using Pustok.Models;
namespace Pustok.Contexts
{
    public class PustokDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-U9AO5GJ\\SQLEXPRESS; Database = Pustok; Trusted_Connection = true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
