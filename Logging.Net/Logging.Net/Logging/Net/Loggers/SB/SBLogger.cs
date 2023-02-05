using System;

namespace Logging.Net.Loggers.SB
{
    /// <summary>
    /// a logger with square brackets
    /// </summary>
    public class SBLogger : ILogger
    {
        #region Configurations
        /// <summary>
        /// configuration for debug logs
        /// </summary>
        public LoggingConfiguration DebugConfiguration { get; set; } = new SBDebugConfiguration();
        /// <summary>
        /// configuration for info logs
        /// </summary>
        public LoggingConfiguration InfoConfiguration { get; set; } = new SBInfoConfiguration();
        /// <summary>
        /// configuration for warn logs
        /// </summary>
        public LoggingConfiguration WarnConfiguration { get; set; } = new SBWarnConfiguration();
        /// <summary>
        /// configuration for error logs
        /// </summary>
        public LoggingConfiguration ErrorConfiguration { get; set; } = new SBErrorConfiguration();
        /// <summary>
        /// configuration for fatak logs
        /// </summary>
        public LoggingConfiguration FatalConfiguration { get; set; } = new SBFatalConfiguration();
        #endregion

        #region Properties
        /// <summary>
        /// additional logging operation
        /// </summary>
        public ILoggingAddition Addition { get; set; } = new NoAddition();

        /// <summary>
        /// if true: logs the name of the calling class
        /// </summary>
        public bool LogCallingClass { get; set; } = true;
        #endregion

        private void LogForConfiguration(LoggingConfiguration c, string str)
        {
            var lns = str.Replace("\r\n", "\n").Split('\n');
            foreach (var s in lns)
            {
                var m = c.GetPrefix(c.GetTimePrefix());
                LoggingHelper.ForegroundColorWrite(m, c.Color);
                if (LogCallingClass)
                    LoggingHelper.ForegroundColorWrite("(" + LoggingHelper.NameOfCallingClass() + ") ", ConsoleColor.Blue);
                LoggingHelper.ForegroundColorWriteLine(s, ConsoleColor.White);
                Addition.ProcessMessage(m, c.Color);
            }
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
        /// logs a string as fatal
        /// </summary>
        /// <param name="s">string to log</param>
        public void Fatal(string s)
        {
            LogForConfiguration(FatalConfiguration, s);
        }

        #region Get Methods
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
        /// gets fatal configuration
        /// </summary>
        /// <returns>fatal configuration</returns>
        public LoggingConfiguration GetFatalConfiguration()
        {
            return FatalConfiguration;
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
        #endregion

        /// <summary>
        /// logs a string as info
        /// </summary>
        /// <param name="s">string to log</param>
        public void Info(string s)
        {
            LogForConfiguration(InfoConfiguration, s);
        }

        #region Set Methods
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
        /// sets new fatal configuration
        /// </summary>
        /// <param name="configuration">new value</param>
        public void SetFatalConfiguration(LoggingConfiguration configuration)
        {
            FatalConfiguration = configuration;
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
        #endregion

        /// <summary>
        /// logs a string as warn
        /// </summary>
        /// <param name="s">string to log</param>
        public void Warn(string s)
        {
            LogForConfiguration(WarnConfiguration, s);
        }

        /// <summary>
        /// log an exception as info
        /// </summary>
        /// <param name="ex">exception to log</param>
        public void InfoEx(Exception ex)
        {
            LogExForConfiguration(InfoConfiguration, ex);
        }

        /// <summary>
        /// log an exception as debug
        /// </summary>
        /// <param name="ex">exception to log</param>
        public void DebugEx(Exception ex)
        {
            LogExForConfiguration(DebugConfiguration, ex);
        }

        /// <summary>
        /// log an exception as warn
        /// </summary>
        /// <param name="ex">exception to log</param>
        public void WarnEx(Exception ex)
        {
            LogExForConfiguration(WarnConfiguration, ex);
        }

        /// <summary>
        /// log an exception as error
        /// </summary>
        /// <param name="ex">exception to log</param>
        public void ErrorEx(Exception ex)
        {
            LogExForConfiguration(ErrorConfiguration, ex);
        }

        /// <summary>
        /// log an exception as fatal
        /// </summary>
        /// <param name="ex">exception to log</param>
        public void FatalEx(Exception ex)
        {
            LogExForConfiguration(FatalConfiguration, ex);
        }

        private void LogExForConfiguration(LoggingConfiguration conf, Exception ex)
        {
            LogForConfiguration(conf, ex.ToString());
        }
    }
}