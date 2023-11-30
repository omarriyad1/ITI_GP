using ITI_GProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_GProject.Entities
{
    public class MarketPlace :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ENG-OMAR\\OMAR;Database=MarketPlace;Trusted_Connection= True;Encrypt=False;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        
    }
}
