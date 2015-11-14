using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// An Entity Framework implementation of <see cref="IRepository{TEntity}"/>.
    /// </summary>
    public class EntityFrameworkRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        protected readonly DbSet<TEntity> DbSet;

        public EntityFrameworkRepository(DbContext dbContext)
        {
            DbSet = dbContext.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            return DbSet.FindAsync(id);
        }

        public ICollection<TEntity> GetRange(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate).ToList();
        }

        public Task<ICollection<TEntity>> GetRangeAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return GetCollectionAsync(() => DbSet.Where(predicate).ToListAsync());
        }

        public ICollection<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public Task<ICollection<TEntity>> GetAllAsync()
        {
            return GetCollectionAsync(() => DbSet.ToListAsync());
        }

        private static async Task<ICollection<TEntity>> GetCollectionAsync(Func<Task<List<TEntity>>> func)
        {
            // We can't return the task directly as ToListAsync returns a Task<List> and Task's generic parameter isn't covariant.
            var res = await func().ConfigureAwait(false);
            return res;
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }
    }
}