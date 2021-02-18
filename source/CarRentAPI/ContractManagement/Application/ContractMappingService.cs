using CarRentAPI.ContractManagement.Api;
using CarRentAPI.ContractManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.ContractManagement.Application
{
    public class ContractMappingService : IContractMappingService
    {
        public IList<ContractDTO> MappingContracts(IList<Contract> contracts)
        {
            var returnList = contracts.Select(c => new ContractDTO()
            {
                ContractId = c.ContractId,
                Status = c.Status.ToString(),
                Days = c.Days,
                Total = c.Total,
                CustomerId = c.Customer.CustomerId,
                FirstName = c.Customer.FirstName,
                LastName = c.Customer.LastName,
                Street = c.Customer.Street,
                City = c.Customer.City,
                CarId = c.Car.CarId,
                Type = c.Car.Type.Type,
                Brand = c.Car.Type.Brand.Brand,
                Class = c.Car.Class.Class.ToString(),
                PricePerDay = c.Car.Class.PricePerDay
            }).ToList();
            return returnList;
        }

        public ContractDTO MappingContract(Contract contract)
        {
            var returnContract = new ContractDTO();
            returnContract.ContractId = contract.ContractId;
            returnContract.Status = contract.Status.ToString();
            returnContract.Days = contract.Days;
            returnContract.Total = contract.Total;
            returnContract.CustomerId = contract.Customer.CustomerId;
            returnContract.FirstName = contract.Customer.FirstName;
            returnContract.LastName = contract.Customer.LastName;
            returnContract.Street = contract.Customer.Street;
            returnContract.City = contract.Customer.City;
            returnContract.CarId = contract.Car.CarId;
            returnContract.Type = contract.Car.Type.Type;
            returnContract.Brand = contract.Car.Type.Brand.Brand;
            returnContract.Class = contract.Car.Class.Class.ToString();
            returnContract.PricePerDay = contract.Car.Class.PricePerDay;
            return returnContract;
        }

        public Contract MappingContractDTO(ContractDTO contract)
        {
            var returnContract = new Contract();
            returnContract.ContractId = contract.ContractId.GetValueOrDefault(-1);
            returnContract.Status = Enum.TryParse(nameof(contract.Status), out Status status) ? status : Status.Reservation;
            returnContract.Days = contract.Days;
            returnContract.Total = contract.Total;
            returnContract.CustomerId = contract.CustomerId;
            returnContract.CarId = contract.CarId;
            return returnContract;
        }
    }
}
