using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.Common;

namespace CarRentAPI.CarManagmenet.Domain
{
    public class Car : EntityBase
    {
        private Model _model;

        public Car()
        {
        }

        public Car(Model model)
        {
            _model = model;
        }

        public Model Model => _model;

        public string Name { get; set; }
    }
}
