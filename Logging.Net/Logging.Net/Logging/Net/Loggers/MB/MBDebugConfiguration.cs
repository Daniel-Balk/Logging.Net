using System;

namespace Logging.Net.Loggers.MB
{
    /// <summary>
    /// color configuration for debug
    /// </summary>
    public class MBDebugConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public MBDebugConfiguration() : base(ConsoleColor.Green, new PrefixAction<string>((time) =>
        {
            return "debug";
        }),
        new PrefixAction(() =>
        {
            return "";
        }))
        {

        }
    }
}