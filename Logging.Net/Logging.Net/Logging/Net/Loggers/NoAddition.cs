using System;

namespace Logging.Net.Loggers
{
    /// <summary>
    /// a default addition
    /// </summary>
    public class NoAddition : ILoggingAddition
    {
        /// <summary>
        /// do nothing
        /// </summary>
        /// <param name="s">message</param>
        /// <param name="color">color of the message</param>
        public void ProcessMessage(string s, ConsoleColor color)
        {
            
        }
    }
}