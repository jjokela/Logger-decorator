using System;

namespace Logger_Decorator.Loggers
{
    public class DbLogger
    {
        public void Log(string message, string type, string user)
        {
            Console.WriteLine($"Logging to database: {message}, {type}, {user}");
        }
    }
}
