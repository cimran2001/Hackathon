namespace Hackathon.Models;

public class Efficiency {
    public int Id { get; set; }
    public double Tons { get; set; }

    public override string ToString()
    {
        return $"{Tons}";
    }
}