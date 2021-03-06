namespace Hackathon.Models;

public class Cultivation {
    public uint Id { get; set; }
    public double AppliedHA { get; set; }
    public uint NumberOfTimes { get; set; }

    public override string ToString()
    {
        return $"{AppliedHA} {NumberOfTimes}";
    }
}
