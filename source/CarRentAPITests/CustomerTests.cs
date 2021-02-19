using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarRentAPI.CustomerManagmenet.Domain;
using CarRentAPI.CustomerManagmenet.Infrastructur;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentAPITests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CreateCustomers()
        {
            //Arrange
            var customerRepo = new CustomerRepository();
            var customer1 = new Customer()
            {
                FirstName = "Tteesstt",
                LastName = "asdfasdf",
                Street = "Untere Gschindstrasse 39",
                City = "9497 Triesenberg"
            };
            var customer2 = new Customer()
            {
                FirstName = "Ttteeesssttt",
                LastName = "asdfasdf",
                Street = "Untere Gschindstrasse 39",
                City = "9497 Triesenberg"
            };

            //Act
            customerRepo.Insert(customer1);
            customerRepo.Insert(customer2);

            //Assert
            Assert.IsTrue(customerRepo.FindByName("asdfasdf").Count >= 2);
        }

        [TestMethod]
        public void UpdateCustomer()
        {
            //Arrange
            var customerRepo = new CustomerRepository();
            var customers = customerRepo.FindByName("asdf");

            customers.First().LastName = "asdfasdfasdfasf";

            //Act
            customerRepo.Update(customers.First());

            //Assert
            Assert.IsTrue(customerRepo.FindByName("asdfasdfasdfasf").Count == 1);
        }

        [TestMethod]
        public void GetCustomer()
        {
            //Arrange
            var customerRepo = new CustomerRepository();
            var customers = customerRepo.Get();
            var customer = customers.First();

            //Act
            var newCustomer = customerRepo.GetById(customer.CustomerId);

            //Assert
            Assert.IsTrue(customer.LastName == newCustomer.LastName && customer.FirstName == newCustomer.FirstName);
        }

        [TestMethod]
        public void DeleteCustomer()
        {
            //Arrange
            var customerRepo = new CustomerRepository();
            var customers = customerRepo.FindByName("asdfasdf");

            //Act
            foreach (var c in customers)
            {
                customerRepo.Delete(c);
            }

            //Assert
            Assert.IsTrue(customerRepo.FindByName("asdfasdf").Count == 0);
        }
    }
}
