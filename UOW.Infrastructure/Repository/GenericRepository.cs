using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace UOW.Infrastructure.Repository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected PizzaStoreContext _context;
        protected DbSet<TEntity> dbSet;
        protected readonly ILogger _logger;
        public GenericRepository(
    PizzaStoreContext context,
    ILogger logger)
        {
            _context = context;
            _logger = logger;
            dbSet = _context.Set<TEntity>();
        }
        public Task<bool> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Upsert(TEntity entity, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
