using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public class CarModel : VehicleModels
    {
        List<string> carModels = new List<string>();
        public string Name { get; set; }

    }

    public enum CarModelsEnum
    {
        Taurus = 1

    }
}
