using Domain.Interfaces;

namespace ToDoList.Infrastructure.Repositories
{
    public class Repository<T, TEntity, TKey> : IRepository<T, TEntity, TKey> where TEntity : IIdentifyEntity<TKey> where T : IModal<TEntity, TKey>, new()
    {
        private AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(TEntity entity)
        {
            try
            {
                var modal = new T();
                modal.ConvertDomainToModel(entity);
                await _context.Set<T>().AddAsync(modal);
            }
            catch(Exception ex)
            {
                throw new Exception("Error in create " + ex.Message);
            }
        }

        public Task DeleteById(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T>? GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
