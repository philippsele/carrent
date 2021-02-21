using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagement.Api
{
    
    public class CarClassDTO
    {
        public int CarClassId { get; set; }
        public string Class { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
