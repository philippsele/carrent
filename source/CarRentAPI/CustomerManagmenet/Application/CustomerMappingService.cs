using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CustomerManagmenet.Api;
using CarRentAPI.CustomerManagmenet.Domain;

namespace CarRentAPI.CustomerManagmenet.Application
{
    public class CustomerMappingService : ICustomerMappingService
    {
        public IList<CustomerDTO> MappingCustomers(IList<Customer> customers)
        {
            var returnList = customers.Select(c => new CustomerDTO()
            {
                CustomerId = c.CustomerId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Street = c.Street,
                City = c.City
            }).ToList();
            return returnList;
        }

        public CustomerDTO MappingCustomer(Customer customer)
        {
            var returnCustomer = new CustomerDTO
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Street = customer.Street,
                City = customer.City
            };
            return returnCustomer;
        }

        public Customer MappingCustomerDTO(CustomerDTO customer)
        {
            var returnCustomer = new Customer
            {
                CustomerId = customer.CustomerId.GetValueOrDefault(-1),
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Street = customer.Street,
                City = customer.City
            };
            return returnCustomer;
        }
    }
}
