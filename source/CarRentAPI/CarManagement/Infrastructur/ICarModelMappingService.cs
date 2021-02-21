using System.Collections.Generic;
using CarRentAPI.CarManagement.Domain;

namespace CarRentAPI.CarManagement.Infrastructur
{
    public interface ICarModelMappingService
    {
        IList<Car> MappingCarModels(IList<CarModel> cars);
        Car MappingCarModel(CarModel car);

        IList<CarType> MappingCarTypeModels(IList<CarTypeModel> type);
        CarType MappingCarTypeModel(CarTypeModel type);

        IList<CarBrand> MappingCarBrandModels(IList<CarBrandModel> brand);
        CarBrand MappingCarBrandModel(CarBrandModel brand);

        IList<CarClass> MappingCarClassModels(IList<CarClassModel> cls);
        CarClass MappingCarClassModel(CarClassModel cls);
        CarClassModel MappingCarClass(CarClass cls);
    }
}
