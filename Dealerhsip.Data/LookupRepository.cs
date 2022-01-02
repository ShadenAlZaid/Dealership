using System.Collections.Generic;
using System.Linq;
using DealershipLibrary;
using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;
using DealershipLibrary.Vehicle.Motorcycles;
using DealershipLibrary.Vehicle.Trucks;
namespace Dealership.Data
{
    public class LookupRepository : ILookupRepository
    {
        private readonly DealershipContext _context;

        public LookupRepository(DealershipContext dealershipContext)
        {
            this._context = dealershipContext;
        }
        public List<LookupDTO> GetColors()
        {
            var colors = _context.VehicleColors
                .Select(c => new LookupDTO(c.VehicleColorId, c.Name))
                .ToList();

            return colors;
        }

        public List<LookupDTO> GetModels(VehicleTypesEnum x)
        {
            List<LookupDTO> models;

            models = _context.VehicleModels
           .Where(m => m.VehicleTypeId == (int)x)
           .Select(c => new LookupDTO(c.VehicleModelId, c.Name))
           .ToList();
            return models;

        }

        public List<LookupDTO> GetTypes()
        {
            var types = _context.VehicleTypes
                .Select(t => new LookupDTO(t.VehicleTypeId, t.Name))
                .ToList();

            return types;
        }
    }
}

