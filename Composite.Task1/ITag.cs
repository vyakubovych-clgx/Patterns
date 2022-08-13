namespace Composite.Task1;

public interface ITag
{
    void Add(ITag subTag);
    void Remove(ITag subTag);
    string ConvertToString(int depth = 0);
}