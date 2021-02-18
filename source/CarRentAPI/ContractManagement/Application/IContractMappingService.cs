using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.ContractManagement.Api;
using CarRentAPI.ContractManagement.Domain;

namespace CarRentAPI.ContractManagement.Application
{
    public interface IContractMappingService
    {
        IList<ContractDTO> MappingContracts(IList<Contract> contracts);
        ContractDTO MappingContract(Contract contract);
        Contract MappingContractDTO(ContractDTO contract);
    }
}
