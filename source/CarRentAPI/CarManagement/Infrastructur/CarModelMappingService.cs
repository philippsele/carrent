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
                    Class = Enum.TryParse(nameof(c.Class), out Class cl) ? cl : Class.Basic,
                    PricePerDay = c.PricePerDay
                },
                TypeId = c.TypeId,
                Type = new CarType()
                {
                    TypeId = c.TypeId,
                    Type = c.Type,
                    BrandId = c.BrandId,
                    Brand = new CarBrand()
                    {
                        BrandId = c.BrandId,
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
                    Class = Enum.TryParse(nameof(car.Class), out Class cl) ? cl : Class.Basic,
                    PricePerDay = car.PricePerDay
                },
                TypeId = car.TypeId,
                Type = new CarType()
                {
                    TypeId = car.TypeId,
                    Type = car.Type,
                    BrandId = car.BrandId,
                    Brand = new CarBrand()
                    {
                        BrandId = car.BrandId,
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
                TypeId = c.TypeId,
                Type = c.Type,
                BrandId = c.BrandId,
                Brand = new CarBrand()
                {
                    BrandId = c.BrandId,
                    Brand = c.Brand
                }
            }).ToList();
            return returnList;
        }

        public CarType MappingCarTypeModel(CarTypeModel type)
        {
            var returnCarType = new CarType()
            {
                TypeId = type.TypeId,
                Type = type.Type,
                BrandId = type.BrandId,
                Brand = new CarBrand()
                {
                    BrandId = type.BrandId,
                    Brand = type.Brand
                }
            };
            return returnCarType;
        }

        public IList<CarBrand> MappingCarBrandModels(IList<CarBrandModel> brand)
        {
            var returnList = brand.Select(c => new CarBrand()
            {
                BrandId = c.BrandId,
                Brand = c.Brand
            }).ToList();
            return returnList;
        }

        public CarBrand MappingCarBrandModel(CarBrandModel brand)
        {
            var returnCarBrand = new CarBrand()
            {
                BrandId = brand.BrandId,
                Brand = brand.Brand
            };
            return returnCarBrand;
        }

        public IList<CarClass> MappingCarClassModels(IList<CarClassModel> cls)
        {
            var returnList = cls.Select(c => new CarClass()
            {
                ClassId = c.ClassId,
                Class = Enum.TryParse(nameof(c.Class), out Class cl) ? cl : Class.Basic,
                PricePerDay = c.PricePerDay
            }).ToList();
            return returnList;
        }

        public CarClass MappingCarClassModel(CarClassModel cls)
        {
            var returnCarClass = new CarClass()
            {
                ClassId = cls.ClassId,
                Class = Enum.TryParse(nameof(cls.Class), out Class cl) ? cl : Class.Basic,
                PricePerDay = cls.PricePerDay
            };
            return returnCarClass;
        }
    }
}
