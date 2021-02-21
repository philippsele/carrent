using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagement.Domain;
using CarRentAPI.CustomerManagmenet.Domain;

namespace CarRentAPI.ContractManagement.Domain
{
    public enum Status
    {
        Reservation,
        Rent
    }
    public class Contract
    {
        public int ContractId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public bool PickedUp { get; set; }
        public int Days { get; set; }
        public decimal Total { get; set; }
    }
}
