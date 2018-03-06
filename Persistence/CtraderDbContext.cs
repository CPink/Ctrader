using ctrader.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ctrader.Persistence
{
    public class CtraderDbContext : DbContext
    {
           public DbSet<Vehicle> Vehicles { get; set; }
           public DbSet<Make> Makes { get; set; }
           public DbSet<Feature> Features { get; set; }

        public CtraderDbContext(DbContextOptions<CtraderDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf => new { vf.VehicleId, vf.FeatureId });
        }
        
    }
}