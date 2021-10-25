using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Net
{
    internal static class LoggingHelper
    {
        internal static void ForegroundColorWrite(string s, ConsoleColor c)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = c;
            Console.Write(s);
            Console.ForegroundColor = temp;
        }
        internal static void ForegroundColorWriteLine(string s, ConsoleColor c)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ForegroundColor = temp;
        }
    }
}
