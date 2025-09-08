using Domain.Exceptions;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Infrastructure.Repositories
{
    
    public class Repository<TModel, TEntity, TKey> : IRepository<TModel, TEntity, TKey> where TEntity : IIdentifyEntity<TKey> where TModel : class, IModel<TEntity, TKey>, new()
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
                var model = new TModel();
                model.ConvertDomainToModel(entity);
                await _context.Set<TModel>().AddAsync(model);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in create " + ex.Message);
            }
        }

        public async Task DeleteById(TKey id)
        {
            try
            {
                var entityToDelete = _context.Set<TModel>().Find(id);
                if (entityToDelete is null)
                {
                    throw new EntityNotFoundException("Entity not found");
                }
                _context.Set<TModel>().Remove(entityToDelete);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in delete " + ex.Message);
            }
        }

        public async Task<IEnumerable<TModel>> GetAll()
        {
            try{
                return await _context.Set<TModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in get all " + ex.Message);
            }
        }

        public async Task<TModel>? GetById(TKey id)
        {
            try
            {
                var entity = await _context.Set<TModel>().FindAsync(id);
                if (entity is null)
                {
                    throw new EntityNotFoundException("Entity not found");
                }
                return entity;
            }
            catch(Exception ex)
            {
                throw new Exception("Error in get by id " + ex.Message);
            }
        }

        public async Task Update(TEntity entity)
        {
            try
            {
                var entityToUpdate = _context.Set<TModel>().Find(entity.Id);
                if (entityToUpdate is null)
                {
                    throw new EntityNotFoundException("Entity not found");
                }
                entityToUpdate.ConvertDomainToModel(entity);
                _context.Set<TModel>().Update(entityToUpdate);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in update " + ex.Message);
            }
        }
    }
}
