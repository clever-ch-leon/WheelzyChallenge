using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;

namespace WheelzyChallenge.Domain.Entities
{
    public class OfferHistory : Entity<int>
    {
        public int IdOffer { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string StaffMember { get; set; }


        [JsonIgnore]
        public Offer Offer { get; set; }
    }
}
