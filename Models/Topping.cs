namespace Hackathon.Models;

public class Topping {
    public int Id { get; set; }
    public double AppliedHA { get; set; }
    public bool Spraying { get; set; }

    public override string ToString()
    {
        return $"{AppliedHA} {Spraying}";
    }
}