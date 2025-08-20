using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;

namespace WheelzyChallenge.Domain.Entities
{
    public class Location : Entity<int>
    {
        public Location()
        {
            Cars = new List<Car>();
        }

        public string Name { get; set; }
        public string ZipCode { get; set; }

        public List<Car> Cars { get; set; }
    }
}
