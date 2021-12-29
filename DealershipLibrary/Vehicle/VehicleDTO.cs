using DataAnnotationsExtensions;
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

        [Required(ErrorMessage = "Select a Model")]
        [Min(1,ErrorMessage ="Select a Model")]
        public int VehicleModelId { get; set; }

        public int VehicleTypeId { get; set; }

        public int VehicleDTOId { get; set; }

        [Min(1, ErrorMessage = "Select a Color")]

        [Required(ErrorMessage = "Select a Color")]
        public int VehicleColorId { get; set; }

        public string ColorName { get; set; }

        public string ModelName { get; set; }


        public void SetColor(string c)
        {
            if (int.TryParse(c, out int v))
                this.VehicleColorId = v;
        }

        public void SetModel(string m)
        {
            if (int.TryParse(m, out int v))
                this.VehicleModelId = v;
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
