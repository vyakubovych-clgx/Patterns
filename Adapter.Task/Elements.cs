namespace Adapter.Task;

public class Elements<T> : IElements<T>
{
    private readonly IEnumerable<T> _elements;

    public Elements(IEnumerable<T> elements)
    {
        _elements = elements;
    }

    public IEnumerable<T> GetElements() => _elements;
}