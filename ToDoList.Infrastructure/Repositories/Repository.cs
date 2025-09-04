using Domain.Interfaces;

namespace ToDoList.Infrastructure.Repositories
{
    public class Repository<T, TEntity, TKey> : IRepository<T, TEntity, TKey> where TEntity : IIdentifyEntity<TKey> where T : IModel<TEntity, TKey>, new()
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
                var model = new T();
                model.ConvertDomainToModel(entity);
                await _context.model.AddAsync(model);
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
