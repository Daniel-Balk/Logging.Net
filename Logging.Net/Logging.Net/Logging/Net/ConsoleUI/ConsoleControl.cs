namespace Logging.Net.ConsoleUI
{
    public class ConsoleControl
    {
        internal virtual ConsoleBitmap Render()
        {
            ConsoleBitmap bmp = new ConsoleBitmap(Width,Height);
            ConsoleGraphics g = new ConsoleGraphics(bmp);

            OnPaint(g);

            return g.ToBitmap();
        }

        public virtual void OnPaint(ConsoleGraphics g)
        {
            g.Clear(BackColor);
        }

        public ConsolePixel BackColor { get; set; } = new ConsolePixel(System.ConsoleColor.White,System.ConsoleColor.White);
        public ConsolePixel ForeColor { get; set; } = new ConsolePixel(System.ConsoleColor.Black, System.ConsoleColor.Black);

        public virtual string Text { get; set; } = "";

        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Width { get; set; } = 20;
        public int Height { get; set; } = 10;
    }
}