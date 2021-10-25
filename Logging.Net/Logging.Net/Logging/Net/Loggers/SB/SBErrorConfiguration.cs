using System;

namespace Logging.Net.Loggers.SB
{
    /// <summary>
    /// color configuration for error
    /// </summary>
    public class SBErrorConfiguration : LoggingConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public SBErrorConfiguration() : base(ConsoleColor.Red, new PrefixAction<string>((time) =>
        {
            return "[ERROR] " + time + " ";
        }),
        new PrefixAction(() =>
        {
            static string FormatInteger(int i)
            {
                if (i.ToString().Length > 1)
                    return i.ToString();
                return "0" + i.ToString();
            }
            return "[" + FormatInteger(DateTime.Now.Hour) + ":" + FormatInteger(DateTime.Now.Minute)
              + ":" + FormatInteger(DateTime.Now.Second) + "]";
        }))
        {

        }
    }
}