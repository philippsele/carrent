using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.ContractManagement.Domain
{
    public interface IContractRepository
    {
        IList<Contract> GetContracts();
        Contract GetById(int id);
        void InsertContract(Contract contract);
        void UpdateContract(Contract contract);
        void DeleteContract(Contract contract);
    }
}
