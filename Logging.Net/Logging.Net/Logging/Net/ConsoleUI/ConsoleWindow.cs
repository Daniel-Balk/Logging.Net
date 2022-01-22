using System;

namespace Logging.Net.ConsoleUI
{
    public class ConsoleWindow : ConsoleContainerControl
    {
        internal override ConsoleBitmap Render()
        {
            Width = Console.WindowWidth;
            Height = Console.WindowHeight;
            return base.Render();
        }

        public ConsoleWindow()
        {
            Text = "Window 1";
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Console.Title = value;
            }
        }
    }
}