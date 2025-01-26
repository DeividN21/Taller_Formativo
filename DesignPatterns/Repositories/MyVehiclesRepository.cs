using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    // MemoryCollection pasa de ser la lista de vehículos que se tenía en un principio,
    // a ser una instancia del patrón Singleton que se creó.
    public class MyVehiclesRepository : IVehicleRepository
    {
        private readonly MemoryCollection _memoryCollection;

        public MyVehiclesRepository()
        {
            _memoryCollection = MemoryCollection.Instance;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _memoryCollection.Vehicles.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
           return  _memoryCollection.Vehicles.FirstOrDefault(v => v.ID.Equals(new Guid(id)));
        }

        public ICollection<Vehicle> GetVehicles()
        {
            return _memoryCollection.Vehicles;
        }

        
    }
}
