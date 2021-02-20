using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagement.Domain
{
    public class CarType
    {
        public Guid TypeId { get; set; }
        public string Type { get; set; }
        public Guid BrandId { get; set; }
        public CarBrand Brand { get; set; }
    }
}
