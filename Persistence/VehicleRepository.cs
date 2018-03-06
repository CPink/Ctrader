using System.Threading.Tasks;
using ctrader.Core;
using ctrader.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ctrader.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly CtraderDbContext context;

        public VehicleRepository(CtraderDbContext context)
        {
            this.context = context;

        }
        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            if(!includeRelated)
                return await context.Vehicles.FindAsync(id);
           
            return await context.Vehicles
            .Include(v => v.Features)
                .ThenInclude(vf => vf.Feature)
            .Include(v => v.Model)
                .ThenInclude(m => m.Make)
            .SingleOrDefaultAsync(v => v.Id == id);

        }

        public void Add(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle)
        {
            context.Remove(vehicle);
        }
    }
}