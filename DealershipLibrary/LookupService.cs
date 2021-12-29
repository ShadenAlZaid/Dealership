using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public class LookupService : ILookupService
    {
        private readonly ILookupRepository lookupRepository;

        public LookupService(ILookupRepository lookupRepository)
        {
            this.lookupRepository = lookupRepository;
        }

        public List<LookupDTO> GetColors()
        {
            return this.lookupRepository.GetColors();
        }

        public List<LookupDTO> GetModels(VehicleTypesEnum x)
        {
            return this.lookupRepository.GetModels(x);
        }

        public List<LookupDTO> GetTypes()
        {
            return this.lookupRepository.GetTypes();
        }
    }
}
