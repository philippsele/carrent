using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagmenet.Domain
{
    public class Car
    {
        public int CarId { get; set; }
        public Guid TypeId { get; set; }
        public CarType Type { get; set; }
        public Guid ClassId { get; set; }
        public CarClass Class { get; set; }
    }
}
