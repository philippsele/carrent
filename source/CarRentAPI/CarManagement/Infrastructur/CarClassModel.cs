using System;

namespace CarRentAPI.CarManagement.Infrastructur
{
    public class CarClassModel
    {
        public int ClassId { get; set; }
        public string Class { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
