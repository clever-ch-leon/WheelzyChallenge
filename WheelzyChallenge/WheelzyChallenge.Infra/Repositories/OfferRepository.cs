using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.DTO;
using WheelzyChallenge.Domain.Entities;
using WheelzyChallenge.Domain.Interfaces.Repositories;
using WheelzyChallenge.Infra.Context;

namespace WheelzyChallenge.Infra.Repositories
{
    public class OfferRepository : RepositoryBase<WheelzyDbContext, Offer, int>, IOfferRepository
    {
        public OfferRepository(WheelzyDbContext dbContextSocioContrato) : base(dbContextSocioContrato)
        {
        }

        public List<Offer> GetCompleteOffers()
        {
            var offers = DbContext.Set<Offer>()
                            .AsQueryable()
                            .Include(o => o.Buyer)
                            .Include(o => o.Car)
                            .ToList();

            return offers;
        }
    }
}
