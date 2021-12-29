using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public interface ILookupService
    {
        public List<LookupDTO> GetColors();
        public List<LookupDTO> GetModels(VehicleTypesEnum x);
        public List<LookupDTO> GetTypes();

    }
}
