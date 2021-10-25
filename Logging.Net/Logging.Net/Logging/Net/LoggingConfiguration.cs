using System;

namespace Logging.Net
{
    /// <summary>
    /// class to store data for logging modes
    /// </summary>
    public class LoggingConfiguration
    {
        /// <summary>
        /// color of the log message
        /// </summary>
        public ConsoleColor Color { get; set; }
        /// <summary>
        /// delegate to get the prefix
        /// </summary>
        public PrefixAction<string> GetPrefix { get; set; }
        /// <summary>
        /// delegate to get the time prefix
        /// </summary>
        public PrefixAction GetTimePrefix { get; set; }
        /// <summary>
        /// constructor to set the values
        /// </summary>
        /// <param name="color">color of the message</param>
        /// <param name="prefixRule">delegate for message prefixes</param>
        /// <param name="timePrefixRule">delegate to get the time prefix</param>
        public LoggingConfiguration(ConsoleColor color, PrefixAction<string> prefixRule, PrefixAction timePrefixRule)
        {
            Color = color;
            GetPrefix = prefixRule;
            GetTimePrefix = timePrefixRule;
        }
    }
}