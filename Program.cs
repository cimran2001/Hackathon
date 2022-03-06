using System.Net;
using System.Text.Json;
using Hackathon.Databases;
using Hackathon.Models;
using LightInject;

namespace Hackathon;

class Program {
    public static ServiceContainer Container = new ServiceContainer();
    public delegate void Logger(string? text);
    public static async Task Main() {
        using var db = new FarmDbContext();
        Container.RegisterInstance<FarmDbContext>(db);
        Logger logger = LogWithDate;

        using var server = new HttpListener();
        server.Prefixes.Add("http://*:7888/");
        server.Start();

        logger("Server has started.");
        logger("Waiting for connection.");

        while (true) {
            var context = await server.GetContextAsync();

            var request = context.Request;
            var response = context.Response;
            response.AddHeader("Access-Control-Allow-Origin", "*");

            logger($"Client has connected from IP: {request.RemoteEndPoint}");
            using var writer = new StreamWriter(response.OutputStream);

            var url = request.RawUrl;
            if (url is null) {
                await writer.FlushAsync();
                continue;
            }

            var routs = url.Split('/', StringSplitOptions.RemoveEmptyEntries);
            if (routs is null || routs.Length <= 2) {
                await writer.FlushAsync();
                continue;
            }

            if (request.HttpMethod == HttpMethod.Get.Method) {
                if (routs[2].StartsWith("farms")) {
                    logger("Farms GET request");

                    var list = from farm in db.Farms
                               select new {
                                   id = farm.Id,
                                   region = farm.Region,
                                   farmer = $"{farm.Farmer}",
                                   n_fields = farm.NumberOfFields,
                                   ha = farm.HA,
                                   autumn = (int)GetPointsAutumn(farm),
                                   spring = (int)GetPointsSpring(farm),
                                   seeding = (int)GetPointsSeeding(farm),
                                   planting = (int)GetPointsPlanting(farm),
                                   irrigation = (int)GetPointsIrrigation(farm),
                                   cultivation = (int)GetPointsCultivation(farm),
                                   fertilizing = (int)GetPointsFertilizing(farm),
                                   topping = (int)GetPointsTopping(farm),
                                   efficiency = (int)GetPointsEfficiency(farm),
                                   quality = (int)GetPointsQuality(farm),
                                   index = (int)GetPoints(farm),
                               };
                    string json = JsonSerializer.Serialize(list);
                    await writer.WriteAsync(json);
                } else if (routs[2].StartsWith("consts")) {
                    logger("Constants GET request");
                    string json = JsonSerializer.Serialize(db.Constants.ToList());
                    await writer.WriteAsync(json);
                }
            } else if (request.HttpMethod == HttpMethod.Post.Method) {
                if (routs[2].StartsWith("farm")) {
                    logger("Add Farm POST request");
                    using var reader = new StreamReader(request.InputStream);
                    string json = await reader.ReadToEndAsync();
                    
                    try {
                        var farm = JsonSerializer.Deserialize<Farm>(json);
                        if (farm is null) {
                            response.StatusCode = (int)HttpStatusCode.BadRequest;
                        } else {
                            response.StatusCode = (int)HttpStatusCode.OK;
                            db.Farms.Add(farm);
                            await db.SaveChangesAsync();
                        }
                    } catch (System.Text.Json.JsonException) {
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                    }                  
                } else if (routs[2].StartsWith("addconst")) {
                    logger("Add Const POST request");
                    using var reader = new StreamReader(request.InputStream);
                    string json = await reader.ReadToEndAsync();

                    try {
                        var constant = JsonSerializer.Deserialize<Constant>(json);
                        if (constant is null) {
                            response.StatusCode = (int)HttpStatusCode.BadRequest;
                        } else {
                            response.StatusCode = (int)HttpStatusCode.OK;
                            var search = db.Constants.Where(c => c.Name == constant.Name).FirstOrDefault();
                            if (search is null) {
                                db.Constants.Add(constant);
                            } else {
                                search.Value = constant.Value;
                            }
                            await db.SaveChangesAsync();
                        }
                    } catch (System.Text.Json.JsonException) {
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                    }
                } else {
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                }
            }
            await writer.FlushAsync();
        }
    }

    public static int GetPenalty(string name, int defaultValue) => Container.GetInstance<FarmDbContext>().Constants.Where(c => c.Name == name).FirstOrDefault()?.Value ?? defaultValue;

    public static void LogWithDate(string? value) {
        Console.WriteLine($"[{DateTime.Now}] {value}");
    }

    public static double GetPointsAutumn(Farm farm) {
        if (farm.AutumnPloughing is null)
            return 0.0;

        double scoreDate = 100.0;

        var datePenalty = GetPenalty("AutumnDatePenalty", 20);

        var autumnStart = new DateTime(farm.AutumnPloughing.Date.Year, 3, 15);
        var autumnEnd = new DateTime(farm.AutumnPloughing.Date.Year, 4, 15);

        if (farm.AutumnPloughing.Date < autumnStart)
            scoreDate -= (autumnStart - farm.AutumnPloughing.Date).Days * datePenalty;
        if (farm.AutumnPloughing.Date > autumnEnd)
            scoreDate -= (farm.AutumnPloughing.Date - autumnEnd).Days * datePenalty;
        if (scoreDate < 0)
            scoreDate = 0;

        var scoreDepth = 100.0;

        var depthPenalty = GetPenalty("AutumnDepthPenalty", 10);

        if (farm.AutumnPloughing.Depth < 25)
            scoreDepth -= (25 - farm.AutumnPloughing.Depth) * depthPenalty;
        if (scoreDepth < 0)
            scoreDepth = 0;

        var score = ((scoreDate + scoreDepth) / 2) * (farm.AutumnPloughing.AppliedHA / farm.HA);
        return score;
    }

    public static double GetPointsSpring(Farm farm) {
        if (farm.SpringPloughing is null)
            return 0.0;

        double scoreDate = 100.0;

        var datePenalty = GetPenalty("SpringDatePenalty", 20);

        var springStart = new DateTime(farm.SpringPloughing.Date.Year, 3, 15);
        var springEnd = new DateTime(farm.SpringPloughing.Date.Year, 4, 15);

        if (farm.SpringPloughing.Date < springStart)
            scoreDate -= (springStart - farm.SpringPloughing.Date).Days * datePenalty;
        if (farm.SpringPloughing.Date > springEnd)
            scoreDate -= (farm.SpringPloughing.Date - springEnd).Days * datePenalty;
        if (scoreDate < 0)
            scoreDate = 0;

        var scoreDepth = 100.0;

        var depthPenalty = GetPenalty("SpringDepthPenalty", 10);

        if (farm.SpringPloughing.Depth < 15)
            scoreDepth -= (15 - farm.SpringPloughing.Depth) * depthPenalty;
        if (scoreDepth < 0)
            scoreDepth = 0;

        var score = ((scoreDate + scoreDepth) / 2) * (farm.SpringPloughing.AppliedHA / farm.HA);
        return score;
    }

    public static double GetPointsSeeding(Farm farm) {
        if (farm.Seeding is null)
            return 0.0;

        if (farm.Seeding.Standart is false)
            return 0.0;

        var score = farm.Seeding.IntervalCM / farm.HA - 20;

        if (score < 0)
            return 0.0;

        var result = score / 16 * 100;

        if (score > 16)
            result = 116 - score;

        return result;
    }

    public static double GetPointsPlanting(Farm farm) {
        if (farm.Planting is null)
            return 0.0;

        if (farm.Planting.PlantPopulation < 20000 || farm.Planting.PlantPopulation > 22000)
            return 0.0;

        double scoreDate = 100.0;

        var penalty = GetPenalty("PlantingPenalty", 20);

        var plantingEnd = new DateTime(farm.Planting.Date.Year, 5, 15);

        if (farm.Planting.Date > plantingEnd)
            scoreDate -= (farm.Planting.Date - plantingEnd).Days * penalty;
        if (scoreDate < 0)
            scoreDate = 0;

        // TODO: Applied HA and Population
        scoreDate *= farm.Planting.AppliedHA / farm.HA;

        return scoreDate;
    }

    public static double GetPointsIrrigation(Farm farm) {
        if (farm.Irrigation is null)
            return 0.0;

        var times = farm.Irrigation.NumberOfTimes - 3;
        if (times < 0)
            return 0.0;

        var score = 100.0;

        if (times < 5)
            score *= times / 5;

        score *= farm.Irrigation.AppliedHA / farm.HA;
        return score;
    }

    public static double GetPointsCultivation(Farm farm) {
        if (farm.Cultivation is null)
            return 0.0;

        var score = farm.Cultivation.NumberOfTimes >= 2 ? 100.0 : 0.0;


        score *= farm.Cultivation.AppliedHA / farm.HA;
        return score;
    }

    public static double GetPointsFertilizing(Farm farm) {
        if (farm.Fertilizing is null || farm.Planting is null)
            return 0.0;

        if (farm.Fertilizing.Integrity == false)
            return 0.0;

        var score = 100.0;
        var difference = Math.Abs((farm.Planting.Date - farm.Fertilizing.Date).Days);

        var penalty = GetPenalty("FertilizingPenalty", 25);

        if (difference > 15)
            score -= (difference - 15) * penalty;
        return score >= 0.0 ? score : 0.0;
    }

    public static double GetPointsTopping(Farm farm) {
        if (farm.Topping is null)
            return 0.0;

        if (farm.Topping.Spraying == false)
            return 0.0;

        return 100.0 * farm.Topping.AppliedHA / farm.HA;
    }

    public static double GetPointsEfficiency(Farm farm) {
        if (farm.Efficiency is null)
            return 0.0;

        if (farm.Efficiency.Tons >= 14000)
            return 100.0;

        var penalty = GetPenalty("Efficiency", 25);

        var score = 100.0 - penalty * (14000 - farm.Efficiency.Tons) / 1000;
        return score >= 0 ? score : 0.0;
    }

    public static double GetPointsQuality(Farm farm) {
        if (farm.Quality is null)
            return 0.0;

        return farm.Quality.Score;
    }

    public static double GetPoints(Farm farm) {
        var sum = GetPointsAutumn(farm) + GetPointsSpring(farm) + GetPointsSeeding(farm) +
            GetPointsPlanting(farm) + GetPointsIrrigation(farm) + GetPointsCultivation(farm) +
            GetPointsFertilizing(farm) + GetPointsTopping(farm) + GetPointsEfficiency(farm);

        return sum / 10;
    }
}
