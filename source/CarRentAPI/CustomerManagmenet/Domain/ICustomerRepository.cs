using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CustomerManagmenet.Domain
{
    interface ICustomerRepository
    {
        Customer FindById(int id);

        IEnumerable<Customer> FindByName(string name);

        void Add(Customer customer);

        void Remove(Customer customer);

        void Remove(int id);
    }
}
