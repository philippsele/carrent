using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.ContractManagement.Api;

namespace CarRentAPI.ContractManagement.Application
{
    public interface IContractService
    {
        IList<ContractDTO> GetContracts();
        ContractDTO GetContract(int id);
        decimal CalcTotal(int days, decimal PricePerDay);
        void AddContract(ContractDTO contract);
        void EditContract(ContractDTO contract);
        void DeleteContract(ContractDTO contract);
    }
}
