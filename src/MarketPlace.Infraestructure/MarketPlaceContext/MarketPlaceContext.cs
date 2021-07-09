using MarketPlace.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Infraestructure.Context
{
    public class MarketPlaceContext : DbContext
    {
        public MarketPlaceContext(DbContextOptions<MarketPlaceContext> options) :
            base(options)
        { }

        public DbSet<Establishment> Establishment { get; set; }
        public DbSet<EstablishmentCategory> EstablishmentCategory { get; set; }
        public DbSet<Merchant> Merchant { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Rating> Rating { get; set; }
    }
}