using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagement.Api;
using CarRentAPI.CarManagement.Domain;

namespace CarRentAPI.CarManagement.Application
{
    public class CarMappingService : ICarMappingService
    {
        public IList<CarDTO> MappingCars(IList<Car> car)
        {
            var returnList = car.Select(c => new CarDTO()
            {
                CarId = c.CarId,
                TypeId = c.Type.TypeId,
                Type = c.Type.Type,
                Brand = c.Type.Brand.Brand,
                ClassId = c.ClassId,
                Class = c.Class.Class.ToString(),
                PricePerDay = c.Class.PricePerDay
            }).ToList();
            return returnList;
        }

        public CarDTO MappingCar(Car car)
        {
            var returnCar = new CarDTO
            {
                CarId = car.CarId,
                TypeId = car.Type.TypeId,
                Type = car.Type.Type,
                Brand = car.Type.Brand.Brand,
                ClassId = car.ClassId,
                Class = car.Class.Class.ToString(),
                PricePerDay = car.Class.PricePerDay
            };
            return returnCar;
        }

        public Car MappingCarDTO(CarDTO car)
        {
            var returnCar = new Car
            {
                CarId = car.CarId.GetValueOrDefault(-1),
                ClassId = car.ClassId,
                TypeId = car.TypeId
            };
            return returnCar;
        }


        public IList<CarBrandDTO> MappingCarBrands(IList<CarBrand> brand)
        {
            var returnList = brand.Select(b => new CarBrandDTO()
            {
                Brand = b.Brand,
                CarBrandId = b.BrandId
            }).ToList();
            return returnList;
        }

        public CarBrand MappingCarBrandDTO(CarBrandDTO brand)
        {
            var returnBrand = new CarBrand
            {
                Brand = brand.Brand,
                BrandId = brand.CarBrandId.GetValueOrDefault(Guid.NewGuid())
            };
            return returnBrand;
        }


        public IList<CarClassDTO> MappingCarClasses(IList<CarClass> cls)
        {
            var returnList = cls.Select(c => new CarClassDTO()
            {
                CarClassId = c.ClassId,
                Class = c.Class.ToString(),
                PricePerDay = c.PricePerDay
            }).ToList();
            return returnList;
        }

        public CarClass MappingCarClassDTO(CarClassDTO cls)
        {
            var returnClass = new CarClass
            {
                ClassId = cls.CarClassId,
                Class = cls.Class,
                PricePerDay = cls.PricePerDay
            };
            return returnClass;
        }


        public IList<CarTypeDTO> MappingCarTypes(IList<CarType> type)
        {
            var returnList = type.Select(t => new CarTypeDTO()
            {
                CarTypeId = t.TypeId,
                Type = t.Type,
                BrandId = t.BrandId,
                Brand = t.Brand.Brand
            }).ToList();
            return returnList;
        }

        public CarType MappingCarTypeDTO(CarTypeDTO type)
        {
            var returnType = new CarType
            {
                TypeId = type.CarTypeId.GetValueOrDefault(Guid.NewGuid()),
                Type = type.Type,
                BrandId = type.BrandId
            };
            return returnType;
        }
    }
}
