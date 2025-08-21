using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.DTO;
using WheelzyChallenge.Domain.Entities;
using WheelzyChallenge.Domain.Interfaces.Repositories;
using WheelzyChallenge.Domain.Interfaces.Services;
using WheelzyChallenge.Domain.Transformers;

namespace WheelzyChallenge.Domain.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly OfferToSaleInformationTransformer offerToSaleInformationTransformer = new();

        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }


        /// <summary>
        /// Show the car information, current buyer name with its quote and current status name with its status date.
        /// </summary>
        public List<SaleInformationDTO> GetSalesInformation()
        {
            List<SaleInformationDTO> salesInformation = new();

            List<Offer> offers = _offerRepository.GetCompleteOffers();

            foreach (var offer in offers)
            {
                salesInformation.Add(offerToSaleInformationTransformer.ConvertOfferToSaleInformationDTO(offer));
            }


            return salesInformation;
        }


        /*
            SELECT o.Status, o.Date, 
                    c.Model, c.Submodel, c.Year, c.Make,
                    b.Name, b.Quote
            FROM Offer o
            INNER JOIN Car c as c ON c.Id = o.idCar
            INNER JOIN Buyer as b ON b.Id = o.idBuyer
        */
    }
}
