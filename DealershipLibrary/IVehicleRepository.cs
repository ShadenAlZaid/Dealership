using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public interface IVehicleRepository
    {
        string CheckOut(List<VehicleDTO> ShoppingCart);
    }
}
