// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.ContractManagement.Domain;

namespace CarRentAPI.ContractManagement.Application
{
    public class CalculationService
    {
        public decimal CalcTotal(int days, decimal PricePerDay)
        {
            return days * PricePerDay;
        }
    }
}
