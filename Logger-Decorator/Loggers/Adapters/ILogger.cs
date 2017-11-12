﻿namespace Logger_Decorator.Loggers.Adapters
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}