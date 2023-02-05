using System;

namespace Logging.Net.Loggers.MB
{
    /// <summary>
    /// color configuration for error
    /// </summary>
    public class MBFatalConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public MBFatalConfiguration() : base(ConsoleColor.DarkRed, new PrefixAction<string>((time) =>
        {
            return "fatal";
        }),
        new PrefixAction(() =>
        {
            return "";
        }))
        {

        }
    }
}