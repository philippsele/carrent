using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagement.Api
{
    public class CarDTO
    {
        public int? CarId { get; set; }
        public Guid TypeId { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public Guid ClassId { get; set; }
        public string Class { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
