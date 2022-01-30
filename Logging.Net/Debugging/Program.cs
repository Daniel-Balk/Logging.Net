using Logging.Net;
using Logging.Net.ConsoleUI;
using System.Threading;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static async Task Main()
        {
            bool win = false;
            if (!win)
            {
                // write a line of "="
                ConsoleHelper.LineOfChar("=", System.ConsoleColor.Yellow).Write();

                // write "Hello World" centered between a lot of "="
                ConsoleHelper.Center("Hello World", "=", System.ConsoleColor.Red).Write();

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

                // the logs should be written to a html file
                Logger.LogToHtmlFile("log.html");

                // the logs should be written to a file
                Logger.LogToFile("log.log");
                
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

                // disable info logging
                Logger.DisableInfo = true;

                // disable logging warnings
                Logger.DisableWarn = true;

                // disable logging errors
                Logger.DisableError = true;

                // use MyAddition to process the log messages
                //Logger.UsedLogger = new MyAddition();

                // use MyLogger for Logging
                //Logger.UsedLogger = new MyLogger();
                await Task.Delay(2000);
            }
            else
            {
                Application.Run(new Example.ExampleWindow());
            }
        }
    }
}
