using System;

namespace Logging.Net
{
    public class ConsoleMessage
    {
        internal string Message { get; set; }
        public ConsoleColor Color { get; set; }

        public void Write()
        {
            ConsoleHelper.WriteColored(Message, Color);
        }
        public void WriteLine()
        {
            ConsoleHelper.WriteColoredLine(Message, Color);
        }

        internal ConsoleMessage(string msg, ConsoleColor col)
        {
            Message = msg;
            Color = col;
        }
    }
}