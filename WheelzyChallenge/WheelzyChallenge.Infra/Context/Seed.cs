using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities;

namespace WheelzyChallenge.Infra.Context
{
    public class Seed
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OfferStatus>().HasData(
                new OfferStatus { Id = 1, Name = "Pending Acceptance" },
                new OfferStatus { Id = 2, Name = "Accepted" },
                new OfferStatus { Id = 3, Name = "Picked Up" },
                new OfferStatus { Id = 4, Name = "Cancelled" },
                new OfferStatus { Id = 5, Name = "Rejected" }
            );

            modelBuilder.Entity<IdType>().HasData(
                new IdType { Id = 1, Name = "Driver License" },
                new IdType { Id = 2, Name = "Passport" },
                new IdType { Id = 3, Name = "Real Id" },
                new IdType { Id = 4, Name = "SSN" }
            );
        }
    }
}
