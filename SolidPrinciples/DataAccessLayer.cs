using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    // Interface for logger
    public interface ILogger
    {
        void Log(string message);
    }

    // FileLogger class implementing ILogger
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
    }

    // DatabaseLogger class implementing ILogger
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to database: {message}");
        }
    }

    // ConsoleLogger class implementing ILogger
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to console: {message}");
        }
    }

    // DataAccessLayer class using Dependency Injection (IOC)
    public class DataAccessLayer
    {
        private readonly ILogger _logger;

        // Constructor injection
        public DataAccessLayer(ILogger logger)
        {
            _logger = logger;
        }

        public void AddCustomer(string name)
        {
            _logger.Log($"Customer added: {name}");
        }
    }
}
