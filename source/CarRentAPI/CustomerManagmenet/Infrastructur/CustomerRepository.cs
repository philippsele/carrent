using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CustomerManagmenet.Domain;

namespace CarRentAPI.CustomerManagmenet.Infrastructur
{
    public class CustomerRepository : ICustomerRepository
    {
        public IList<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
