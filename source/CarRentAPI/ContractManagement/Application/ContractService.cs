using CarRentAPI.ContractManagement.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.CarManagemenet.Application;
using CarRentAPI.CarManagmenet.Api;
using CarRentAPI.CarManagmenet.Domain;
using CarRentAPI.ContractManagement.Domain;
using CarRentAPI.CustomerManagmenet.Application;

namespace CarRentAPI.ContractManagement.Application
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _contractRepository;
        private readonly IContractMappingService _mapping;

        public ContractService(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
            _mapping = new ContractMappingService();
        }

        public IEnumerable<ContractDTO> GetContracts()
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
