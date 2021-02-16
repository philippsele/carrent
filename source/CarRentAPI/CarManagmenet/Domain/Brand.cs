using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentAPI.Common;

namespace CarRentAPI.CarManagmenet.Domain
{
    public class Brand : EntityBase
    {
        private List<Model> _models;

        public Brand()
        {
            _models = new List<Model>();
        }

        public IReadOnlyList<Model> Models => _models;
    }
}
