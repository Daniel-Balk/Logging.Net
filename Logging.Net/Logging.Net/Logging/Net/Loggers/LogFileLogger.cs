using System;
using System.IO;
using System.Linq;

namespace Logging.Net.Loggers
{
    /// <summary>
    /// a logger addition which writes the logs to a file
    /// </summary>
    public class LogFileLogger : ILoggingAddition
    {
        object _lock = new object();

        /// <summary>
        /// name of the file the class uses
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// constructor to set the filename
        /// </summary>
        /// <param name="fileName"></param>
        public LogFileLogger(string fileName)
        {
            FileName = fileName;
        }

        /// <summary>
        /// writes the message to a file
        /// </summary>
        /// <param name="s">message</param>
        /// <param name="color">color of the message</param>
        public void ProcessMessage(string s, ConsoleColor color)
        {
            lock (_lock)
            {
                if (!File.Exists(FileName))
                    File.WriteAllText(FileName, "");
                var content = File.ReadAllLines(FileName).ToList();
                content.Add(s);
                File.WriteAllLines(FileName, content);
            }
        }
    }
}
