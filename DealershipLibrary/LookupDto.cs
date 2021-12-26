using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class LookupDto
    {
 
        public LookupDto(int vehicleColorId, string name)
        {
            this.Id = vehicleColorId;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
