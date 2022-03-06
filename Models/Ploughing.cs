namespace Hackathon.Models;

public class Ploughing {
    public uint Id { get; set; }
    public double AppliedHA { get; set; }
    public DateTime Date { get; set; }
    public uint Depth { get; set; }

    public override string ToString()
    {
        return $"{AppliedHA} {Date.ToShortDateString()} {Depth}";
    }
}