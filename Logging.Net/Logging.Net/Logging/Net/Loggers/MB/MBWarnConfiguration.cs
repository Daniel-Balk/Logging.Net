using System;

namespace Logging.Net.Loggers.MB
{
    /// <summary>
    /// color configuration for warn
    /// </summary>
    public class MBWarnConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public MBWarnConfiguration() : base(ConsoleColor.Yellow, new PrefixAction<string>((time) =>
        {
            return "warn";
        }),
        new PrefixAction(() =>
        {
            return "";
        }))
        {

        }
    }
}