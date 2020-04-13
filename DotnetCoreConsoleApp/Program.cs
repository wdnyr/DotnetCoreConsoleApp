using System;
using Microsoft.Extensions.Logging;


namespace DotnetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("Logging information.");
            logger.LogCritical("Logging critical information.");
            logger.LogDebug("Logging debug information.");
            logger.LogError("Logging error information.");
            logger.LogTrace("Logging trace");
            logger.LogWarning("Logging warning.");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Here is a change");
            Console.ReadKey();
        }
    }
}
