using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        HttpClient client = new HttpClient();

        string[] links = { "https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-7.0",
                "https://github.com/ulviabdullazada/AzMB101CSharp/blob/main/Paralellism/Program.cs",
                "https://github.com/RockeyWereWolfCodeAcademy/TeamPizzaTask/tree/master",
                "https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient",
                "https://www.youtube.com/watch?v=g-JGay_lnWI"};


        Stopwatch stopwatch = Stopwatch.StartNew();
        Task.Run(async () =>
        {
            foreach (string link in links)
            {
                string response = await client.GetStringAsync(link);
            }
        }).Wait();


        stopwatch.Stop();

        Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds}");
    }
}