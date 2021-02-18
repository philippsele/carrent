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


        #region Car
        public IList<Car> GetCars()
        {

            return new List<Car>();
        }
        public Car GetById(int id)
        {
            return new Car();
        }
        public IList<Car> FindById(int id)
        {
            return new List<Car>();
        }
        public IList<Car> FindByType(Guid type)
        {
            return new List<Car>();
        }
        public IList<Car> FindByClass(Guid cls)
        {
            return new List<Car>();
        }
        public IList<Car> FindByBrand(Guid brand)
        {
            return new List<Car>();
        }
        public void InsertCar(Car car)
        {

        }
        public void UpdateCar(Car car)
        {

        }
        public void DeleteCar(Car car)
        {

        }
        #endregion



        #region Brand
        public IList<CarBrand> GetBrand()
        {
            return new List<CarBrand>();
        }
        public CarBrand GetBrandById(Guid id)
        {
            return new CarBrand();
        }
        public void InsertBrand(CarBrand brand)
        {

        }
        public void UpdateBrand(CarBrand brand)
        {

        }
        public void DeleteBrand(CarBrand brand)
        {

        }
        #endregion



        #region Type
        public IList<CarType> GetType()
        {
            return new List<CarType>();
        }
        public CarType GetTypeById(Guid id)
        {
            return new CarType();
        }
        public void InsertType(CarType type)
        {

        }
        public void UpdateType(CarType type)
        {

        }
        public void DeleteType(CarType type)
        {

        }
        #endregion



        #region Class
        public IList<CarClass> GetClass()
        {
            return new List<CarClass>();
        }
        public CarClass GetClassById(Guid id)
        {
            return new CarClass();
        }
        public void InsertClass(CarClass cls)
        {

        }
        public void UpdateClass(CarClass cls)
        {

        }
        public void DeleteClass(CarClass cls)
        {

        }
        #endregion
    }
}
