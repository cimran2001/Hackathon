namespace Hackathon.Models;

public class Quality {
    public uint Id { get; set; }
    public uint Score { get; set; }

    public override string ToString()
    {
        return $"{Score}";
    }
}