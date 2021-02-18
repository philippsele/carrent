﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagmenet.Api;
using CarRentAPI.CarManagmenet.Domain;

namespace CarRentAPI.CarManagemenet.Application
{
    public interface ICarMappingService
    {
        IList<CarDTO> MappingCars(IList<Car> car);
        CarDTO MappingCar(Car car);
        Car MappingCarDTO(CarDTO car);


        IList<CarBrandDTO> MappingCarBrands(IList<CarBrand> brand);
        CarBrand MappingCarBrandDTO(CarBrandDTO brand);


        IList<CarClassDTO> MappingCarClasses(IList<CarClass> cls);
        CarClass MappingCarClassDTO(CarClassDTO cls);


        IList<CarTypeDTO> MappingCarTypes(IList<CarType> type);
        CarType MappingCarTypeDTO(CarTypeDTO type);
    }
}
