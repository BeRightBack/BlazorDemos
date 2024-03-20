using Microsoft.EntityFrameworkCore;

namespace BlazorLocalizationDemo.Data.Repository
{
    public class Repository<TEntity, TContext> : IRepository<TEntity, TContext> where TEntity : class where TContext : DbContext
    {
        private readonly TContext context;
        private readonly DbSet<TEntity> entities;

        public Repository(TContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities.AsEnumerable();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public TEntity Get(Guid id)
        {

            return entities.Find(id)!;
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            var result = await entities.FindAsync(id);
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            return result;
        }

        public void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public async Task AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Add(entity);
            await context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Update(entity);
            await context.SaveChangesAsync();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }

    }
}
