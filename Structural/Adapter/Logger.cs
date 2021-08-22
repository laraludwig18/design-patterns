using System;

namespace DesignPatterns.Structural.Adapter
{
    // Target class
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Default logger - {message}");
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine($"Default logger - {exception.Message}");
        }
    }
}