using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.CustomerManagmenet.Domain
{
    class Customer
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Strasse { get; set; }
        public string Ort { get; set; }
        public int Kundennummer { get; set; }

        public Customer()
        {
            
        }
    }
}
