namespace DealershipLibrary
{
    public class VehicleService : IVehicleService
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

    }
}
