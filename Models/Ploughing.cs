namespace Hackathon.Models;

public class Ploughing {
    public int Id { get; set; }
    public double? AppliedHA { get; set; }
    public DateTime? Date { get; set; }
    public int? Depth { get; set; }

    public override string ToString()
    {
        return $"{AppliedHA} {Date?.ToShortDateString()} {Depth}";
    }
}