using Logging.Net.Loggers;
using Spectre.Console;
using System;

namespace Logging.Net.Spectre
{
    public class SpectreLogger : ILogger
    {

        /// <summary>
        /// configuration for debug logs
        /// </summary>
        public LoggingConfiguration DebugConfiguration { get; set; } = new SpectreDebugConfiguration();
        /// <summary>
        /// configuration for info logs
        /// </summary>
        public LoggingConfiguration InfoConfiguration { get; set; } = new SpectreInfoConfiguration();
        /// <summary>
        /// configuration for warn logs
        /// </summary>
        public LoggingConfiguration WarnConfiguration { get; set; } = new SpectreWarnConfiguration();
        /// <summary>
        /// configuration for error logs
        /// </summary>
        public LoggingConfiguration ErrorConfiguration { get; set; } = new SpectreErrorConfiguration();

        /// <summary>
        /// additional logging operation
        /// </summary>
        public ILoggingAddition Addition { get; set; } = new NoAddition();

        private void LogForConfiguration(LoggingConfiguration c, string s)
        {
            var m = c.GetPrefix(c.GetTimePrefix()) + s;
            var str = $"{c.GetPrefix(c.GetTimePrefix())}[white]{s}[/]";
            AnsiConsole.MarkupLine(str);
            Addition.ProcessMessage(m, c.Color);
        }


        /// <summary>
        /// logs a string as debug
        /// </summary>
        /// <param name="s">string to log</param>
        public void Debug(string s)
        {
            LogForConfiguration(DebugConfiguration, s);
        }

        /// <summary>
        /// logs a string as error
        /// </summary>
        /// <param name="s">string to log</param>
        public void Error(string s)
        {
            LogForConfiguration(ErrorConfiguration, s);
        }


        /// <summary>
        /// gets addition
        /// </summary>
        /// <returns>addition</returns>
        public ILoggingAddition GetAddition()
        {
            return Addition;
        }

        /// <summary>
        /// gets debug configuration
        /// </summary>
        /// <returns>debug configuration</returns>
        public LoggingConfiguration GetDebugConfiguration()
        {
            return DebugConfiguration;
        }

        /// <summary>
        /// gets error configuration
        /// </summary>
        /// <returns>error configuration</returns>
        public LoggingConfiguration GetErrorConfiguration()
        {
            return ErrorConfiguration;
        }

        /// <summary>
        /// gets info configuration
        /// </summary>
        /// <returns>info configuration</returns>
        public LoggingConfiguration GetInfoConfiguration()
        {
            return InfoConfiguration;
        }

        /// <summary>
        /// gets warn configuration
        /// </summary>
        /// <returns>warn configuration</returns>
        public LoggingConfiguration GetWarnConfiguration()
        {
            return WarnConfiguration;
        }

        /// <summary>
        /// logs a string as info
        /// </summary>
        /// <param name="s">string to log</param>
        public void Info(string s)
        {
            LogForConfiguration(InfoConfiguration, s);
        }


        /// <summary>
        /// sets addition
        /// </summary>
        /// <param name="addition">new value</param>
        public void SetAddition(ILoggingAddition addition)
        {
            Addition = addition;
        }

        /// <summary>
        /// sets new debug configuration
        /// </summary>
        /// <param name="configuration">new value</param>
        public void SetDebugConfiguration(LoggingConfiguration configuration)
        {
            DebugConfiguration = configuration;
        }

        /// <summary>
        /// sets new error configuration
        /// </summary>
        /// <param name="configuration">new value</param>
        public void SetErrorConfiguration(LoggingConfiguration configuration)
        {
            ErrorConfiguration = configuration;
        }

        /// <summary>
        /// sets new info configuration
        /// </summary>
        /// <param name="configuration">new value</param>
        public void SetInfoConfiguration(LoggingConfiguration configuration)
        {
            InfoConfiguration = configuration;
        }

        /// <summary>
        /// sets new warn configuration
        /// </summary>
        /// <param name="configuration">new value</param>
        public void SetWarnConfiguration(LoggingConfiguration configuration)
        {
            WarnConfiguration = configuration;
        }

        /// <summary>
        /// logs a string as warn
        /// </summary>
        /// <param name="s">string to log</param>
        public void Warn(string s)
        {
            LogForConfiguration(WarnConfiguration, s);
        }
    }
}