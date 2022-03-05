namespace Hackathon.Models;

public class Fertilizing {
    public int Id { get; set; }
    public double AppliedHA { get; set; }
    public bool Integrity { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
        return $"{AppliedHA} {Integrity} {Date.ToShortDateString()}";
    }
}