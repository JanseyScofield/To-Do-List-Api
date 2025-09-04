namespace Domain.Interfaces
{
    public interface IModel<TEntity, TKey> where TEntity : IIdentifyEntity<TKey>
    {
        public void ConvertDomainToModel(TEntity entity);
    }
}
