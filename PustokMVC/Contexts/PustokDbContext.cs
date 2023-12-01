using Microsoft.EntityFrameworkCore;
using PustokMVC.Models;

namespace PustokMVC.Contexts
{
    public class PustokDbContext : DbContext
    {
        public DbSet<HeroSlider> HeroSliders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-U9AO5GJ\\SQLEXPRESS;Database=PustokDB;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
