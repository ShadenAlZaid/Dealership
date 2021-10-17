using System;
using System.Collections.Generic;

namespace Dealership
{
    abstract class Vehicles : IRent
    {
        public string cost {get; set;} 
        public string make {get; set;} 
        public string model {get; set;} 
        public string year {get; set;}         
        public string color {get; set;}
        public List<Vehicles> VehiclesList {get; set;}
        public string availability {get; private set;}
        public Vehicles(string year, string make, string model, string color, string cost, string availability){
            this.year = year;
            this.make = make;
            this.model = model;
            this.color = color;
            this.cost = cost;
            this.availability = availability;
        }
        public void RentVehicle()
        {
            availability = "No";
        }

        public override string ToString()
        {
            return $"{year} + {make} + {model} + {color} + {cost} RENTED!";
        }
    }
}