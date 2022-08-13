namespace Composite.Task2;

public interface ITag
{
    void Add(ITag subTag);
    void Remove(ITag subTag);
    string ConvertToString(int depth = 0);
}