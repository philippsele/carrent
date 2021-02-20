using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarRentAPI.ContractManagement.Application;
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
            var moneyService = new MoneyService();
            

            //Act
            var check = moneyService.CalculateTotal(5, 4.5m);

            //Assert
            Assert.IsTrue(check == 22.5m);
        }

    }
}
