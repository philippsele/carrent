using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CustomerManagmenet.Domain;

namespace CarRentAPI.CustomerManagmenet.Infrastructur
{
    public interface ICustomerModelMappingService
    {
        IList<Customer> MappingCustomerModels(IList<CustomerModel> customers);
        Customer MappingCustomerModel(CustomerModel customer);
    }
}
