using Library.Models.Enum;

namespace Library.Models;

public sealed class Content
{
    public List<Part> Parts { get; set; } = [];
    public Role Role { get; set; }  
}
