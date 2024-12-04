
using CarManagement.Database.Entities;
using System.Data.Entity;
using System.Reflection.Emit;

namespace CarManagement.Database
{
    public class DBContext : DbContext 
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Submodel> Submodels { get; set; }
        public DbSet<CarHistory> CarHistories { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
