using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLogExtension.Extensions
{
    public static class ILoggerExtension
    {
        public static void ActionInit(this ILogger logger, string message)
        {
            logger.Debug($"ACTION-00001 {message}");
        }
    }
}