using Library.Models.Enum;
using Library.Models;

namespace Library.Builders;

public class ContentBuilder
{
    private readonly Content _content = new Content();

    public ContentBuilder WithParts(string text)
    {
        _content.Parts.Add(new Part { Text = text });
        return this;
    }

    public ContentBuilder WithRole(Role role)
    {
        _content.Role = role;
        return this;
    }

    public Content Build()
    {
        return _content;
    }
}

