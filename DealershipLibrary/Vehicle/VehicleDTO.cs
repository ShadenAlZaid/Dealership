using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.ModelName = modelName;
            this.ColorName = colorName;
        }
        public VehicleType VehicleType { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public VehicleModel VehicleModel { get; set; }

        public int VehicleDTOId { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }


        public void SetColor(string c)
        {
            this.ColorId = int.Parse(c);
        }

        public void SetModel(string m)
        {
            this.ModelId = int.Parse(m);
        }

        public void Clone(VehicleDTO vehicle)
        {
            this.ColorId = vehicle.ColorId;
            this.ModelId = vehicle.ModelId;
        }

    }
}
