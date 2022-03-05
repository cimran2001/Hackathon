namespace Hackathon.Models;

public class SpringPloughing : Ploughing {
    public override string ToString()
    {
        return $"Spring Ploughing: {AppliedHA} {Date.ToShortDateString()} {Depth}";
    }
}