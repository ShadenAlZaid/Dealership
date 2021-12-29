using DealershipLibrary.Vehicle;
using System.ComponentModel.DataAnnotations;

namespace DealershipLibrary
{
    public abstract class VehicleBase
    {
        public VehicleBase() { }
        public VehicleBase(string modelName, string colorName)
        {
            if (modelName != null)
                this.VehicleModel = new VehicleModel(modelName);
            if (colorName != null)
                this.VehicleColor = new VehicleColor(colorName);
        }
        public VehicleType VehicleType { get; set; }
        public int VehicleTypeId { get; set; }

        public VehicleColor VehicleColor { get; set; }
        public int VehicleColorId { get; set; }

        public VehicleModel VehicleModel { get; set; }
        public int VehicleModelId { get; set; }


        public void SetModel(string name)
        {
            this.VehicleModel = new VehicleModel(name);
        }

        public void SetColor(string name)
        {
            this.VehicleColor = new VehicleColor(name);
        }
    }
}