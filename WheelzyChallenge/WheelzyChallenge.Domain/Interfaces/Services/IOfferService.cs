using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.DTO;

namespace WheelzyChallenge.Domain.Interfaces.Services
{
    public interface IOfferService
    {
        List<SaleInformationDTO> GetSalesInformation();
    }
}
