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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.Id)
                .HasName("PK_Car");

            builder.ToTable("Car");

            builder.Property(c => c.Year)
                .IsRequired();

            builder.Property(c => c.Make)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Model)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Submodel)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.CarId)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(c => c.Location)
                .WithMany(l => l.Cars)
                .HasForeignKey(c => c.IdLocation)
                .IsRequired();
        }
    }
}
