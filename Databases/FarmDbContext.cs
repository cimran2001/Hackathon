using Hackathon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Hackathon.Databases;

class FarmDbContext : DbContext {
    public DbSet<Farm> Farms { get; set; } = null!;

    public DbSet<AutumnPloughing> AutumnPloughings { get; set; } = null!;
    public DbSet<Cultivation> Cultivations { get; set; } = null!;
    public DbSet<Efficiency> Efficiencies { get; set; } = null!;
    public DbSet<Farmer> Farmers { get; set; } = null!;
    public DbSet<Fertilizing> Fertilizings { get; set; } = null!;
    public DbSet<Irrigation> Irrigations { get; set; } = null!;
    public DbSet<Planting> Plantings { get; set; } = null!;
    public DbSet<Quality> Qualities { get; set; } = null!;
    public DbSet<Seeding> Seedings { get; set; } = null!;
    public DbSet<SpringPloughing> SpringPloughings { get; set; } = null!;
    public DbSet<Topping> Toppings { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Environment.CurrentDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(configuration.GetConnectionString("FPI"));
    }
}