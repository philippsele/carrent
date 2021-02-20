using System;
using System.Collections.Generic;
using System.Linq;
using CarRentAPI.CarManagement.Domain;
using CarRentAPI.Common;

namespace CarRentAPI.CarManagement.Infrastructur
{
    public class CarRepository : ICarRepository
    {
        private readonly ICarModelMappingService _mapping;
        private readonly SqlDataAccess _sqlDataAccess;
        public CarRepository()
        {
            _mapping = new CarModelMappingService();
            _sqlDataAccess = new SqlDataAccess();
        }

        #region Car
        public IList<Car> GetCars()
        {
            string sql = "Select CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand from CarV";
            return _mapping.MappingCarModels(_sqlDataAccess.LoadData<CarModel>(sql).ToList());
        }
        public Car GetById(int id)
        {
            string sql = "Select CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand from CarV where CarId = " + id;
            return _mapping.MappingCarModel(_sqlDataAccess.LoadDataById<CarModel>(sql));
        }
        public IList<Car> FindByType(Guid type)
        {
            string sql = "Select CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand from CarV where TypeId = '" + type + "'";
            return _mapping.MappingCarModels(_sqlDataAccess.LoadData<CarModel>(sql).ToList());
        }
        public IList<Car> FindByClass(Guid cls)
        {
            string sql = "Select CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand from CarV where ClassId = '" + cls + "'";
            return _mapping.MappingCarModels(_sqlDataAccess.LoadData<CarModel>(sql).ToList());
        }
        public IList<Car> FindByBrand(Guid brand)
        {
            string sql = "Select CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand from CarV where BrandId = '" + brand + "'";
            return _mapping.MappingCarModels(_sqlDataAccess.LoadData<CarModel>(sql).ToList());
        }
        public void InsertCar(Car car)
        {
            string sql = "insert into Car (ClassId, TypeId) values ('" + car.ClassId + "', '" + car.TypeId + "')";
            _sqlDataAccess.SaveData(sql);
        }
        public void UpdateCar(Car car)
        {
            string sql = "update Car set ClassId='" + car.ClassId + "', TypeId='" + car.TypeId + "' where CarId = " + car.CarId;
            _sqlDataAccess.SaveData(sql);
        }
        public void DeleteCar(Car car)
        {
            string sql = "Delete from Car where CarId = " + car.CarId;
            _sqlDataAccess.SaveData(sql);
        }
        #endregion



        #region Brand
        public IList<CarBrand> GetBrand()
        {
            string sql = "Select BrandId, Brand from CarBrand";
            return _mapping.MappingCarBrandModels(_sqlDataAccess.LoadData<CarBrandModel>(sql).ToList());
        }
        public void InsertBrand(CarBrand brand)
        {
            string sql = "insert into CarBrand (BrandId, Brand) values ('" + brand.BrandId + "', '" + brand.Brand + "')";
            _sqlDataAccess.SaveData(sql);
        }
        public void UpdateBrand(CarBrand brand)
        {
            string sql = "update CarBrand set Brand='" + brand.Brand + "' where BrandId = " + brand.BrandId;
            _sqlDataAccess.SaveData(sql);
        }
        public void DeleteBrand(CarBrand brand)
        {
            string sql = "Delete from CarBrand where BrandId = " + brand.BrandId;
            _sqlDataAccess.SaveData(sql);
        }
        #endregion



        #region Type
        public IList<CarType> GetType()
        {
            string sql = "Select TypeId, Type, BrandId, Brand from CarVtype";
            return _mapping.MappingCarTypeModels(_sqlDataAccess.LoadData<CarTypeModel>(sql).ToList());
        }
        public void InsertType(CarType type)
        {
            string sql = "insert into CarType (TypeId, Type, BrandId) values ('" + type.TypeId + "', '" + type.Type + "', '" + type.BrandId + "')";
            _sqlDataAccess.SaveData(sql);
        }
        public void UpdateType(CarType type)
        {
            string sql = "update CarType set Type='" + type.Type + "', BrandId='" + type.BrandId + "' where TypeId = " + type.TypeId;
            _sqlDataAccess.SaveData(sql);
        }
        public void DeleteType(CarType type)
        {
            string sql = "Delete from CarType where TypeId = " + type.TypeId;
            _sqlDataAccess.SaveData(sql);
        }
        #endregion



        #region Class
        public IList<CarClass> GetClass()
        {
            string sql = "Select ClassId, Class from CarClass";
            return _mapping.MappingCarClassModels(_sqlDataAccess.LoadData<CarClassModel>(sql).ToList());
        }
        public void InsertClass(CarClass cls)
        {
            string sql = "insert into CarClass (ClassId, Class, PricePerDay) values ('" + cls.ClassId + "', '" + cls.Class + "', " + cls.PricePerDay + ")";
            _sqlDataAccess.SaveData(sql);
        }
        public void UpdateClass(CarClass cls)
        {
            string sql = "update CarClass set Class='" + cls.Class + "', PricePerDay=" + cls.PricePerDay + " where ClassId = " + cls.ClassId;
            _sqlDataAccess.SaveData(sql);
        }
        public void DeleteClass(CarClass cls)
        {
            string sql = "Delete from CarClass where ClassId = " + cls.ClassId;
            _sqlDataAccess.SaveData(sql);
        }
        #endregion
    }
}
