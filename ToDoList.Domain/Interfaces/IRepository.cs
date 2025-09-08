namespace Domain.Interfaces
{
    public interface IRepository<TModel,TEntity, TKey> where TEntity : IIdentifyEntity<TKey> where TModel : class, IModel<TEntity, TKey>, new()
    {
        public Task<IEnumerable<TModel>> GetAll();
        public Task<TModel>? GetById(TKey id);
        public Task Create(TEntity entity);
        public Task Update(TEntity entity);
        public Task DeleteById(TKey id);
    }
}
