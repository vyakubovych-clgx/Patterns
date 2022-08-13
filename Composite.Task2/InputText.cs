namespace Composite.Task2;

public class InputText : ITag
{
    //<inputText name='myInput' value='myInputValue'/> 
    public string Name { get; set; }
    public string Value { get; set; }

    public InputText(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public void Add(ITag subTag)
    {
        throw new InvalidOperationException("Can't add subtags to input");
    }

    public void Remove(ITag subTag)
    {
        throw new InvalidOperationException("Can't remove subtags from input");
    }

    public string ConvertToString(int depth = 0) =>
        $"{new string('\t', depth)}<inputText name='{Name}' value='{Value}'/>";
}