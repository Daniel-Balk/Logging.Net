
using System;

namespace Logging.Net.Spectre
{
    internal class SpectreInfoConfiguration : LoggingConfiguration
    {
        public SpectreInfoConfiguration() : base(
    ConsoleColor.Blue, x => $"{x}[{ConsoleColor.Blue.ToString().ToLower()}] Info [/] > ", () => $"[bold] {DateTime.Now.ToShortTimeString()} [/]")
        {

        }
    }
}