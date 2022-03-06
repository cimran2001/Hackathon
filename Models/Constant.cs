namespace Hackathon.Models;

public class Constant {
    public uint Id { get; set; }
    public string Name { get; set; } = null!;
    public int Value { get; set; }
    public string? Description { get; set; }

    public override string ToString()
    {
        return $"{Id} {Name} {Value} {Description}";
    }
}