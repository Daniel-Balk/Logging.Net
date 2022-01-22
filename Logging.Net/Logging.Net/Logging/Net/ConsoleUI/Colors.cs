using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logging.Net.ConsoleUI
{
    public static class Colors
    {
        public static ConsolePixel Black { get; set; } = new ConsolePixel(ConsoleColor.Black, ConsoleColor.Black);
        public static ConsolePixel White { get; set; } = new ConsolePixel(ConsoleColor.White, ConsoleColor.Black);
        public static ConsolePixel Blue { get; set; } = new ConsolePixel(ConsoleColor.Blue, ConsoleColor.Black);
        public static ConsolePixel Red { get; set; } = new ConsolePixel(ConsoleColor.Red, ConsoleColor.Black);
        public static ConsolePixel Pink { get; set; } = new ConsolePixel(ConsoleColor.Magenta, ConsoleColor.Black);
    }
}
