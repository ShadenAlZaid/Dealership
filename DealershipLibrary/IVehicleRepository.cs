using DealershipLibrary.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public interface IVehicleRepository
    {
        string SubmitToDB(List<VehicleDTO> ShoppingCart);
        List<LookupDTO> GetColors();
        List<LookupDTO> GetModels();
        List<LookupDTO> GetTypes();
    }
}
