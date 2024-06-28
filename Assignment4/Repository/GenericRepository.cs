using Assignment4.DataModel;

namespace Assignment4.Repository;

public class GenericRepository<T>: IRepository<T> where T : Entity
{
    private List<T> _items;

    public GenericRepository()
    {
        _items = new List<T>();
    }

    public void Add(T item)
    {
        _items.Add(item);
    }

    public void RemoveProduct(T item)
    {
        if (_items.Contains(item))
        {
            _items.Remove(item);
        }
    }

    public void Save()
    {
        
    }

    public IEnumerable<T> GetAll()
    {
        return _items.ToList();
    }

    public T GetById(int id)
    {
        foreach (var item in _items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        throw new InvalidOperationException();
    }
    
}