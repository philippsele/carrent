using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagement.Domain
{
    public interface ICarRepository
    {
        IList<Car> GetCars();
        Car GetById(int id);
        IList<Car> FindByType(Guid type);
        IList<Car> FindByClass(Guid cls);
        IList<Car> FindByBrand(Guid brand);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);


        IList<CarBrand> GetBrand();
        void InsertBrand(CarBrand brand);
        void UpdateBrand(CarBrand brand);
        void DeleteBrand(CarBrand brand);


        IList<CarType> GetType();
        void InsertType(CarType type);
        void UpdateType(CarType type);
        void DeleteType(CarType type);


        IList<CarClass> GetClass();
        void InsertClass(CarClass cls);
        void UpdateClass(CarClass cls);
        void DeleteClass(CarClass cls);

    }
}
