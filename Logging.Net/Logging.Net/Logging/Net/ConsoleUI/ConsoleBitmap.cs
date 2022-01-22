using System;
using System.Collections.Generic;


namespace Logging.Net.ConsoleUI
{
    public class ConsoleBitmap
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public static ConsoleBitmap Create()
        {
            return new ConsoleBitmap(Console.WindowWidth, Console.WindowHeight);
        }

        private readonly ConsolePixel[,] data;
        public ConsoleBitmap(int w, int h)
        {
            Width = w;
            Height = h;
            data = new ConsolePixel[w, h];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    data[x, y] = new ConsolePixel(Console.BackgroundColor, Console.ForegroundColor);
                }
            }
        }

        public ConsolePixel this[int x, int y]
        {
            get
            {
                return this[new ConsolePoint(x, y)];
            }
            set
            {
                this[new ConsolePoint(x, y)] = value;
            }
        }

        public ConsolePixel this[ConsolePoint p]
        {
            get
            {
                return data[p.X,p.Y];
            }
            set
            {
                data[p.X,p.Y] = value;
            }
        }
    }
}
