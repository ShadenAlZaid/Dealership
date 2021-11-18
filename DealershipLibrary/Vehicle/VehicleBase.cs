using DealershipLibrary.Vehicle;
using System.Collections.Generic;

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
        public VehicleColors color {get; set;}
        public VehicleModels modelName {get; set;}
        public List<VehicleBase> VehiclesList {get; set;}

        
        public VehicleBase(VehicleModels modelName, VehicleColors color){
            this.modelName = modelName;
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