using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagement.Application;

namespace CarRentAPI.CarManagement.Api
{
    public class CarController
    {
        private readonly ICarService _carService;
        public CarController()
        {
            _carService = new CarService();
        }

        #region Car
        public Task<IList<CarDTO>> GetCars()
        {
            return Task.FromResult(_carService.GetCars());
        }

        public Task<CarDTO> GetById(int id)
        {
            return Task.FromResult(_carService.GetById(id));
        }

        public Task<IList<CarDTO>> FindByType(Guid type)
        {
            return Task.FromResult(_carService.FindByType(type));
        }

        public Task<IList<CarDTO>> FindByClass(Guid cls)
        {
            return Task.FromResult(_carService.FindByClass(cls));
        }

        public Task<IList<CarDTO>> FindByBrand(Guid brand)
        {
            return Task.FromResult(_carService.FindByBrand(brand));
        }

        public void InsertCar(CarDTO car)
        {
            _carService.InsertCar(car);
        }

        public void UpdateCar(CarDTO car)
        {
            _carService.UpdateCar(car);
        }

        public void DeleteCar(CarDTO car)
        {
            _carService.DeleteCar(car);
        }
        #endregion Car


        #region Brand
        public Task<IList<CarBrandDTO>> GetBrand()
        {
            return Task.FromResult(_carService.GetBrand());
        }

        public void InsertBrand(CarBrandDTO brand)
        {
            _carService.InsertBrand(brand);
        }

        public void UpdateBrand(CarBrandDTO brand)
        {
            _carService.UpdateBrand(brand);
        }

        public void DeleteBrand(CarBrandDTO brand)
        {
            _carService.DeleteBrand(brand);
        }
        #endregion Brand


        #region Type

        public new Task<IList<CarTypeDTO>> GetType()
        {
            return Task.FromResult(_carService.GetType());
        }

        public void InsertType(CarTypeDTO type)
        {
            _carService.InsertType(type);
        }

        public void UpdateType(CarTypeDTO type)
        {
            _carService.UpdateType(type);
        }

        public void DeleteType(CarTypeDTO type)
        {
            _carService.DeleteType(type);
        }
        #endregion Type


        #region Class
        public Task<IList<CarClassDTO>> GetClass()
        {
            return Task.FromResult(_carService.GetClass());
        }

        public void InsertClass(CarClassDTO cls)
        {
            _carService.InsertClass(cls);
        }

        public void UpdateClass(CarClassDTO cls)
        {
            _carService.UpdateClass(cls);
        }

        public void DeleteClass(CarClassDTO cls)
        {
            _carService.DeleteClass(cls);
        }
        #endregion Class
    }
}
