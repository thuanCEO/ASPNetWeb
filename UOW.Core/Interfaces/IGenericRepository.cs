using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace UOW.Core.Entities
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {

        Task<TEntity?> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        Task<bool> Add(TEntity entity);
        Task<bool> Remove(Guid id);
        Task<bool> Upsert(TEntity entity, Guid id);

    }
}
