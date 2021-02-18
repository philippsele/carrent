using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CustomerManagmenet.Domain;

namespace CarRentAPI.CustomerManagmenet.Application
{
    public interface ICustomerMappingService
    {
        IList<CustomerDTO> MappingCustomers(IList<Customer> customers);
        CustomerDTO MappingCustomer(Customer customer);
        Customer MappingCustomerDTO(CustomerDTO customer);
    }
}
