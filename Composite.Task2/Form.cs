using System.Text;

namespace Composite.Task2;

public class Form : ITag
{
    //<form name='myForm'/> 
    public string Name { get; set; }
    public List<ITag> SubTags { get; }

    public Form(string name)
    {
        Name = name;
        SubTags = new List<ITag>();
    }

    public void Add(ITag subTag)
    {
        SubTags.Add(subTag);
    }

    public void Remove(ITag subTag)
    {
        SubTags.Remove(subTag);
    }

    public string ConvertToString(int depth = 0)
    {
        var prefix = new string('\t', depth);
        if (!SubTags.Any()) 
            return $"{prefix}<form name='{Name}'/>";

        var result = new StringBuilder();
        result.AppendLine($"{prefix}<form name='{Name}'>");
        foreach (var subTag in SubTags)
        {
            result.AppendLine($"{subTag.ConvertToString(depth + 1)}");
        }

        result.Append($"{prefix}</form>");
        return result.ToString();
    }
}