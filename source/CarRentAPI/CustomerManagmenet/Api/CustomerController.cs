using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CustomerManagmenet.Application;

namespace CarRentAPI.CustomerManagmenet.Api
{
    public class CustomerController
    {
        private readonly ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        public Task<IList<CustomerDTO>> Get()
        {
            return Task.FromResult(_customerService.Get());
        }

        public Task<CustomerDTO> GetById(int id)
        {
            return Task.FromResult(_customerService.GetById(id));
        }

        public Task<IList<CustomerDTO>> FindByName(string searchString)
        {
            return Task.FromResult(_customerService.FindByName(searchString));
        }

        public void Insert(CustomerDTO customer)
        {
            _customerService.Insert(customer);
        }

        public void Update(CustomerDTO customer)
        {
            _customerService.Update(customer);
        }
        public void Delete(CustomerDTO customer)
        {
            _customerService.Delete(customer);
        }
    }
}
