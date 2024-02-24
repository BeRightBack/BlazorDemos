namespace BlazorLocalizationDemo.Services;
public interface IGenericService<TEntity, TContext> where TEntity : class
{
    IEnumerable<TEntity> GetAll();
    Task<IEnumerable<TEntity>> GetAllAsync();
    TEntity Get(Guid id);
    Task<TEntity> GetAsync(Guid id);
    void Add(TEntity entity);
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    Task UpdateAsync(TEntity entity);
    void Delete(TEntity entity);
    Task DeleteAsync(TEntity entity);
    void Delete(IList<Guid> ids);
    Task DeleteAsync(IList<Guid> ids);
}