using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Logging.Net.ConsoleUI
{
    public static class Application
    {
        private static Thread render = null;
        private static Thread input = null;
        private static int pause = 100;
        private static ConsoleWindow _win;
        public static void Run(ConsoleWindow win)
        {
            _win = win;
            render = new Thread(() =>
            {
            });

            input = new Thread(() =>
            {
                Console.CursorVisible = false;
                while (true)
                {
                    var c = Console.ReadKey(true);
                    KeyPressed?.Invoke(c);
                }
            });


            render.Start();
            input.Start();

            WriteBmp(win.Render());
        }

        private static bool write_init = false;
        private static int write_x = 0;
        private static int write_y = 0;
        private static ConsoleColor write_vc;
        private static ConsoleColor write_bc;
        private static void WriteBmp(ConsoleBitmap b)
        {
            if (!write_init)
            {
                Console.Clear();
                write_x = Console.CursorLeft;
                write_y = Console.CursorTop;
                write_vc = Console.ForegroundColor;
                write_bc = Console.BackgroundColor;
            }
            GoStart();
            for (int y = 0; y < b.Height; y++)
            {
                for (int x = 0; x < b.Width; x++)
                {
                    WPX(b[x, y]);
                    NX();
                }
                NY();
            }
            GoStart();
        }

        private static void RC()
        {
            Console.ForegroundColor = write_vc;
            Console.BackgroundColor = write_bc;
        }

        private static void WPX(ConsolePixel px)
        {
            Console.BackgroundColor = px.Color;
            Console.ForegroundColor = px.TextColor;

            Console.Write(px.PixelChar);
            
            //Console.CursorLeft--;
        }

        private static void GoStart()
        {
            Console.CursorLeft = write_x;
            Console.CursorTop = write_y;
        }

        private static void NX()
        {
            //Console.CursorLeft++;
        }

        private static void NY()
        {
            Console.CursorTop++;
            Console.CursorLeft = write_x;
        }

        public static void Abort()
        {
            render.Interrupt();
            input.Interrupt();
            RC();
        }

        public static event Action<ConsoleKeyInfo> KeyPressed;

        internal static void UpdateWindow()
        {
            WriteBmp(_win.Render());
        }
    }
}
