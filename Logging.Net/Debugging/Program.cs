using Logging.Net;

namespace Debugging
{
    class Program
    {
        static void Main()
        {
            // the logs should be written to a file
            Logger.LogToHtmlFile("log.html");

            // log a message as debug
            Logger.Debug("A debug log message...");

            // log a message as info
            Logger.Log("A log message...");

            // Logger.Info(message) == Logger.Log(message)
            Logger.Info("Another log message...");

            // log a message as warning
            Logger.Warn("A warning message...");

            // log a message as an error
            Logger.Error("A error message..");

        }
    }
}
