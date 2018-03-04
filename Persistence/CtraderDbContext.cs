using ctrader.Models;
using Microsoft.EntityFrameworkCore;

namespace ctrader.Persistence
{
    public class CtraderDbContext : DbContext
    {

        public CtraderDbContext(DbContextOptions<CtraderDbContext> options)
        : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        
    }
}