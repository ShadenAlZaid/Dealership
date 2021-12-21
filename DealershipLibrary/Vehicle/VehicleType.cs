﻿namespace DealershipLibrary.Vehicle
{
    public class VehicleType
    {
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }

        public VehicleType(string name)
        {
            Name = name;
        }
    }
    public enum VehicleTypesEnum
    {
        Car = 1,
        Motorcycle = 2,
        Truck = 3,
    }
}
