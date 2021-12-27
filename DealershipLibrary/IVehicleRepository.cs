using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public interface IVehicleRepository
    {
        string SubmitToDB(List<VehicleDTO> ShoppingCart);
        List<LookupDTO> GetColors();
        List<VehicleModel> GetModels();
        List<LookupDTO> GetTypes();
    }
}
