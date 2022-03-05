using System.ComponentModel.DataAnnotations.Schema;

namespace Hackathon.Models;

public class Farm {
    public int Id { get; set; }
    public uint NO { get; set; }
    public string Region { get; set; } = null!;

    public int? FarmerId { get; set; }
    public virtual Farmer? Farmer { get; set; }

    public uint NumberOfField { get; set; }
    public double HA { get; set; }
    public int? AutumnPloughingId { get; set; }
    public virtual AutumnPloughing? AutumnPloughing { get; set; }
    public int? SpringPloughingId { get; set; }
    public virtual SpringPloughing? SpringPloughing { get; set; }
    public int? SeedingId { get; set; }
    public virtual Seeding? Seeding { get; set; }
    public int? PlantingId { get; set; }
    public virtual Planting? Planting { get; set; }
    public int? IrrigationId { get; set; }
    public virtual Irrigation? Irrigation { get; set; }
    public int? CultivationId { get; set; }
    public virtual Cultivation? Cultivation { get; set; }
    public int? FertilizingId { get; set; }
    public virtual Fertilizing? Fertilizing { get; set; }
    public int? ToppingId { get; set; }
    public virtual Topping? Topping { get; set; }
    public int? EfficiencyId { get; set; }
    public virtual Efficiency? Efficiency { get; set; }
    public int? QualityId { get; set; }
    public virtual Quality? Quality { get; set; }

    private double? pointsAutumn;
    public double GetPointsAutumn() => pointsAutumn ??= Program.GetPointsAutumn(this);
    
    private double? pointsSpring;
    public double GetPointsSpring() => pointsSpring ??= Program.GetPointsSpring(this);
    
    private double? pointsSeeding;
    public double GetPointsSeeding() => pointsSeeding ??= Program.GetPointsSeeding(this);
    
    private double? planting;
    public double GetPointsPlanting() => planting ??= Program.GetPointsPlanting(this);

    private double? irrigation;
    public double GetPointsIrrigation() => irrigation ??= Program.GetPointsIrrigation(this);

    private double? cultivation;
    public double GetPointsCultivation() => cultivation ??= Program.GetPointsCultivation(this);

    private double? fertilizing;
    public double GetPointsFertilizing() => fertilizing ??= Program.GetPointsFertilizing(this);

    private double? topping;
    public double GetPointsTopping() => topping ??= Program.GetPointsTopping(this);

    private double? efficiency;
    public double GetPointsEfficiency() => efficiency ??= Program.GetPointsEfficiency(this);

    private double? quality;
    public double GetPointsQuality() => quality ??= Program.GetPointsQuality(this);

    private double ?score;
    public double GetPoints() => score ??= (GetPointsAutumn() + GetPointsCultivation() + GetPointsEfficiency() 
        + GetPointsFertilizing() + GetPointsIrrigation() + GetPointsPlanting() + GetPointsQuality() 
        + GetPointsSeeding() + GetPointsSpring() + GetPointsTopping()) / 10;

    public override string ToString()
    {
        return $"{NO} {Region} {Farmer} {NumberOfField} {HA} {AutumnPloughing} {SpringPloughing} {Seeding} {Planting} {Irrigation} {Cultivation} {Fertilizing} {Topping} {Efficiency} {Quality}";
    }
}