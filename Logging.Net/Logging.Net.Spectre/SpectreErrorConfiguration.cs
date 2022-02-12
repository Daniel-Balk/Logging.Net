
using System;

namespace Logging.Net.Spectre
{
    internal class SpectreErrorConfiguration : LoggingConfiguration
    {
        public SpectreErrorConfiguration() : base(
    ConsoleColor.Red, x => $"{x}[{ConsoleColor.Red.ToString().ToLower()}] Error [/] > ", () => $"[bold] {DateTime.Now.ToShortTimeString()} [/]")
        {

        }
    }
}