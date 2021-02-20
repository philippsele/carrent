using System;
using System.Collections.Generic;
using CarRentAPI.CarManagement.Api;
using CarRentAPI.CarManagement.Domain;
using CarRentAPI.CarManagement.Infrastructur;

namespace CarRentAPI.CarManagement.Application
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarMappingService _mapping;

        public CarService()
        {
            _carRepository = new CarRepository();
            _mapping = new CarMappingService();
        }

        #region Car
        public IList<CarDTO> GetCars()
        {
            return _mapping.MappingCars(_carRepository.GetCars());
        }

        public CarDTO GetById(int id)
        {
            return _mapping.MappingCar(_carRepository.GetById(id));
        }

        public IList<CarDTO> FindByType(Guid type)
        {
            return _mapping.MappingCars(_carRepository.FindByType(type));
        }

        public IList<CarDTO> FindByClass(Guid cls)
        {
            return _mapping.MappingCars(_carRepository.FindByClass(cls));
        }

        public IList<CarDTO> FindByBrand(Guid brand)
        {
            return _mapping.MappingCars(_carRepository.FindByBrand(brand));
        }

        public void InsertCar(CarDTO car)
        {
            _carRepository.InsertCar(_mapping.MappingCarDTO(car));
        }

        public void UpdateCar(CarDTO car)
        {
            _carRepository.UpdateCar(_mapping.MappingCarDTO(car));
        }

        public void DeleteCar(CarDTO car)
        {
            _carRepository.DeleteCar(_mapping.MappingCarDTO(car));
        }
        #endregion Car


        #region Brand
        public IList<CarBrandDTO> GetBrand()
        {
            return _mapping.MappingCarBrands(_carRepository.GetBrand());
        }

        public void InsertBrand(CarBrandDTO brand)
        {
            _carRepository.InsertBrand(_mapping.MappingCarBrandDTO(brand));
        }

        public void UpdateBrand(CarBrandDTO brand)
        {
            _carRepository.UpdateBrand(_mapping.MappingCarBrandDTO(brand));
        }

        public void DeleteBrand(CarBrandDTO brand)
        {
            _carRepository.DeleteBrand(_mapping.MappingCarBrandDTO(brand));
        }
        #endregion Brand


        #region Type

        public IList<CarTypeDTO> GetType()
        {
            return _mapping.MappingCarTypes(_carRepository.GetType());
        }

        public void InsertType(CarTypeDTO type)
        {
            _carRepository.InsertType(_mapping.MappingCarTypeDTO(type));
        }

        public void UpdateType(CarTypeDTO type)
        {
            _carRepository.UpdateType(_mapping.MappingCarTypeDTO(type));
        }

        public void DeleteType(CarTypeDTO type)
        {
            _carRepository.DeleteType(_mapping.MappingCarTypeDTO(type));
        }
        #endregion Type


        #region Class
        public IList<CarClassDTO> GetClass()
        {
            return _mapping.MappingCarClasses(_carRepository.GetClass());
        }

        public void InsertClass(CarClassDTO cls)
        {
            _carRepository.InsertClass(_mapping.MappingCarClassDTO(cls));
        }

        public void UpdateClass(CarClassDTO cls)
        {
            _carRepository.UpdateClass(_mapping.MappingCarClassDTO(cls));
        }

        public void DeleteClass(CarClassDTO cls)
        {
            _carRepository.DeleteClass(_mapping.MappingCarClassDTO(cls));
        }
        #endregion Class

    }
}
