using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;

namespace WheelzyChallenge.Domain.Entities
{
    public class Customer_Car : Entity<int>
    {
        public int IdCustomer { get; set; }
        public int IdCar { get; set; }


        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonIgnore]
        public Car Car { get; set; }
    }
}
