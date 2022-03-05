using System.Globalization;
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
}
