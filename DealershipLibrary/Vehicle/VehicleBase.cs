using DealershipLibrary.Vehicle;
using System.ComponentModel.DataAnnotations;

namespace DealershipLibrary
{
    public abstract class VehicleBase
    {


        public VehicleBase(string modelName, VehicleColors color)
        {

            if (modelName != null)
                this.VehicleModel = new VehicleModel(modelName);
            this.color = color;
        }

        [Required(ErrorMessage = "Select a Color")]
        public VehicleColors color { get; set; }

        [Required(ErrorMessage = "Please Select a Model")]

        public VehicleModel VehicleModel { get; set; }


        public void SetModel(string name)
        {
            this.VehicleModel = new VehicleModel(name);
        }


    }
}