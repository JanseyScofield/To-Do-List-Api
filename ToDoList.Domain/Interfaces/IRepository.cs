namespace Domain.Interfaces
{
    public interface IRepository<T,TEntity, TKey> where TEntity : IIdentifyEntity<TKey>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T>? GetById(TKey id);
        public Task Create(TEntity entity);
        public Task Update(TEntity entity);
        public Task DeleteById(TKey id);
    }
}
