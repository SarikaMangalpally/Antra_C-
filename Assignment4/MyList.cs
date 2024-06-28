namespace Assignment4;

public class MyList<T>
{
    private List<T> _elements = new List<T>();
    
    public void AddItem (T element)
    {
        _elements.Add(element);
    }

    public void Remove(int index)
    {
        _elements.Remove(_elements[index]);
    }

    public bool Contains(T element)
    {
        if(_elements.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Clear()
    {
        _elements.Clear();
    }

    public void InsertAt(T element, int index)
    {
        _elements.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        _elements.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index >= 0)
        {
            return _elements[index];
        }
        throw new ArgumentOutOfRangeException("Index value cannot be negative");
    }
}