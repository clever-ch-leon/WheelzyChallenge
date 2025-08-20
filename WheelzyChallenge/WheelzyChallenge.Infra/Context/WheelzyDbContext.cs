using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WheelzyChallenge.Infra.Context
{
    public class WheelzyDbContext : DbContext
    {
        public WheelzyDbContext(DbContextOptions<WheelzyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seed.SeedData(modelBuilder);
        }
    }
}
