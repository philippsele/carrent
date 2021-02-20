using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagement.Infrastructur
{
    public class CarModel
    {
        public int CarId { get; set; }
        public Guid ClassId { get; set; }
        public int Class { get; set; }
        public decimal PricePerDay { get; set; }
        public Guid TypeId { get; set; }
        public string Type { get; set; }
        public Guid BrandId { get; set; }
        public string Brand { get; set; }
    }
}
