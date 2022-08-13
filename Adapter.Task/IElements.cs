namespace Adapter.Task;

public interface IElements<T>
{
    IEnumerable<T> GetElements();
}