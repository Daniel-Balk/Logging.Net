using System;

namespace Logging.Net
{
    /// <summary>
    /// interface for additions
    /// </summary>
    public interface ILoggingAddition
    {
        /// <summary>
        /// method to process a log message
        /// </summary>
        /// <param name="s">log message</param>
        /// <param name="color">color of the message</param>
        void ProcessMessage(string s, ConsoleColor color);
    }
}
