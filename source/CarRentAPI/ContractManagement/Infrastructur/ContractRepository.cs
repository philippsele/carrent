using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.Common;
using CarRentAPI.ContractManagement.Domain;

namespace CarRentAPI.ContractManagement.Infrastructur
{
    public class ContractRepository : IContractRepository
    {
        private readonly IContractModelMappingService _mapping;
        private readonly SqlDataAccess _sqlDataAccess;
        public ContractRepository()
        {
            _mapping = new ContractModelMappingService();
            _sqlDataAccess = new SqlDataAccess();
        }
        public IList<Contract> GetContracts()
        {
            string sql = "Select ContractId, CustomerId, FirstName, LastName, Street, City, CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand, Status, Days, Total from ContractV";
            return _mapping.MappingContractModels(_sqlDataAccess.LoadData<ContractModel>(sql).ToList());
        }

        public Contract GetById(int id)
        {
            string sql = "Select ContractId, CustomerId, FirstName, LastName, Street, City, CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand, Status, Days, Total from ContractV where ContractId = " + id;
            return _mapping.MappingContractModel(_sqlDataAccess.LoadDataById<ContractModel>(sql));
        }

        public void InsertContract(Contract contract)
        {
            string sql = "Insert into Contract (CustomerId, CarId, Status, Days, Total) values (" + contract.CustomerId + ", " + contract.CarId + ", " + contract.Status + ", " + contract.Days + ", " + contract.Total + ")";
            _sqlDataAccess.SaveData(sql);
        }

        public void UpdateContract(Contract contract)
        {
            string sql = "Update Contract set CustomerId=" + contract.CustomerId + ", CarID=" + contract.CarId + ", Status=" + contract.Status + ", Days=" + contract.Days + ", Total=" + contract.Total + " where ContractId=" + contract.ContractId;
            _sqlDataAccess.SaveData(sql);
        }

        public void DeleteContract(Contract contract)
        {
            string sql = "Delete from Contract where ContractId=" + contract.ContractId;
            _sqlDataAccess.SaveData(sql);
        }
    }
}
