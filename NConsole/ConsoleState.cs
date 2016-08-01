using System;
using System.Threading;

namespace NConsole
{
    internal class ConsoleState : IDisposable
    {
        private readonly ConsoleColor _originalForegroundColor;
        private readonly ConsoleColor _originalBackgroundColor;
        private static readonly object _lock = new object();

        public ConsoleState()
        {
            Monitor.Enter(_lock);
            _originalForegroundColor = Console.ForegroundColor;
            _originalBackgroundColor = Console.BackgroundColor;
        }

        public void Dispose()
        {
            Console.ForegroundColor = _originalForegroundColor;
            Console.BackgroundColor = _originalBackgroundColor;
            Monitor.Exit(_lock);
        }
    }
}
