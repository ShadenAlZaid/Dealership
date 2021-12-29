using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public interface ILookupRepository
    {
        List<LookupDTO> GetColors();
        List<LookupDTO> GetModels(VehicleTypesEnum x);
        List<LookupDTO> GetTypes();
    }
}
