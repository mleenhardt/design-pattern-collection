using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// Common interface for all repositories.
    /// </summary>
    /// <typeparam name="TEntity">The <see cref="IEntity"/> type for this repository.</typeparam>
    public interface IRepository<TEntity>
        where TEntity : class, IEntity
    {
        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);
        ICollection<TEntity> GetRange(Expression<Func<TEntity, bool>> predicate);
        Task<ICollection<TEntity>> GetRangeAsync(Expression<Func<TEntity, bool>> predicate);
        ICollection<TEntity> GetAll();
        Task<ICollection<TEntity>> GetAllAsync();
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}