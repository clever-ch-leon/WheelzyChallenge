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
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(o => o.Id)
                .HasName("PK_Location");

            builder.ToTable("Location");

            builder.Property(o => o.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(o => o.ZipCode)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
