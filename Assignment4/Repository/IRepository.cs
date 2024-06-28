using Assignment4.DataModel;

namespace Assignment4.Repository;

public interface IRepository<T> where T: Entity
{
    void Add(T item);
    void RemoveProduct(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}