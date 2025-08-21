using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities;

namespace WheelzyChallenge.Infra.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(o => o.Id)
                .HasName("PK_Offer");

            builder.ToTable("Offer");

            builder.Property(o => o.IdBuyer)
                .IsRequired();

            builder.Property(o => o.IdCar)
                .IsRequired();

            builder.Property(o => o.Price)
                .IsRequired();

            builder.Property(o => o.Status)
                .IsRequired();

            builder.Property(o => o.Date)
                .HasColumnType("date");

            builder.HasOne(o => o.Buyer)
                   .WithMany(b => b.Offers)
                   .HasForeignKey(o => o.IdBuyer)
                   .IsRequired();

            builder.HasOne(o => o.Car)
                   .WithMany(c => c.Offers)
                   .HasForeignKey(o => o.IdCar)
                   .IsRequired();
        }
    }
}
