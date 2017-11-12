namespace Logger_Decorator.Loggers.Adapters
{
    public class FileLogAdapter : ILogger
    {
        private readonly FileLogger _logger;

        public FileLogAdapter(FileLogger logger)
        {
            _logger = logger;
        }

        public void LogInfo(string message)
        {
            _logger.LogInformationMessage(message);
        }

        public void LogError(string message)
        {
            _logger.LogErrorMessage(message);
        }
    }
}
