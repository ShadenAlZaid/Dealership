namespace DealershipLibrary.Vehicle
{
    public class VehicleType
    {
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }

        public List<VehicleModel> VehicleModels { get; set; }
        public VehicleType(int VehicleTypeId, string Name)
        {
            this.VehicleTypeId = VehicleTypeId;
            this.Name = Name;
        }
    }
    public enum VehicleTypesEnum
    {
        Car = 1,
        Motorcycle = 2,
        Truck = 3,
    }
}
