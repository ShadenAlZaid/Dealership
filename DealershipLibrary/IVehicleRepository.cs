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

        List<LookupDto> GetColors();
    }
}
