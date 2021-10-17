using System;
using System.Collections.Generic;

namespace Dealership
{
    abstract class VehicleBase : IRent
    {
        public VehicleBase()
        {
                
        }
        public string Cost { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }

        public List<VehicleBase> VehiclesList {get; set;}
        public string availability {get; private set;}
        public VehicleBase(string year, string make, string model, string color, string cost, string availability){
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Cost = cost;
            this.availability = availability;
        }
        public void RentVehicle()
        {
            availability = "No";
        }

        public override string ToString()
        {
            return $"{Year} + {Make} + {Model} + {Color} + {Cost} RENTED!";
        }
    }
}