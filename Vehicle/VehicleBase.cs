using System;
using System.Collections.Generic;

namespace Dealership
{
    abstract class VehicleBase
    {
        public VehicleBase()
        {
                
        }
        public CarModels CModel {get; set;}
        public string Year {get; set;}
        public VehicleColors Color {get; set;}
        public MCModels MModel {get; set;}
        public TModels TModel {get; set;}


        public List<VehicleBase> VehiclesList {get; set;}
        
        public VehicleBase(string year, CarModels model, VehicleColors color){
            this.Year = year;
            this.CModel = model;
            this.Color = color;
        }

        public VehicleBase(string year, MCModels model, VehicleColors color){
            this.Year = year;
            this.MModel = model;
            this.Color = color;
        }
        public VehicleBase(string year, TModels model, VehicleColors color){
            this.Year = year;
            this.TModel = model;
            this.Color = color;
        }

        public void PrintEnum(Type x)
        {
            foreach(int i in Enum.GetValues(x))
            {  
                Console.WriteLine($"{i}. {Enum.GetName(x, i)}");  
            }
        }

        // public override string ToString()
        // {
        //     return $"{Year} {CModel} {Color}";
        // }
    }
}