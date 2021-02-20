using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.ContractManagement.Application;

namespace CarRentAPI.ContractManagement.Api
{
    public class ContractController
    {
        private readonly IContractService _contractService;
        public ContractController()
        {
            _contractService = new ContractService();
        }
        public Task<IList<ContractDTO>> GetContracts()
        {
            return Task.FromResult(_contractService.GetContracts());
        }

        public Task<ContractDTO> GetContract(int id)
        {
            return Task.FromResult(_contractService.GetContract(id));
        }

        public void AddContract(ContractDTO contract)
        {
            _contractService.AddContract(contract);
        }

        public void EditContract(ContractDTO contract)
        {
            _contractService.EditContract(contract);
        }

        public void DeleteContract(ContractDTO contract)
        {
            _contractService.DeleteContract(contract);
        }
    }
}
