using System;

namespace Logging.Net.Loggers.SB
{
    /// <summary>
    /// color configuration for info
    /// </summary>
    public class SBInfoConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public SBInfoConfiguration() : base(ConsoleColor.Blue, new PrefixAction<string>((time) =>
        {
            return "[INFO] " + time + " ";
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