namespace Domain.Interfaces
{
    public interface IIdentifyEntity<T>
    {
        T Id { get;}
        string Name { get; }
    }
}
