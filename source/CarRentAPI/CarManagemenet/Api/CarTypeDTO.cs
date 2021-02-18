using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagmenet.Api
{
    public class CarTypeDTO
    {
        public Guid? CarTypeId { get; set; }
        public string Type { get; set; }
        public Guid BrandId { get; set; }
        public string Brand { get; set; }
    }
}
