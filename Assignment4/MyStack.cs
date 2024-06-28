namespace Assignment4;

public class MyStack<T>
{
    private List<T> _elements;

    public MyStack()
    {
        _elements = new List<T>();
    }

    public int Count()
    {
        return _elements.Count;
    }

    public void Elements()
    {
        foreach (var element in _elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
    public void Push(T item)
    {
        _elements.Add(item);
    }
    
    public T Pop()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T value = _elements[_elements.Count - 1];
        _elements.Remove(value);
        Console.WriteLine($"Popped the element: {value}");
        return value;
    }
    
}