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

    public override string ToString()
    {
        return $"{NO} {Region} {Farmer} {NumberOfField} {HA} {AutumnPloughing} {SpringPloughing} {Seeding} {Planting} {Irrigation} {Cultivation} {Fertilizing} {Topping} {Efficiency} {Quality}";
    }
}