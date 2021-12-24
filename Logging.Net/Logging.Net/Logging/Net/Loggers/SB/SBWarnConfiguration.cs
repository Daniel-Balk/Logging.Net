using System;

namespace Logging.Net.Loggers.SB
{
    /// <summary>
    /// color configuration for warn
    /// </summary>
    public class SBWarnConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public SBWarnConfiguration() : base(ConsoleColor.Yellow, new PrefixAction<string>((time) =>
        {
            return "[WARN] " + time + " ";
        }),
        new PrefixAction(() =>
        {
            return "[" + FormatInteger(DateTime.Now.Hour) + ":" + FormatInteger(DateTime.Now.Minute)
              + ":" + FormatInteger(DateTime.Now.Second) + "]";
        }))
        {

        }
        private static string FormatInteger(int i)
        {
            if (i.ToString().Length > 1)
                return i.ToString();
            return "0" + i.ToString();
        }
    }
}