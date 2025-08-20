using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;

namespace WheelzyChallenge.Domain.Entities
{
    public class Car : Entity<int>
    {
        public Car()
        {
            Offers = new List<Offer>();
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Submodel { get; set; }
        public string CarId { get; set; }
        public int IdLocation { get; set; }


        [JsonIgnore]
        public Location Location { get; set; }

        public List<Offer> Offers { get; set; }
    }
}
