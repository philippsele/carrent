using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagmenet.Domain
{
    public enum Class
    {
        Luxury,
        Medium,
        Basic
    }
    public class CarClass
    {
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
