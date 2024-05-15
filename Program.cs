using System.Security.Cryptography.X509Certificates;
using FastEndpoints;

public class Program
{
    public readonly static string version = "1.0.0";
    public static void Main(string[] args)
    {                       
        // Data.gamesListDB.logger.Log($"Starting Lan Manager Server {version}");
        var bld = WebApplication.CreateBuilder();
        bld.Services.AddFastEndpoints();
        bld.Services.AddSingleton<IData,Data>();
        var app = bld.Build();
        app.UseFastEndpoints();
        app.Run();
    }
}