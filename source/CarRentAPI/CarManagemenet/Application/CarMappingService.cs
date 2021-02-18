using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagmenet.Api;
using CarRentAPI.CarManagmenet.Domain;

namespace CarRentAPI.CarManagemenet.Application
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
            var returnCar = new CarDTO();
            returnCar.CarId = car.CarId;
            returnCar.TypeId = car.Type.TypeId;
            returnCar.Type = car.Type.Type;
            returnCar.Brand = car.Type.Brand.Brand;
            returnCar.ClassId = car.ClassId;
            returnCar.Class = car.Class.Class.ToString();
            returnCar.PricePerDay = car.Class.PricePerDay;
            return returnCar;
        }

        public Car MappingCarDTO(CarDTO car)
        {
            var returnCar = new Car();
            returnCar.CarId = car.CarId.GetValueOrDefault(-1);
            returnCar.ClassId = car.ClassId;
            returnCar.TypeId = car.TypeId;
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
            var returnBrand = new CarBrand();
            returnBrand.Brand = brand.Brand;
            returnBrand.BrandId = brand.CarBrandId.GetValueOrDefault(Guid.NewGuid());
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
            var returnClass = new CarClass();
            returnClass.ClassId = cls.CarClassId.GetValueOrDefault(Guid.NewGuid());
            returnClass.Class = Enum.TryParse(nameof(cls.Class), out Class cl) ? cl : Class.Basic;
            returnClass.PricePerDay = cls.PricePerDay;
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
            var returnType = new CarType();
            returnType.TypeId = type.CarTypeId.GetValueOrDefault(Guid.NewGuid());
            returnType.Type = type.Type;
            returnType.BrandId = type.BrandId;
            return returnType;
        }
    }
}
