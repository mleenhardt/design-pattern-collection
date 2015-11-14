using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// An <see cref="IRepository{TEntity}"/> implementation that uses a <see cref="HashSet{T}"/> as its underlying data store.
    /// </summary>
    public class InMemoryRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        protected readonly HashSet<TEntity> _hashSet;

        public InMemoryRepository()
        {
            _hashSet = new HashSet<TEntity>();
        }

        public InMemoryRepository(IEnumerable<TEntity> entities)
        {
            _hashSet = new HashSet<TEntity>(entities);
        }
        
        public TEntity GetById(int id)
        {
            return _hashSet.FirstOrDefault(e => e.Id == id);
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            return Task.FromResult(GetById(id));
        }

        public ICollection<TEntity> GetRange(Expression<Func<TEntity, bool>> predicate)
        {
            return _hashSet.AsQueryable().Where(predicate).ToList();
        }

        public Task<ICollection<TEntity>> GetRangeAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Task.FromResult(GetRange(predicate));
        }

        public ICollection<TEntity> GetAll()
        {
            return _hashSet.ToList();
        }

        public Task<ICollection<TEntity>> GetAllAsync()
        {
            return Task.FromResult(GetAll());
        }

        public void Add(TEntity entity)
        {
            _hashSet.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _hashSet.Remove(entity);
        }
    }
}