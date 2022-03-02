using Methodical.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Methodical.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly MethodicalDBContext _dbContext;
        protected readonly DbSet<TEntity> entityDbSet;

        public Repository(MethodicalDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            entityDbSet = _dbContext.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await entityDbSet.AsQueryable().ToListAsync().ConfigureAwait(false);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await entityDbSet.AsNoTracking().Where(predicate).FirstOrDefaultAsync().ConfigureAwait(false);
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await entityDbSet.AsNoTracking().Where(predicate).ToListAsync().ConfigureAwait(false);
        }

        public async void Add(TEntity entity)
        {
            await entityDbSet.AddAsync(entity).ConfigureAwait(false);
        }

        public async void AddRange(IEnumerable<TEntity> entities)
        {
            await entityDbSet.AddRangeAsync(entities).ConfigureAwait(false);
        }

        public void Remove(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached) entityDbSet.Attach(entity);
            entityDbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (_dbContext.Entry(entity).State == EntityState.Detached) entityDbSet.Attach(entity);
                entityDbSet.Remove(entity);
            }
        }

        public void Update(TEntity entity)
        {
            entityDbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
