namespace Hackathon.Models;

public class Farmer {
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public override string ToString()
    {
        return $"Farmer {Name}";
    }
}