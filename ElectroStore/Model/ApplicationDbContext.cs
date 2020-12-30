using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroStore.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ElectronicProducts> ElectronicProducts { get; set; }      //passing all models(-tables)

        public DbSet<Phones> Phones { get; set; }

        public DbSet<Laptops> Laptops { get; set; }

        public DbSet<TwoIn1Laptops> TwoIn1Laptops { get; set; }

        public DbSet<GamingLaptops> GamingLaptops { get; set; }

        public DbSet<KitchenAppliances> KitchenAppliances { get; set; }

        public DbSet<Refrigerators> Refrigerators { get; set; }

        public DbSet<WashingMachines> WashingMachines { get; set; }

        public DbSet<Dishwashers> Dishwashers { get; set; }
    }
}
