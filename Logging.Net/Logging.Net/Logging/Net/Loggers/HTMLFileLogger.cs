using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Logging.Net.Loggers
{
    /// <summary>
    /// a logger addition which writes the logs to a html file
    /// </summary>
    public class HTMLFileLogger : ILoggingAddition
    {   
        /// <summary>
        /// name of the file the class uses
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// constructor to set the filename
        /// </summary>
        /// <param name="fileName"></param>
        public HTMLFileLogger(string fileName)
        {
            FileName = fileName;
        }

        /// <summary>
        /// writes the message to a html file
        /// </summary>
        /// <param name="s">message</param>
        /// <param name="color">color of the message</param>
        public void ProcessMessage(string s, ConsoleColor color)
        {
            string html = $@"
<div style=""
color: {ProcessColor(color)};
font-family: Arial;
border-radius: 20px;
background: rgb(224,224,224);
background: -moz-linear-gradient(0deg, rgba(224,224,224,1) 0%, rgba(181,181,181,1) 100%);
background: -webkit-linear-gradient(0deg, rgba(224,224,224,1) 0%, rgba(181,181,181,1) 100%);
background: linear-gradient(0deg, rgba(224,224,224,1) 0%, rgba(181,181,181,1) 100%);
filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#e0e0e0',endColorstr='#b5b5b5',GradientType=1);
border: 1px solid gray;
 "">
    <div style=""
    margin: 20px;
    "">
        <p style=""
        font-size: 16pt;
        overflow-wrap: break-word;
        "">{s.Replace("\r\n","\n").Replace("\n","<br />")}</p>
    </div>
</div>
<br />
";
            var st = html.Replace("\r\n", "").Replace("\n", "");
            if (!File.Exists(FileName))
                File.WriteAllText(FileName, "");
            var content = File.ReadAllLines(FileName).ToList();
            content.Add(st);
            File.WriteAllLines(FileName, content);
        }

        private static string ProcessColor(ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:
                    return "black";
                case ConsoleColor.DarkBlue:
                    return "darkblue";
                case ConsoleColor.DarkGreen:
                    return "darkgreen";
                case ConsoleColor.DarkCyan:
                    return "darkcyan";
                case ConsoleColor.DarkRed:
                    return "darkred";
                case ConsoleColor.DarkMagenta:
                    return "darkmagenta";
                case ConsoleColor.DarkYellow:
                    return "#AF9200";
                case ConsoleColor.Gray:
                    return "gray";
                case ConsoleColor.DarkGray:
                    return "darkgray";
                case ConsoleColor.Blue:
                    return "blue";
                case ConsoleColor.Green:
                    return "green";
                case ConsoleColor.Cyan:
                    return "cyan";
                case ConsoleColor.Red:
                    return "red";
                case ConsoleColor.Magenta:
                    return "magenta";
                case ConsoleColor.Yellow:
                    return "yellow";
                case ConsoleColor.White:
                    return "white";
                default:
                    break;
            }
            return "black";
        }
    }
}
