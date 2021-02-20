using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagement.Api;
using CarRentAPI.CarManagement.Domain;

namespace CarRentAPI.CarManagement.Api
{
    public interface ICarService
    {
        IList<CarDTO> GetCars();
        CarDTO GetById(int id);
        IList<CarDTO> FindByType(Guid type);
        IList<CarDTO> FindByClass(Guid cls);
        IList<CarDTO> FindByBrand(Guid brand);
        void InsertCar(CarDTO car);
        void UpdateCar(CarDTO car);
        void DeleteCar(CarDTO car);


        IList<CarBrandDTO> GetBrand();
        void InsertBrand(CarBrandDTO brand);
        void UpdateBrand(CarBrandDTO brand);
        void DeleteBrand(CarBrandDTO brand);


        IList<CarTypeDTO> GetType();
        void InsertType(CarTypeDTO type);
        void UpdateType(CarTypeDTO type);
        void DeleteType(CarTypeDTO type);


        IList<CarClassDTO> GetClass();
        void InsertClass(CarClassDTO cls);
        void UpdateClass(CarClassDTO cls);
        void DeleteClass(CarClassDTO cls);
    }
}
