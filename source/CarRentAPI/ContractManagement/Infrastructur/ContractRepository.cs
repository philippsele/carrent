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
            var sql = "Select ContractId, CustomerId, FirstName, LastName, Street, City, CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand, PickedUp, Days, Total from ContractV";
            return _mapping.MappingContractModels(_sqlDataAccess.LoadData<ContractModel>(sql).ToList());
        }

        public Contract GetById(int id)
        {
            var sql = "Select ContractId, CustomerId, FirstName, LastName, Street, City, CarId, ClassId, Class, PricePerDay, TypeId, Type, BrandId, Brand, PickedUp, Days, Total from ContractV where ContractId = " + id;
            return _mapping.MappingContractModel(_sqlDataAccess.LoadDataById<ContractModel>(sql));
        }

        public void InsertContract(Contract contract)
        {
            var sql = "Insert into Contract (CustomerId, CarId, PickedUp, Days, Total) values (" + contract.CustomerId + ", " + contract.CarId + ", " + contract.PickedUp + ", " + contract.Days + ", " + contract.Total + ")";
            _sqlDataAccess.SaveData(sql);
        }

        public void UpdateContract(Contract contract)
        {
            var sql = "Update Contract set CustomerId=" + contract.CustomerId + ", CarID=" + contract.CarId + ", PickedUp=" + contract.PickedUp + ", Days=" + contract.Days + ", Total=" + contract.Total + " where ContractId=" + contract.ContractId;
            _sqlDataAccess.SaveData(sql);
        }

        public void DeleteContract(Contract contract)
        {
            var sql = "Delete from Contract where ContractId=" + contract.ContractId;
            _sqlDataAccess.SaveData(sql);
        }
    }
}
