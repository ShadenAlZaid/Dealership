using DealershipLibrary.Vehicle;
using System.ComponentModel.DataAnnotations;

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

        public int VehicleTypeId { get; set; }
        public int VehicleDTOId { get; set; }
        public int VehicleColorId { get; set; }
        [Required(ErrorMessage = "Select a Color")]
        public string ColorName { get; set; }
        public int VehicleModelId { get; set; }
        [Required(ErrorMessage = "Select a Model")]
        public string ModelName { get; set; }


        public void SetColor(int c)
        {
            this.VehicleColorId = c;
        }

        public void SetModel(int m)
        {
            this.VehicleModelId = m;
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
