using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.Common;

namespace CarRentAPI.CarManagmenet.Domain
{
    public class CarClass : EntityBase
    {
        private string _name;

        private decimal _dailyFee;

        public CarClass()
        {
        }

        public CarClass(string name, decimal dailyFee)
        {
            _name = name;
            _dailyFee = dailyFee;
        }

        public string Name => _name;

        public decimal DailyFee => _dailyFee;
    }
}
