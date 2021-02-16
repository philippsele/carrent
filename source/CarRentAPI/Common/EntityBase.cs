using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.Common
{
    public abstract class EntityBase : IEquatable<EntityBase>
    {
        private Guid _id;

        protected EntityBase()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id => _id;

        public override bool Equals(object obj)
        {
            return Equals(obj as EntityBase);
        }

        public bool Equals(EntityBase other)
        {
            return other != null && _id.Equals(other._id);
        }
    }
}
