using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;

namespace WheelzyChallenge.Domain.Entities
{
    public class Offer : Entity<int>
    {
        public int IdBuyer { get; set; }
        public int IdCar { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }


        [JsonIgnore]
        public Buyer Buyer { get; set; }

        [JsonIgnore]
        public Car Car { get; set; }
    }
}
