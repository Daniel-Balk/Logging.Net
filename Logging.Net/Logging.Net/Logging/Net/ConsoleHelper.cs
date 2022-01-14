using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logging.Net
{
    public static class ConsoleHelper
    {
        public static ConsoleMessage LineOfChar(string chr, ConsoleColor color)
        {
            var str = Len(chr, Console.WindowWidth);
            if (str.Length > Console.WindowWidth)
                str = str.Remove(Console.WindowWidth);

            return new ConsoleMessage(str, color);
        }
        
        public static ConsoleMessage LineOfChar(string chr)
        {            
            return LineOfChar(chr, Console.ForegroundColor);
        }

        public static ConsoleMessage Center(string text)
        {
            return Center(text, " ", Console.ForegroundColor);
        }

        public static ConsoleMessage Center(string text, string fill)
        {
            return Center(text, fill, Console.ForegroundColor);
        }

        public static ConsoleMessage Center(string text, ConsoleColor color)
        {
            return Center(text, " ", color);
        }

        public static ConsoleMessage Center(string text, string fill, ConsoleColor color)
        {
            var strx = text.Trim().TrimEnd();
            var spl = Console.WindowWidth - strx.Length;
            bool u = spl % 2 == 1;
            var ll = spl / 2;
            var rl = ll;
            if (u)
            {
                rl++;
            }
            var rt = Len(fill,rl);
            var lt = Len(fill,ll);
            var str = rt + text + lt;
            return new ConsoleMessage(str, color);
        }

        private static string Len(string x, int y)
        {
            var str = "";
            for (int i = 0; i < y; i += x.Length)
            {
                str += x;
            }

            return str;
        }

        internal static void WriteColored(string str, ConsoleColor color)
        {
            var buffer = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ForegroundColor = buffer;
        }

        internal static void WriteColoredLine(string str, ConsoleColor color)
        {
            var buffer = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ForegroundColor = buffer;
        }



        public static ConsoleColor TaskStartLogColor { get; set; } = ConsoleColor.White;
        public static ConsoleColor TaskDoneLogColor { get; set; } = ConsoleColor.Green;
        public static ConsoleColor TaskDoneTimeLogColor { get; set; } = ConsoleColor.Blue;

        public static void Run(Action task, string name = "New Task", bool took = true)
        {
            var start = DateTime.Now;

            WriteColored(name + " ", TaskStartLogColor);

            var i = new StartInfo() { nowSt = start, x = Console.CursorLeft, y = Console.CursorTop };

            Console.WriteLine();

            task.Invoke();

            var end = DateTime.Now;

            var delay = end - i.nowSt;

            var cx = Console.CursorLeft;
            var cy = Console.CursorTop;

            Console.CursorTop = i.y;
            Console.CursorLeft = i.x;

            WriteColored("Done ", TaskDoneLogColor);

            if (took)
            {
                WriteColored("Took ", TaskStartLogColor);
                WriteColored($"{delay.TotalSeconds}", TaskDoneTimeLogColor);
                WriteColored("s", TaskStartLogColor);
            }

            Console.CursorTop = cy;
            Console.CursorLeft = cx;
        }
    }
}
