using CarRentAPI.ContractManagement.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagement.Application;
using CarRentAPI.CarManagement.Api;
using CarRentAPI.CarManagement.Domain;
using CarRentAPI.ContractManagement.Domain;
using CarRentAPI.ContractManagement.Infrastructur;
using CarRentAPI.CustomerManagmenet.Application;

namespace CarRentAPI.ContractManagement.Application
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _contractRepository;
        private readonly IContractMappingService _mapping;
        private readonly CalculationService _calculationService;

        public ContractService()
        {
            _contractRepository = new ContractRepository();
            _mapping = new ContractMappingService();
            _calculationService = new CalculationService();
        }

        public decimal CalcTotal(int days, decimal pricePerDay)
        {
            return _calculationService.CalcTotal(days, pricePerDay);
        }

        public IList<ContractDTO> GetContracts()
        {
            return _mapping.MappingContracts(_contractRepository.GetContracts());
        }

        public ContractDTO GetContract(int id)
        {
            return _mapping.MappingContract(_contractRepository.GetById(id));
        }

        public void AddContract(ContractDTO contract)
        {
            _contractRepository.InsertContract(_mapping.MappingContractDTO(contract));
        }

        public void EditContract(ContractDTO contract)
        {
            _contractRepository.UpdateContract(_mapping.MappingContractDTO(contract));
        }

        public void DeleteContract(ContractDTO contract)
        {
            _contractRepository.DeleteContract(_mapping.MappingContractDTO(contract));
        }
        
    }
}
