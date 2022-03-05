﻿using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;
using Hackathon.Databases;
using Hackathon.Models;

namespace Hackathon;

class Program {
    public delegate void Logger(string? text);
    public static async Task Main() {
        Logger logger = LogWithDate;
        using var db = new FarmDbContext();

        using var server = new HttpListener();
        server.Prefixes.Add("http://*:80/");
        server.Start();

        logger("Server has started.");
        logger("Waiting for connection.");

        while (true) {
            var client = await server.GetContextAsync();
            logger($"Client has connected from IP: {client.Request.RemoteEndPoint}");
            using var writer = new StreamWriter(client.Response.OutputStream);

            var json = JsonSerializer.Serialize(db.Farms);

            await writer.WriteAsync(json);
            await writer.FlushAsync();
        }
    }

    public static void LogWithDate(string? value) {
        Console.WriteLine($"[{DateTime.Now}] {value}");
    }

    public static double GetPointsAutumn(Farm farm) {
        if (farm.AutumnPloughing is null)
            return 0.0;
        
        double scoreDate = 100.0;

        var autumnStart = new DateTime(farm.AutumnPloughing.Date.Year, 3, 15);
        var autumnEnd = new DateTime(farm.AutumnPloughing.Date.Year, 4, 15);

        if (farm.AutumnPloughing.Date < autumnStart)
            scoreDate -= (autumnStart - farm.AutumnPloughing.Date).Days * 20;
        if (farm.AutumnPloughing.Date > autumnEnd)
            scoreDate -= (farm.AutumnPloughing.Date - autumnEnd).Days * 20;
        if (scoreDate < 0)
            scoreDate = 0;

        var scoreDepth = 100.0;
        if (farm.AutumnPloughing.Depth < 25)
            scoreDepth -= (25 - farm.AutumnPloughing.Depth) * 10;
        if (scoreDepth < 0)
            scoreDepth = 0;
        
        var score = ((scoreDate + scoreDepth) / 2) * (farm.AutumnPloughing.AppliedHA / farm.HA);

        return score;
    }

    public static async Task<double> GetPointsAutumnAsync(Farm farm) {
        return await Task.Run(() => GetPointsAutumn(farm));
    }

    public static double GetPointsSpring(Farm farm) {
        if (farm.SpringPloughing is null)
            return 0.0;
        
        double scoreDate = 100.0;

        var springStart = new DateTime(farm.SpringPloughing.Date.Year, 3, 15);
        var springEnd = new DateTime(farm.SpringPloughing.Date.Year, 4, 15);

        if (farm.SpringPloughing.Date < springStart)
            scoreDate -= (springStart - farm.SpringPloughing.Date).Days * 20;
        if (farm.SpringPloughing.Date > springEnd)
            scoreDate -= (farm.SpringPloughing.Date - springEnd).Days * 20;
        if (scoreDate < 0)
            scoreDate = 0;

        var scoreDepth = 100.0;
        if (farm.SpringPloughing.Depth < 25)
            scoreDepth -= (25 - farm.SpringPloughing.Depth) * 10;
        if (scoreDepth < 0)
            scoreDepth = 0;
        
        var score = ((scoreDate + scoreDepth) / 2) * (farm.SpringPloughing.AppliedHA / farm.HA);
        return score;
    }

    public static async Task<double> GetPointsSpringAsync(Farm farm) {
        return await Task.Run(() => GetPointsSpring(farm));
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

        if (score > 16) {
            var fine = score - 16;
            result = 100 - fine;
        }
        
        return result;
    }

    public static async Task<double> GetPointsSeedingAsync(Farm farm) {
        return await Task.Run(() => GetPointsSeeding(farm));
    }

    public static double GetPointsPlanting(Farm farm) {
        if (farm.Planting is null)
            return 0.0;
        
        if (farm.Planting.PlantPopulation < 20000 || farm.Planting.PlantPopulation > 22000)
            return 0.0;

        double scoreDate = 100.0;

        var plantingEnd = new DateTime(farm.Planting.Date.Year, 5, 15);

        if (farm.Planting.Date > plantingEnd)
            scoreDate -= (farm.Planting.Date - plantingEnd).Days * 20;
        if (scoreDate < 0)
            scoreDate = 0;

        // TODO: Applied HA and Population
        scoreDate *= farm.Planting.AppliedHA / farm.HA;

        return scoreDate;
    }

    public static async Task<double> GetPointsPlantingAsync(Farm farm) {
        return await Task.Run(() => GetPointsPlanting(farm));
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

    public static async Task<double> GetPointsIrrigationAsync(Farm farm) {
        return await Task.Run(() => GetPointsIrrigation(farm));
    }

    public static double GetPointsCultivation(Farm farm) {
        if (farm.Cultivation is null)
            return 0.0;
        
        var score = farm.Cultivation.NumberOfTimes >= 2 ? 100.0 : 0.0;
        
        
        score *= farm.Cultivation.AppliedHA / farm.HA;
        return score;
    }

    public static async Task<double> GetPointsCultivationAsync(Farm farm) {
        return await Task.Run(() => GetPointsCultivation(farm));
    }

    public static double GetPointsFertilizing(Farm farm) {
        if (farm.Fertilizing is null || farm.Planting is null)
            return 0.0;

        if (farm.Fertilizing.Integrity == false)
            return 0.0;

        var score = 100.0;
        var difference = Math.Abs((farm.Planting.Date - farm.Fertilizing.Date).Days);
        if (difference > 15)
            score -= (difference - 15) * 25;
        return score >= 0.0 ? score : 0.0;
    }

    public static async Task<double> GetPointsFertilizingAsync(Farm farm) {
        return await Task.Run(() => GetPointsFertilizing(farm));
    }

    public static double GetPointsTopping(Farm farm) {
        if (farm.Topping is null)
            return 0.0;

        if (farm.Topping.Spraying == false)
            return 0.0;

        return 100.0 * farm.Topping.AppliedHA / farm.HA;
    }

    public static async Task<double> GetPointsToppingAsync(Farm farm) {
        return await Task.Run(() => GetPointsTopping(farm));
    }

    public static double GetPointsEfficiency(Farm farm) {
        if (farm.Efficiency is null)
            return 0.0;
        
        if (farm.Efficiency.Tons >= 14)
            return 100.0;
        
        return 100.0 - 25 * (14 - farm.Efficiency.Tons);
    }

    public static async Task<double> GetPointsEfficiencyAsync(Farm farm) {
        return await Task.Run(() => GetPointsEfficiency(farm));
    }

    public static double GetPointsQuality(Farm farm) {
        if (farm.Quality is null)
            return 0.0;

        return farm.Quality.Score;
    }

    public static async Task<double> GetPointsQualityAsync(Farm farm) {
        return await Task.Run(() => GetPointsQuality(farm));
    }

    public static double GetPoints(Farm farm) {
        var sum = GetPointsAutumn(farm) + GetPointsSpring(farm) + GetPointsSeeding(farm) + 
            GetPointsPlanting(farm) + GetPointsIrrigation(farm) + GetPointsCultivation(farm) + 
            GetPointsFertilizing(farm) + GetPointsTopping(farm) + GetPointsEfficiency(farm) + GetPointsQuality(farm);

        return sum / 10;
    }

    public static async Task<double> GetPointsAsync(Farm farm) {
        return await Task.Run(async () => {
            var sum = await GetPointsAutumnAsync(farm)
                + await GetPointsSpringAsync(farm)
                + await GetPointsSeedingAsync(farm)
                + await GetPointsPlantingAsync(farm)
                + await GetPointsIrrigationAsync(farm)
                + await GetPointsCultivationAsync(farm)
                + await GetPointsFertilizingAsync(farm)
                + await GetPointsToppingAsync(farm)
                + await GetPointsEfficiencyAsync(farm)
                + await GetPointsQualityAsync(farm);
            return sum;
        });
    }
}
