using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelzyChallenge.Domain.DTO
{
    public class SaleInformationDTO
    {
        public string OfferStatus { get; set; }
        public DateTime OfferDate { get; set; }

        public string CarModel { get; set; }
        public string CarSubModel { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }

        public string BuyerName { get; set; }
        public decimal BuyerQuote { get; set; }
    }
}
