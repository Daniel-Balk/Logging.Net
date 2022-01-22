using System;

namespace Logging.Net.ConsoleUI
{
    public struct ConsolePixel
    {
        public char PixelChar { get; set; }
        public ConsoleColor Color { get; set; }
        public ConsoleColor TextColor { get; set; }

        public ConsolePixel(ConsoleColor col, ConsoleColor textcol, char text )
        {
            Color = col;
            TextColor = textcol;
            PixelChar = text;
        }

        public ConsolePixel(ConsoleColor col, ConsoleColor textcol)
        {
            Color = col;
            TextColor = textcol;
            PixelChar = ' ';
        }

        public static bool operator ==(ConsolePixel a, ConsolePixel b)
        {
            return a.PixelChar == b.PixelChar && a.Color == b.Color && a.TextColor == b.TextColor;
        }

        public static bool operator !=(ConsolePixel a, ConsolePixel b)
        {
            return a.PixelChar != b.PixelChar | a.Color != b.Color | a.TextColor != b.TextColor;
        }

        public override bool Equals(object obj)
        {
            return this == (ConsolePixel)obj;
        }

        public override int GetHashCode()
        {
            long hp = (long)Color.GetHashCode() + (long)TextColor.GetHashCode() + (long)PixelChar.GetHashCode();
            return (int)(hp / 3L);
        }
    }
}