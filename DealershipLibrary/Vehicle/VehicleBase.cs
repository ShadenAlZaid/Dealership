using DealershipLibrary.Vehicle;
using System.Collections.Generic;

namespace DealershipLibrary
{
    public abstract class VehicleBase
    {
        public VehicleBase(){}
        public CarModels carModel {get; set;}
        public MCModels mcModel {get; set;}
        public TModels tModel {get; set;}
        //public CarColors carColor {get; set;}
        //public MCColors mcColor {get; set;}
        //public TColors tColor {get; set;}
        public VehicleColors color {get; set;}

        public List<VehicleBase> VehiclesList {get; set;}

        
        public VehicleBase(CarModels model, VehicleColors color){
            this.carModel = model;
            this.color = color;
        }
        public VehicleBase(MCModels model, VehicleColors color){
            this.mcModel = model;
            this.color = color;
        }
        public VehicleBase(TModels model, VehicleColors color){
            this.tModel = model;
            this.color = color;
        }
    }
}