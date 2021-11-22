using DealershipLibrary;
using DealershipLibrary.Vehicle;
using System;
using System.ComponentModel.DataAnnotations;

namespace DealershipLibrary.Vehicle
{
    public interface IVehicleModel
    {
        public string Name { get; set; }
    }
}