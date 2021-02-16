using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagmenet.Domain;

namespace CarRentAPI.CarManagmenet.Infrastructur
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext _carContext;

        public CarRepository()
        {
            _carContext = new CarContext();
        }

        public void Delete(Car entity)
        {
            _carContext.Cars.Remove(entity);
        }

        public Car Get(Guid id)
        {
            var car = _carContext.Cars.Find(id);
            if (car == null)
            {
                throw new EntityNotFoundException();
            }

            return car;
        }

        public IEnumerable<Car> GetAll()
        {
            return _carContext.Query<Car>().ToList();
        }

        public void Insert(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
