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
    public class BuyerConfiguration : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            builder.HasKey(b => b.Id)
                .HasName("PK_Buyer");

            builder.ToTable("Buyer");

            builder.Property(b => b.Name)
                .HasMaxLength(100);

            builder.Property(b => b.Quote)
                .IsRequired();

            builder.Property(b => b.IdCard)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(b => b.IdType)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
