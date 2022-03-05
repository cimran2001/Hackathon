namespace Hackathon.Models;

public class Planting {
    public int Id { get; set; }
    public double AppliedHA { get; set; }
    public DateTime Date { get; set; }
    public int PlantPopulation { get; set; }

    public override string ToString()
    {
        return $"{AppliedHA} {Date.ToShortDateString()} {PlantPopulation}";
    }
}
