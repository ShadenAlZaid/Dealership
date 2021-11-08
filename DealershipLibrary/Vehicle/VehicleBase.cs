using DealershipLibrary.Vehicle;
using System.Collections.Generic;

namespace DealershipLibrary
{
    public abstract class VehicleBase
    {
        public VehicleBase()
        {
                
        }
        public CarModels CModel {get; set;}
        public VehicleColors Color {get; set;}
        public MCModels MModel {get; set;}
        public TModels TModel {get; set;}


        public List<VehicleBase> VehiclesList {get; set;}
        
        public VehicleBase(CarModels model, VehicleColors color){
            this.CModel = model;
            this.Color = color;
        }

        public VehicleBase(MCModels model, VehicleColors color){
            this.MModel = model;
            this.Color = color;
        }
        public VehicleBase(TModels model, VehicleColors color){
            this.TModel = model;
            this.Color = color;
        }

      

        // public override string ToString()
        // {
        //     return $"{CModel} {Color}";
        // }
    }
}