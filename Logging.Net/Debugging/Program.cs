using Logging.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static async Task Main()
        {
            ConsoleHelper.LineOfChar("=", System.ConsoleColor.Yellow).Write();
            ConsoleHelper.Center("Hello World","=", System.ConsoleColor.Red).Write();

            ConsoleHelper.Run(() =>
            {
                Logger.Info("Before sleep");
                Logger.Debug("Sleeping 1000ms");
                Thread.Sleep(1000);
                Logger.Info("After sleep");
            }, "Test", true);

            // use a blazor like logger
            Logger.UseMBLogger();

            // use a square bracket logger
            Logger.UseSBLogger();

            // the logs should be written to a file
            Logger.LogToHtmlFile("log.html");

            // log a message as debug
            Logger.Debug("A debug log message...\nwith 3\r\nlines");

            Logger.DisableDebug = true; 
            Logger.Debug("You cannot see this");

            // log a message as info
            Logger.Log("A log message...");

            // Logger.Info(message) == Logger.Log(message)
            Logger.Info("Another log message...");

            // log a message as warning
            Logger.Warn("A warning message...");

            // log a message as an error
            Logger.Error("A error message..");

            await Task.Delay(2000);
        }
    }
}
