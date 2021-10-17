using System;
using System.Collections.Generic;

namespace Dealership
{
    abstract class VehicleBase
    {
        public VehicleBase()
        {
                
        }
        public CarModels Model { get; set; }
        public string Year { get; set; }
        public VehicleColors Color { get; set; }

        public List<VehicleBase> VehiclesList {get; set;}
        
        public VehicleBase(string year,CarModels model, VehicleColors color){
            this.Year = year;
            this.Model = model;
            this.Color = color;
        }


        public override string ToString()
        {
            return $"{Year} {Model} {Color}";
        }
    }
}