using NLog;

namespace NLogExtension.Extensions
{
    public static class LoggerExtension
    {
        public static void ActionInit(this ILogger logger, string message)
        {
            logger.Debug($"APP-001 {message}");
        }
        public static void Performance(this ILogger logger, string message)
        {
            logger.Debug($"PERFORMANCE-001 {message}");
        }
    }
}
