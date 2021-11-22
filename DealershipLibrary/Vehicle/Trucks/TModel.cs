using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipLibrary.Vehicle;

namespace DealershipLibrary{
    public class TModel : IVehicleModel
    {
        List<string> truckModels = new List<string>();
        public string Name { get; set; }
    }

    public enum TModelsEnum
    {
        Silverado = 1,
        Tornado = 2,
        Ranger = 3
    }
}