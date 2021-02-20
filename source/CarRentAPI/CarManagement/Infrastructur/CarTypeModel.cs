using System;

namespace CarRentAPI.CarManagement.Infrastructur
{
    public class CarTypeModel
    {
        public Guid TypeId { get; set; }
        public string Type { get; set; }
        public Guid BrandId { get; set; }
        public string Brand { get; set; }
    }
}
