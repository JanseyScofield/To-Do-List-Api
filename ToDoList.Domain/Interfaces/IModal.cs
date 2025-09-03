namespace Domain.Interfaces
{
    public interface IModal<TEntity, TKey> where TEntity : IIdentifyEntity<TKey>
    {
        public void ConvertDomainToModel(TEntity entity);
    }
}
