using System.Text;

namespace Composite.Task1;

public class InputText : ITag
{
    //<inputText name='myInput' value='myInputValue'/> 
    public string Name { get; set; }
    public string Value { get; set; }
    public List<ITag> SubTags { get; }

    public InputText(string name, string value)
    {
        Name = name;
        Value = value;
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
        if (SubTags.Any())
        {
            var result = new StringBuilder();
            result.AppendLine($"{prefix}<inputText name='{Name}' value='{Value}'>");
            foreach (var subTag in SubTags)
            {
                result.AppendLine($"{subTag.ConvertToString(depth + 1)}");
            }

            result.Append($"{prefix}</inputText>");
            return result.ToString();
        }

        return $"{prefix}<inputText name='{Name}' value='{Value}'/>";
    }
}