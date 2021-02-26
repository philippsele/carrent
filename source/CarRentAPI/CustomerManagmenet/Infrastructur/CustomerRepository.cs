using System;
using System.Collections.Generic;
using System.Linq;
using CarRentAPI.CustomerManagmenet.Domain;
using CarRentAPI.Common;

namespace CarRentAPI.CustomerManagmenet.Infrastructur
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerModelMappingService _mapping;
        private readonly SqlDataAccess _sqlDataAccess;
        public CustomerRepository()
        {
            _mapping = new CustomerModelMappingService();
            _sqlDataAccess = new SqlDataAccess();
        }

        public IList<Customer> Get()
        {
            var sql = "Select CustomerId, FirstName, LastName, Street, City from Customer";
            return _mapping.MappingCustomerModels(_sqlDataAccess.LoadData<CustomerModel>(sql).ToList());
        }

        public Customer GetById(int id)
        {
            var sql = "Select CustomerId, FirstName, LastName, Street, City from Customer Where CustomerId = " + id;
            return _mapping.MappingCustomerModel(_sqlDataAccess.LoadDataById<CustomerModel>(sql));
        }

        public IList<Customer> FindByName(string name)
        {
            var sql = "Select CustomerId, FirstName, LastName, Street, City from Customer Where FirstName like '%" + name + "%' or LastName like '%" + name + "%'";
            return _mapping.MappingCustomerModels(_sqlDataAccess.LoadData<CustomerModel>(sql).ToList());
        }

        public void Insert(Customer customer)
        {
            var sql =
                "Insert into Customer (FirstName, LastName, Street, City) values ('" + customer.FirstName + "', '" + customer.LastName + "', '" + customer.Street + "', '" + customer.City + "')";
            _sqlDataAccess.SaveData(sql);
        }

        public void Update(Customer customer)
        {
            var sql =
                "Update Customer set Firstname = '" + customer.FirstName + "', Lastname = '" + customer.LastName + "', Street = '" + customer.Street + "', City = '" + customer.City + "' where CustomerId = " + customer.CustomerId;
            _sqlDataAccess.SaveData(sql);
        }
        public void Delete(Customer customer)
        {
            var sql = "Delete from Customer where CustomerId = " + customer.CustomerId;
            _sqlDataAccess.SaveData(sql);
        }
    }
}

