using CarRentAPI.CustomerManagmenet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CustomerManagmenet.Infrastructur
{
    class CustomerModelMappingService : ICustomerModelMappingService
    {
        public IList<Customer> MappingCustomerModels(IList<CustomerModel> customers)
        {
            var returnList = customers.Select(c => new Customer()
            {
                CustomerId = c.CustomerId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Street = c.Street,
                City = c.City
            }).ToList();
            return returnList;
        }

        public Customer MappingCustomerModel(CustomerModel customer)
        {
            var returnCustomer = new Customer
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Street = customer.Street,
                City = customer.City
            };
            return returnCustomer;
        }
    }
}
