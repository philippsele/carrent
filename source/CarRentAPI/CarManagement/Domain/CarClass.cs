﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CarManagement.Domain
{
    public class CarClass
    {
        public int ClassId { get; set; }
        public string Class { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
