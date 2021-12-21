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
        public VehicleType VehicleType { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public VehicleModel VehicleModel { get; set; }

        public int VehicleDTOId { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public VehicleDTO() { }

        public VehicleDTO(string modelName, string colorName)
        {
            this.ModelName = modelName;
            this.ColorName = colorName;
        }

    }
}
