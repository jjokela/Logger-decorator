using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Decorator.Loggers.Adapters
{
    public class DbLogAdapter : ILogger
    {
        private readonly DbLogger _logger;

        public DbLogAdapter(DbLogger logger)
        {
            _logger = logger;
        }

        public void LogInfo(string message)
        {
            _logger.Log(message, "Info", "User");
        }

        public void LogError(string message)
        {
            _logger.Log(message, "Error", "User");
        }
    }
}
