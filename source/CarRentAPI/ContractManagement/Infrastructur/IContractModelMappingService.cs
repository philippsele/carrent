using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.ContractManagement.Domain;

namespace CarRentAPI.ContractManagement.Infrastructur
{
    public interface IContractModelMappingService
    {
        IList<Contract> MappingContractModels(IList<ContractModel> contract);
        Contract MappingContractModel(ContractModel contract);
    }
}
