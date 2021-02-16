using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentAPI.Common
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(Guid id);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
