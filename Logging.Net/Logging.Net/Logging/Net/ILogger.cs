namespace Logging.Net
{
    /// <summary>
    /// interface for logger classes
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// info logging method
        /// </summary>
        /// <param name="s">message to log</param>
        void Info(string s);
        /// <summary>
        /// debug logging method
        /// </summary>
        /// <param name="s">message to log</param>
        void Debug(string s);
        /// <summary>
        /// warn logging method
        /// </summary>
        /// <param name="s">message to log</param>
        void Warn(string s);
        /// <summary>
        /// error logging method
        /// </summary>
        /// <param name="s">message to log</param>
        void Error(string s);
        /// <summary>
        /// fatal logging method
        /// </summary>
        /// <param name="s">message to log</param>
        void Fatal(string s);

        /// <summary>
        /// log an exception as info
        /// </summary>
        /// <param name="ex">exception to log</param>
        void InfoEx(System.Exception ex);

        /// <summary>
        /// log an exception as debug
        /// </summary>
        /// <param name="ex">exception to log</param>
        void DebugEx(System.Exception ex);

        /// <summary>
        /// log an exception as warn
        /// </summary>
        /// <param name="ex">exception to log</param>
        void WarnEx(System.Exception ex);

        /// <summary>
        /// log an exception as error
        /// </summary>
        /// <param name="ex">exception to log</param>
        void ErrorEx(System.Exception ex);

        /// <summary>
        /// log an exception as fatal
        /// </summary>
        /// <param name="ex">exception to log</param>
        void FatalEx(System.Exception ex);

        /// <summary>
        /// method to get the error configuration
        /// </summary>
        /// <returns>error configuration</returns>
        LoggingConfiguration GetErrorConfiguration();

        /// <summary>
        /// sets the error configuration
        /// </summary>
        /// <param name="configuration">new configuration</param>
        void SetErrorConfiguration(LoggingConfiguration configuration);

        /// <summary>
        /// method to get the fatal configuration
        /// </summary>
        /// <returns>error configuration</returns>
        LoggingConfiguration GetFatalConfiguration();

        /// <summary>
        /// sets the fatal configuration
        /// </summary>
        /// <param name="configuration">new configuration</param>
        void SetFatalConfiguration(LoggingConfiguration configuration);

        /// <summary>
        /// method to get the warn configuration
        /// </summary>
        /// <returns>warn configuration</returns>
        LoggingConfiguration GetWarnConfiguration();

        /// <summary>
        /// sets the warn configuration
        /// </summary>
        /// <param name="configuration">new configuration</param>
        void SetWarnConfiguration(LoggingConfiguration configuration);

        /// <summary>
        /// method to get the info configuration
        /// </summary>
        /// <returns>info configuration</returns>
        LoggingConfiguration GetInfoConfiguration();

        /// <summary>
        /// sets the info configuration
        /// </summary>
        /// <param name="configuration">new configuration</param>
        void SetInfoConfiguration(LoggingConfiguration configuration);

        /// <summary>
        /// method to get the debug configuration
        /// </summary>
        /// <returns>debug configuration</returns>
        LoggingConfiguration GetDebugConfiguration();

        /// <summary>
        /// sets the debug configuration
        /// </summary>
        /// <param name="configuration">new configuration</param>
        void SetDebugConfiguration(LoggingConfiguration configuration);

        /// <summary>
        /// method to get the addition
        /// </summary>
        /// <returns>addition</returns>
        ILoggingAddition GetAddition();

        /// <summary>
        /// method to set the addition
        /// </summary>
        /// <param name="addition"></param>
        void SetAddition(ILoggingAddition addition);

        /// <summary>
        /// if true: adds the name of the calling class to the message
        /// </summary>
        bool LogCallingClass { get; set; }
    }
}
