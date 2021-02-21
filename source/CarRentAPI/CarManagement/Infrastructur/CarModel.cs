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
        public int ClassId { get; set; }
        public string Class { get; set; }
        public decimal PricePerDay { get; set; }
        public string TypeId { get; set; }
        public string Type { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
    }
}
