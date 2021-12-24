using System;

namespace Logging.Net.Loggers.SB
{
    /// <summary>
    /// color configuration for debug
    /// </summary>
    public class SBDebugConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public SBDebugConfiguration() : base(ConsoleColor.Green, new PrefixAction<string>((time) =>
        {
            return "[DEBUG] " + time + " ";
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