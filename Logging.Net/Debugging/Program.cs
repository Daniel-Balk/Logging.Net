using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("Hello World!");
            Logger.LogToFile("info.log");
            Logger.Error("error");
            Logger.Info("info");
            Console.ReadKey();
        }
    }
}
