using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelzyChallenge.Domain.Entities.Base;

namespace WheelzyChallenge.Domain.Entities
{
    public class Customer : Entity<int>
    {
        public string Name { get; set; }
        public string IdCard { get; set; }
        public string IdType { get; set; }
    }
}
