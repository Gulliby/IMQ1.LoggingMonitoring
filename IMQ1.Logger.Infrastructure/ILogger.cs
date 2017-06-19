using System;

namespace IMQ1.Logger.Infrastructure
{
    public interface ILogger
    {
        void LogError(Exception exception, string message);

        void LogInfo(string message);

        void LogDebug(string message);
    }
}
