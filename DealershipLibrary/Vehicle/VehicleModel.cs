using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary.Vehicle
{

    public class VehicleModel
    {
        public VehicleModel(string name)
        {
            Name = name;
        }
        [Required(ErrorMessage = "Please Select a Model Name")]
        [MinLength(5, ErrorMessage = "Please Select a Model Name")]

        public string Name { get; set; }

    }

}
