using System;

namespace Logging.Net.Loggers.MB
{
    /// <summary>
    /// color configuration for info
    /// </summary>
    public class MBInfoConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public MBInfoConfiguration() : base(ConsoleColor.Blue, new PrefixAction<string>((time) =>
        {
            return "info";
        }),
        new PrefixAction(() =>
        {
            return "";
        }))
        {

        }
    }
}