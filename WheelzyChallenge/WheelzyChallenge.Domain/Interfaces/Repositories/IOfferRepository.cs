using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities;

namespace WheelzyChallenge.Domain.Interfaces.Repositories
{
    public interface IOfferRepository : IRepositoryBase<Offer, int>
    {
        List<Offer> GetCompleteOffers();
    }
}
