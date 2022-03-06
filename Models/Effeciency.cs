namespace Hackathon.Models;

public class Efficiency {
    public uint Id { get; set; }
    public uint Tons { get; set; }

    public override string ToString()
    {
        return $"{Tons}";
    }
}