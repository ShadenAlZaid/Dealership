namespace DealershipLibrary.Vehicle
{
    public class VehicleModel
    {
        public int VehicleModelId { get; set; }
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }

        public VehicleType VehicleType { get; set; }

        public VehicleModel(string name)
        {
            this.Name = name;
        }
        public VehicleModel(int vehicleModelId, string name, int vehicleTypeId)
        {
            this.VehicleModelId = vehicleModelId;
            this.Name = name;
            this.VehicleTypeId = vehicleTypeId;
        }
        
    }

    public enum VehicleModelsEnum
    {
        //car models
        Taurus = 1,
        Explorer = 2,
        Expedition = 3,
        //motorcycle models
        Valkryie = 4,
        GoldWing = 5,
        Hurricane = 6,
        //truck models
        Silverado = 7,
        Tornado = 8,
        Ranger = 9
    }
}
