using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.DTO;
using WheelzyChallenge.Domain.Entities;

namespace WheelzyChallenge.Domain.Transformers
{
    public class OfferToSaleInformationTransformer
    {
        public SaleInformationDTO ConvertOfferToSaleInformationDTO(Offer offer)
        {
            SaleInformationDTO saleInformation = new()
            {
                OfferStatus = offer.Status,
                OfferDate = offer.Date,

                CarModel = offer.Car.Model,
                CarSubModel = offer.Car.Submodel,
                CarYear = offer.Car.Year,
                CarMake = offer.Car.Make,

                BuyerName = offer.Buyer.Name,
                BuyerQuote = offer.Buyer.Quote
            };

            return saleInformation;
        }
    }
}
