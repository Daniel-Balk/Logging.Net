
using System;

namespace Logging.Net.Spectre
{
    internal class SpectreWarnConfiguration : LoggingConfiguration
    {
        public SpectreWarnConfiguration() : base(
    ConsoleColor.Yellow, x => $"{x}[{ConsoleColor.Yellow.ToString().ToLower()}] Warn [/] > ", () => $"[bold] {DateTime.Now.ToShortTimeString()} [/]")
        {

        }
    }
}