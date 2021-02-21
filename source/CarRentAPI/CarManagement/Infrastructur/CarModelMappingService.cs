using CarRentAPI.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRentAPI.CarManagement.Infrastructur
{
    public class CarModelMappingService : ICarModelMappingService
    {
        public IList<Car> MappingCarModels(IList<CarModel> cars)
        {
            var returnList = cars.Select(c => new Car()
            {
                CarId = c.CarId,
                ClassId = c.ClassId,
                Class = new CarClass()
                {
                    ClassId = c.ClassId,
                    Class = c.Class,
                    PricePerDay = c.PricePerDay
                },
                TypeId = Guid.Parse(c.TypeId),
                Type = new CarType()
                {
                    TypeId = Guid.Parse(c.TypeId),
                    Type = c.Type,
                    BrandId = Guid.Parse(c.BrandId),
                    Brand = new CarBrand()
                    {
                        BrandId = Guid.Parse(c.BrandId),
                        Brand = c.Brand
                    }
                }
            }).ToList();
            return returnList;
        }

        public Car MappingCarModel(CarModel car)
        {
            var returnCar = new Car
            {
                CarId = car.CarId,
                ClassId = car.ClassId,
                Class = new CarClass()
                {
                    ClassId = car.ClassId,
                    Class = car.Class,
                    PricePerDay = car.PricePerDay
                },
                TypeId = Guid.Parse(car.TypeId),
                Type = new CarType()
                {
                    TypeId = Guid.Parse(car.TypeId),
                    Type = car.Type,
                    BrandId = Guid.Parse(car.BrandId),
                    Brand = new CarBrand()
                    {
                        BrandId = Guid.Parse(car.BrandId),
                        Brand = car.Brand
                    }
                }
            };
            return returnCar;
        }

        public IList<CarType> MappingCarTypeModels(IList<CarTypeModel> type)
        {
            var returnList = type.Select(c => new CarType()
            {
                TypeId = Guid.Parse(c.TypeId),
                Type = c.Type,
                BrandId = Guid.Parse(c.BrandId),
                Brand = new CarBrand()
                {
                    BrandId = Guid.Parse(c.BrandId),
                    Brand = c.Brand
                }
            }).ToList();
            return returnList;
        }

        public CarType MappingCarTypeModel(CarTypeModel type)
        {
            var returnCarType = new CarType()
            {
                TypeId = Guid.Parse(type.TypeId),
                Type = type.Type,
                BrandId = Guid.Parse(type.BrandId),
                Brand = new CarBrand()
                {
                    BrandId = Guid.Parse(type.BrandId),
                    Brand = type.Brand
                }
            };
            return returnCarType;
        }

        public IList<CarBrand> MappingCarBrandModels(IList<CarBrandModel> brand)
        {
            var returnList = brand.Select(c => new CarBrand()
            {
                BrandId = Guid.Parse(c.BrandId),
                Brand = c.Brand
            }).ToList();
            return returnList;
        }

        public CarBrand MappingCarBrandModel(CarBrandModel brand)
        {
            var returnCarBrand = new CarBrand()
            {
                BrandId = Guid.Parse(brand.BrandId),
                Brand = brand.Brand
            };
            return returnCarBrand;
        }

        public IList<CarClass> MappingCarClassModels(IList<CarClassModel> cls)
        {
            var returnList = cls.Select(c => new CarClass()
            {
                ClassId = c.ClassId,
                Class = c.Class,
                PricePerDay = c.PricePerDay
            }).ToList();
            return returnList;
        }

        public CarClass MappingCarClassModel(CarClassModel cls)
        {
            var returnCarClass = new CarClass()
            {
                ClassId = cls.ClassId,
                Class = cls.Class,
                PricePerDay = cls.PricePerDay
            };
            return returnCarClass;
        }

        public CarClassModel MappingCarClass(CarClass cls)
        {
            var returnCarClass = new CarClassModel()
            {
                ClassId = cls.ClassId,
                Class = cls.Class,
                PricePerDay = cls.PricePerDay
            };
            return returnCarClass;
        }
    }
}
