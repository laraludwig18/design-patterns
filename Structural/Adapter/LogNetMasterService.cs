using System;

namespace DesignPatterns.Structural.Adapter
{
    // Adaptee class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"Custom logger - {message}");
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine($"Custom logger - {exception.Message}");
        }
    }
}