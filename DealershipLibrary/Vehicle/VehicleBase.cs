using DealershipLibrary.Vehicle;
using System.Collections.Generic;

namespace DealershipLibrary
{
    public abstract class VehicleBase
    {
        public VehicleBase()
        {
                
        }
         public CarModels carModel {get; set;}
        public MCModels mcModel {get; set;}
        public TModels tModel {get; set;}
        public CarColors carColor {get; set;}
        public MCColors mcColor {get; set;}
        public TColors tColor {get; set;}



        public List<VehicleBase> VehiclesList {get; set;}
        
        public VehicleBase(CarModels model, CarColors color){
            this.carModel = model;
            this.carColor = color;
        }

        public VehicleBase(MCModels model, MCColors color){
            this.mcModel = model;
            this.mcColor = color;
        }
        public VehicleBase(TModels model, TColors color){
            this.tModel = model;
            this.tColor = color;
        }

      

        // public override string ToString()
        // {
        //     return $"{CModel} {Color}";
        // }
    }
}