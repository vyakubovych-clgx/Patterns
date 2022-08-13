namespace Composite.Task1;

public class LabelText : ITag
{
    //<label value='myLabel'/> 
    public string Value { get; set; }

    public LabelText(string value)
    {
        Value = value;
    }

    public void Add(ITag subTag)
    {
        throw new InvalidOperationException("Can't add subtags to label");
    }

    public void Remove(ITag subTag)
    {
        throw new InvalidOperationException("Can't remove subtags from label");
    }


    public string ConvertToString(int depth = 0) => $"{new string('\t', depth)}<label value='{Value}'>";
}