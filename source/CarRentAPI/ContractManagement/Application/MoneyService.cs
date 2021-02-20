using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.ContractManagement.Application
{
    public class MoneyService
    {
        public decimal CalculateTotal(int days, decimal costs)
        {
            return days * costs;
        }
    }
}
