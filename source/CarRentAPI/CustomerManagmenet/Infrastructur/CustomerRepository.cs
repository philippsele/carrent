using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CustomerManagmenet.Domain;

namespace CarRentAPI.CustomerManagmenet.Infrastructur
{
    class CustomerRepository : ICustomerRepository
    {
        void ICustomerRepository.Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        Customer ICustomerRepository.FindById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customer> ICustomerRepository.FindByName(string name)
        {
            throw new NotImplementedException();
        }

        void ICustomerRepository.Remove(Customer customer)
        {
            throw new NotImplementedException();
        }

        void ICustomerRepository.Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
