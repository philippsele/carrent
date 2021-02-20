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
                },
                Status = Enum.TryParse(nameof(c.Status), out Status st) ? st : Status.Reservation,
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
                },
                Status = Enum.TryParse(nameof(c.Status), out Status st) ? st : Status.Reservation,
                Days = c.Days,
                Total = c.Total
            };
            return returnContract;
        }
    }
}
