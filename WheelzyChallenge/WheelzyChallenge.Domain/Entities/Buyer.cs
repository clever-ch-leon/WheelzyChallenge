using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;

namespace WheelzyChallenge.Domain.Entities
{
    public class Buyer : Entity<int>
    {
        public Buyer()
        {
            Offers = new List<Offer>();
        }

        public string Name { get; set; }
        public decimal Quote { get; set; }
        public string IdCard { get; set; }
        public string IdType { get; set; }


        public List<Offer> Offers { get; set; }
    }
}
