using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logging.Net.ConsoleUI.Controls
{
    public class TextBox : ConsoleControl
    {
        public TextBox()
        {
            Application.KeyPressed += Application_KeyPressed;
            Height = 3;
            Width = 100;
        }

        private void Application_KeyPressed(ConsoleKeyInfo obj)
        {
            Text += obj.KeyChar;
            Application.UpdateWindow();
            File.WriteAllText("text.txt",Text);
        }

        public override void OnPaint(ConsoleGraphics g)
        {
            base.OnPaint(g);
            g.DrawString(ForeColor, BackColor, Text, 1, 1);
        }
    }
}
