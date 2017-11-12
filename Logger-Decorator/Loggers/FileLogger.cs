using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Decorator.Loggers
{
    public class FileLogger
    {
        public void LogInformationMessage(string message)
        {
            Console.WriteLine($"Logging to file: Info: {message}");
        }

        public void LogErrorMessage(string message)
        {
            Console.WriteLine($"Logging to file: Error: {message}");
        }
    }
}
