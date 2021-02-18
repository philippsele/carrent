using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CustomerManagmenet.Domain
{
    public interface ICustomerRepository
    {
        IList<Customer> Get();

        Customer GetById(int id);

        IList<Customer> FindById(int id);

        IList<Customer> FindByName(string name);

        void Insert(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);
    }
}
