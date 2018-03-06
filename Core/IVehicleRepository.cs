using System.Threading.Tasks;
using ctrader.Core.Models;

namespace ctrader.Core
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated = true);

         void Add(Vehicle vehicle);

         void Remove(Vehicle vehicle);
        
    }
}