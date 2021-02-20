using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CustomerManagmenet.Api;
using CarRentAPI.CustomerManagmenet.Domain;
using CarRentAPI.CustomerManagmenet.Infrastructur;

namespace CarRentAPI.CustomerManagmenet.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerMappingService _mapping;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
            _mapping = new CustomerMappingService();
        }

        public IList<CustomerDTO> Get()
        {
            return _mapping.MappingCustomers(_customerRepository.Get());
        }

        public CustomerDTO GetById(int id)
        {
            return _mapping.MappingCustomer(_customerRepository.GetById(id));
        }

        public IList<CustomerDTO> FindByName(string searchString)
        {
            return _mapping.MappingCustomers(_customerRepository.FindByName(searchString));
        }

        public void Insert(CustomerDTO customer)
        {
            _customerRepository.Insert(_mapping.MappingCustomerDTO(customer));
        }

        public void Update(CustomerDTO customer)
        {
            _customerRepository.Update(_mapping.MappingCustomerDTO(customer));
        }
        public void Delete(CustomerDTO customer)
        {
            _customerRepository.Delete(_mapping.MappingCustomerDTO(customer));
        }

    }
}
