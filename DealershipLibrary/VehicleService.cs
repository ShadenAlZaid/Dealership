using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class VehicleService
    {
        private readonly IVehicleRepository vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }
        public string CheckOut(List<VehicleDTO> ShoppingCart)
        {
            /// add validations
            /// 
            
           return this.vehicleRepository.SubmitToDB(ShoppingCart);
        }

        public List<LookupDto> GetColors()
        {
            return this.vehicleRepository.GetColors();
        }

        //public string GetModels()
        //{
        //return "";
        //}
    }
}
