using Microsoft.Extensions.Logging;
using System.Linq;

namespace BackOffice.Toolkit.Extensions
{
    public static class LoggerExtensions
    {
        public void LogDebug( this ILogger logger, )
        {
            logger.LogDebug()
        }
    }
}
