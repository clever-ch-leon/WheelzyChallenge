using Microsoft.EntityFrameworkCore;
using WheelzyChallenge.Domain.Interfaces.Repositories;
using WheelzyChallenge.Domain.Interfaces.Services;
using WheelzyChallenge.Domain.Services;
using WheelzyChallenge.Infra.Context;
using WheelzyChallenge.Infra.Repositories;

namespace WheelzyChallenge.DI
{
    public class SystemInitializer
    {
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            //Entity Fwk
            builder.Services.AddDbContext<WheelzyDbContext>(x => 
                x.UseSqlServer(builder.Configuration.GetConnectionString("<Wheelzy-Db")));

            //Services
            builder.Services.AddScoped<IOfferService, OfferService>();

            //Repositories
            builder.Services.AddScoped<IOfferRepository, OfferRepository>();
        }
    }
}
