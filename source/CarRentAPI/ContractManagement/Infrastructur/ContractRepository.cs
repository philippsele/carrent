using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.ContractManagement.Domain;

namespace CarRentAPI.ContractManagement.Infrastructur
{
    public class ContractRepository : IContractRepository
    {

        public Contract GetById(int id)
        {
            return new Contract();
        }

        public IList<Contract> GetContracts()
        {
            return new List<Contract>();
        }

        public void InsertContract(Contract contract)
        {
            
        }

        public void UpdateContract(Contract contract)
        {
            
        }
        public void DeleteContract(Contract contract)
        {
            
        }
    }
}
