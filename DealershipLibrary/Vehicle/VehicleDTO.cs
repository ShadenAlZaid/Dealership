using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public class VehicleDTO
    {
        public VehicleDTO()
        {

        }
        public VehicleDTO(string modelName, string colorName)
        {
            if (modelName != null)
                this.ModelName = modelName;
            if (colorName != null)
                this.ColorName = colorName;
        }
        public VehicleType VehicleType { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public VehicleModel VehicleModel { get; set; }

        public int VehicleTypeId  { get; set; }

        public int VehicleDTOId { get; set; }
        public int VehicleModelId { get; set; }
        public string ModelName { get; set; }
        public int VehicleColorId { get; set; }
        public string ColorName { get; set; }


        public void SetColor(string c)
        {
            this.VehicleColorId = int.Parse(c);
        }

        public void SetModel(string m)
        {
            this.VehicleModelId = int.Parse(m);
        }

        public void Clone(VehicleDTO vehicle)
        {
            this.VehicleColorId = vehicle.VehicleColorId;
            this.VehicleModelId = vehicle.VehicleModelId;
        }

        public override string ToString()
        {
            return $"{VehicleColor?.Name} {VehicleModel?.Name}";
        }

    }
}
