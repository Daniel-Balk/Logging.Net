using System;

namespace Logging.Net.Loggers.MB
{
    /// <summary>
    /// color configuration for error
    /// </summary>
    public class MBErrorConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public MBErrorConfiguration() : base(ConsoleColor.Red, new PrefixAction<string>((time) =>
        {
            return "error";
        }),
        new PrefixAction(() =>
        {
            return "";
        }))
        {

        }
    }
}