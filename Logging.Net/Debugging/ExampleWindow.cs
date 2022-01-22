using Logging.Net.ConsoleUI;
using Logging.Net.ConsoleUI.Controls;


namespace Example
{
    public class ExampleWindow : ConsoleWindow
    {
        public ExampleWindow()
        {
            Text = "Hello World";
            Controls.Add(new TextBox());
        }
    }
}
