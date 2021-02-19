using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CustomerManagmenet.Application
{
    public interface ICustomerService
    {
        IList<CustomerDTO> Get();
        CustomerDTO GetById(int id);
        IList<CustomerDTO> FindByName(string search);
        void Insert(CustomerDTO c);
        void Update(CustomerDTO customer);
        void Delete(CustomerDTO customer);
    }
}
