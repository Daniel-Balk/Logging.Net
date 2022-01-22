namespace Logging.Net.ConsoleUI
{
    public class ConsoleContainerControl : ConsoleControl
    {
        public ConsoleContainerControl(): base()
        {
            Controls = new ConsoleControlCollection();
        }

        internal override ConsoleBitmap Render()
        {
            ConsoleBitmap bmp = new ConsoleBitmap(Width, Height);
            ConsoleGraphics g = new ConsoleGraphics(bmp);

            OnPaint(g);

            RenderControls(g);

            return g.ToBitmap();
        }

        internal virtual void RenderControls(ConsoleGraphics g)
        {
            Controls.ForEach(c =>
            {
                var r = c.Render();
                g.DrawImage(r, c.X, c.Y);
            });
        }

        public ConsoleControlCollection Controls { get; set; }
    }
}