using System;
using System.Diagnostics;
using System.Reflection;

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
        internal static string NameOfCallingClass(int skipFrames = 4)
        {
            string fullName;
            Type declaringType;
            
            do
            {
                MethodBase method = new StackFrame(skipFrames, false).GetMethod();
                declaringType = method.DeclaringType;
                if (declaringType == null)
                {
                    return method.Name;
                }
                skipFrames++;
                if (declaringType.Name.Contains("<"))
                    fullName = declaringType.ReflectedType.Name;
                else
                    fullName = declaringType.Name;
            }
            while (declaringType.Module.Name.Equals("mscorlib.dll", StringComparison.OrdinalIgnoreCase) | fullName.Contains("Logger"));

            return fullName;
        }
    }
}
