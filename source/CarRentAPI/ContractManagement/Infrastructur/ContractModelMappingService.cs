using CarRentAPI.ContractManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagement.Domain;
using CarRentAPI.CustomerManagmenet.Domain;

namespace CarRentAPI.ContractManagement.Infrastructur
{
    public class ContractModelMappingService : IContractModelMappingService
    {
        public IList<Contract> MappingContractModels(IList<ContractModel> contract)
        {
            var returnList = contract.Select(c => new Contract()
            {
                ContractId = c.ContractId,
                CustomerId = c.CustomerId,
                Customer = new Customer()
                {
                    CustomerId = c.CustomerId,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Street = c.Street,
                    City = c.City
                },
                CarId = c.CarId,
                Car = new Car()
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
                },
                PickedUp = c.PickedUp,
                Days = c.Days,
                Total = c.Total
            }).ToList();
            return returnList;
        }
        public Contract MappingContractModel(ContractModel c)
        {
            var returnContract = new Contract()
            {
                ContractId = c.ContractId,
                CustomerId = c.CustomerId,
                Customer = new Customer()
                {
                    CustomerId = c.CustomerId,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Street = c.Street,
                    City = c.City
                },
                CarId = c.CarId,
                Car = new Car()
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
                },
                PickedUp = c.PickedUp,
                Days = c.Days,
                Total = c.Total
            };
            return returnContract;
        }
    }
}
