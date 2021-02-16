using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagmenet.Domain;

namespace CarRentAPI.CarManagmenet.Application
{
    public interface ICarService
    {
        IEnumerable<Car> GetAll();

        Car Get(Guid id);
    }
}
