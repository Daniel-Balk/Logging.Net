using System;

namespace Logging.Net.ConsoleUI
{
    public class ConsoleGraphics
    {
        private readonly ConsoleBitmap img;

        public ConsoleGraphics(ConsoleBitmap img)
        {
            this.img = img;
        }

        public void Clear(ConsolePixel color)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    img[x, y] = color;
                }
            }
        }

        public void DrawString(ConsolePixel foreColor, ConsolePixel backColor, string text, int x, int y)
        {
            ConsolePixel px = new ConsolePixel(backColor.Color, foreColor.Color);
            int cx = 0;
            foreach (var ch in text)
            {
                px.PixelChar = ch;
                SetPixel(cx + x, y, px);
                cx++;
            }
        }

        public void DrawImage(ConsoleBitmap image, int x, int y)
        {
            for (int ix = 0; ix < image.Width; ix++)
            {
                for (int iy = 0; iy < image.Height; iy++)
                {
                    SetPixel(x + ix, y + iy, image[ix, iy]);
                }
            }
        }

        public void SetPixel(int x, int y, ConsolePixel px)
        {
            try
            {
                img[x, y] = px;
            }
            catch (Exception)
            {

            }
        }

        public void FillRectangle(ConsoleRectangle rect, ConsolePixel color, int x, int y)
        {
            for (int ix = 0; ix < rect.Width; ix++)
            {
                for (int iy = 0; iy < rect.Height; iy++)
                {
                    SetPixel(x + ix, y + iy, color);
                }
            }
        }

        public ConsoleBitmap ToBitmap()
        {
            return img;
        }
    }
}
