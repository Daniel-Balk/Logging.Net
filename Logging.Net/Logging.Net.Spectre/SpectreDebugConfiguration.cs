
using System;

namespace Logging.Net.Spectre
{
    internal class SpectreDebugConfiguration : LoggingConfiguration
    {
        public SpectreDebugConfiguration() : base(
            ConsoleColor.Green, x => $"{x}[{ConsoleColor.Green.ToString().ToLower()}] Debug [/] > ", () => $"[bold] {DateTime.Now.ToShortTimeString()} [/]")
        {

        }
    }
}