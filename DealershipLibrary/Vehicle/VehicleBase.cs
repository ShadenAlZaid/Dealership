using DealershipLibrary.Vehicle;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DealershipLibrary
{
    public abstract class VehicleBase
    {
        public VehicleBase(){}
        // public CarModels carModel {get; set;}
        // public MCModels mcModel {get; set;}
        // public TModels tModel {get; set;}
        //public CarColors carColor {get; set;}
        //public MCColors mcColor {get; set;}
        //public TColors tColor {get; set;}
        
        [Required (ErrorMessage = "Select a Color")]
        public VehicleColors color {get; set;}
        
        [Required (ErrorMessage = "Select a Model")]
        public VehicleModels Model {get; set;}

        public List<VehicleBase> VehiclesList {get; set;}

        
        public VehicleBase(VehicleModels modelName, VehicleColors color){
            this.Model = modelName;
            this.color = color;
        }
        // public VehicleBase(VehicleModels modelName, VehicleColors color){
        //     this.modelName = modelName;
        //     this.color = color;
        // }
        // public VehicleBase(VehicleModels modelName, VehicleColors color){
        //     this.modelName = modelName;
        //     this.color = color;
        // }
    }
}