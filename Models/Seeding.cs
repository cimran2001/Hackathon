namespace Hackathon.Models;

public class Seeding {
    public uint Id { get; set; }
    public uint IntervalCM { get; set; }
    public bool Standart { get; set; }

    public override string ToString()
    {
        return $"{IntervalCM} {Standart}";
    }
}