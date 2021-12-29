using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public interface IVehicleRepository
    {
        string SubmitToDB(List<VehicleDTO> ShoppingCart);
        List<LookupDTO> GetColors();
        List<LookupDTO> GetModels(VehicleTypesEnum x);
        List<LookupDTO> GetTypes();
    }
}
