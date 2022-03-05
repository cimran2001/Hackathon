using System.Globalization;
using System.Net;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;
using Hackathon.Databases;
using Hackathon.Models;

namespace Hackathon;

class Program {
    public static async Task Main() {
        using var db = new FarmDbContext();



        foreach (var farm in db.Farms) {
            System.Console.WriteLine(farm);
        }


        // var file = new StreamReader($"{Environment.CurrentDirectory}/Resources/fpi_database.csv");
        // string? line = file.ReadLine();

        // while ((line = file.ReadLine()) != null) {
        //     var words = line.Split(';');

        //     var autumnDate = words[6].Trim().Split('.');
        //     var springDate = words[9].Trim().Split('.');
        //     var plantingDate = words[14].Trim().Split('.');
        //     var fertilizingDate = words[22].Trim().Split('.');

        //     var no = uint.Parse(words[0].Trim());
        //     var region = words[1].Trim();
        //     var farmer = new Farmer() { Name = words[2].Split(' ')[1] };
        //     var numberOfField = uint.Parse(words[3].Trim());
        //     var ha = double.Parse(words[4].Trim());
        //     double? appliedHA1 = autumnDate.Length == 3 ? double.Parse(words[5].Trim()) : null;
        //     DateTime? date1 = autumnDate.Length == 3 ? new DateTime(int.Parse(autumnDate[2]), int.Parse(autumnDate[1]), int.Parse(autumnDate[0])) : null;
        //     int? depth1 = autumnDate.Length == 3 ? int.Parse(words[7].Trim()) : null;

        //     double? appliedHA2 = double.Parse(words[8].Trim());
        //     DateTime? date2 = new DateTime(int.Parse(springDate[2]), int.Parse(springDate[1]), int.Parse(springDate[0]));
        //     var depth2 = int.Parse(words[10].Trim().Split(' ')[0]);

        //     var intervalCM = uint.Parse(words[11].Trim());

        //     var farm = new Farm() {
        //         NO = no,
        //         Region = region,
        //         Farmer = farmer,
        //         NumberOfField = numberOfField,
        //         HA = ha,
        //         AutumnPloughing = new AutumnPloughing() {
        //             AppliedHA = appliedHA1,
        //             Date = date1,
        //             Depth = depth1,
        //         },
        //         SpringPloughing = new SpringPloughing() {
        //             AppliedHA = appliedHA2,
        //             Date = date2,
        //             Depth = depth2,
        //         },
        //         Seeding = new Seeding() {
        //             IntervalCM = intervalCM,
        //             Standart = words[12].Trim().ToLower().StartsWith('y'),
        //         },
        //         Planting = new Planting() {
        //             AppliedHA = double.Parse(words[13].Trim()),
        //             Date = new DateTime(int.Parse(plantingDate[2]), int.Parse(plantingDate[1]), int.Parse(plantingDate[0])),
        //             PlantPopulation = double.Parse(words[15].Trim()),
        //         },
        //         Irrigation = new Irrigation() {
        //             AppliedHA = double.Parse(words[16].Trim()),
        //             NumberOfTimes = uint.Parse(words[17].Trim()),
        //         },
        //         Cultivation = new Cultivation() {
        //             AppliedHA = double.Parse(words[18].Trim()),
        //             NumberOfTimes = uint.Parse(words[19].Trim()),
        //         },
        //         Fertilizing = new Fertilizing() {
        //             AppliedHA = double.Parse(words[20].Trim()),
        //             Integrity = words[21].Trim().ToLower().StartsWith('y'),
        //             Date = new DateTime(int.Parse(fertilizingDate[2]), int.Parse(fertilizingDate[1]), int.Parse(fertilizingDate[0])),
        //         },
        //         Topping = new Topping() {
        //             AppliedHA = double.Parse(words[23].Trim()),
        //             Spraying = words[24].Trim().ToLower().StartsWith('y'),
        //         },
        //         Efficiency = new Efficiency() {
        //             Tons = double.Parse(words[25].Trim()),
        //         },
        //         Quality = new Quality() {
        //             Score = uint.Parse(words[26].Trim()),
        //         },
        //     };
        //     db.Farms.Add(farm);
        // };
        // db.SaveChanges();
    }
}






// Console.WriteLine(JsonSerializer.Serialize(farm));


// await db.Farms.AddAsync(farm);
// await db.SaveChangesAsync();

// foreach (var farm in db.Farms) {
//     System.Console.WriteLine(farm);
// }

// var farm = db.Farms.FirstOrDefault();
// if (farm is null)
//     return;

// using var server = new HttpListener();
// server.Prefixes.Add("http://*:80/");
// server.Start();
// System.Console.WriteLine("Server has been started!");

// var client = await server.GetContextAsync();
// using var writer = new StreamWriter(client.Response.OutputStream);

// var json = JsonSerializer.Serialize(farm);
// await writer.WriteAsync(json);
// await writer.FlushAsync();