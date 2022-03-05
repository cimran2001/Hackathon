namespace Hackathon.Models;

public class AutumnPloughing : Ploughing {
    public override string ToString()
    {
        return $"Autumn Ploughing: {AppliedHA} {Date?.ToShortDateString()} {Depth}";
    }
}
