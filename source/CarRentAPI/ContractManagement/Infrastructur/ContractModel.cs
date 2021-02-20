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
        public Guid ClassId { get; set; }
        public int Class { get; set; }
        public decimal PricePerDay { get; set; }
        public Guid TypeId { get; set; }
        public string Type { get; set; }
        public Guid BrandId { get; set; }
        public string Brand { get; set; }
        public int Status { get; set; }
        public int Days { get; set; }
        public decimal Total { get; set; }
    }
}
