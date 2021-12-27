using DealershipLibrary.Vehicle;

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

        public List<LookupDTO> GetColors()
        {
            return this.vehicleRepository.GetColors();
        }

        public List<LookupDTO> GetModels(Type x)
        {
            return this.vehicleRepository.GetModels(x);
        }

        public List<LookupDTO> GetTypes()
        {
            return this.vehicleRepository.GetTypes();
        }
    }
}
