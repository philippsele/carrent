using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.ContractManagement.Infrastructur
{
    public class ContractModel
    {
        public int ContractId { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int CarId { get; set; }
        public int ClassId { get; set; }
        public string Class { get; set; }
        public decimal PricePerDay { get; set; }
        public string TypeId { get; set; }
        public string Type { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public bool PickedUp { get; set; }
        public int Days { get; set; }
        public decimal Total { get; set; }
    }
}
