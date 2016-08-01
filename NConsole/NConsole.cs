using System;

namespace NConsole
{
    public class NConsole
    {
        private static readonly NConsole _foregroundOutputConsole = new NConsole(ColorLocation.Foreground, ConsoleStream.Output);
        private static readonly NConsole _foregroundErrorConsole = new NConsole(ColorLocation.Foreground, ConsoleStream.Error);

        private static readonly NConsole _backgroundOutputConsole = new NConsole(ColorLocation.Background, ConsoleStream.Output);
        private static readonly NConsole _backgroundErrorConsole = new NConsole(ColorLocation.Background, ConsoleStream.Error);

        private readonly ColorLocation _colorLocation;
        private readonly ConsoleStream _consoleStream;

        public static NConsole Console()
        {
            return _foregroundOutputConsole;
        }

        public static NConsole Console(object value)
        {
            return _foregroundOutputConsole.Write(value);
        }

        public NConsole Foreground
        {
            get
            {
                return _consoleStream == ConsoleStream.Output ? _foregroundOutputConsole : _foregroundErrorConsole;
            }
        }

        public NConsole Background
        {
            get
            {
                return _consoleStream == ConsoleStream.Output ? _backgroundOutputConsole : _backgroundErrorConsole;
            }
        }

        public NConsole Error
        {
            get
            {
                return _colorLocation == ColorLocation.Foreground ? _foregroundErrorConsole : _backgroundErrorConsole;
            }
        }

        public NConsole Output
        {
            get
            {
                return _colorLocation == ColorLocation.Foreground ? _foregroundOutputConsole : _backgroundOutputConsole;
            }
        }

        private NConsole(ColorLocation colorLocation, ConsoleStream consoleStream)
        {
            _colorLocation = colorLocation;
            _consoleStream = consoleStream;
        }

        public NConsole Write(object value)
        {
            System.Console.Write(value);
            System.Console.Write(" ");
            return this;
        }

        public NConsole WriteLine()
        {
            System.Console.WriteLine();
            return this;
        }

        public NConsole WriteLine(object value)
        {
            System.Console.WriteLine(value);
            return this;
        }

        private NConsole WriteColor(object value, ConsoleColor color)
        {
            using (new ConsoleState())
            {
                System.Console.ForegroundColor = _colorLocation == ColorLocation.Foreground ? color : ConsoleColor.White;
                System.Console.BackgroundColor = _colorLocation == ColorLocation.Background ? color: ConsoleColor.Black;
                System.Console.Write(value);
            }
            System.Console.Write(" ");
            return this;
        }


        public NConsole Black(object value)
        {
            return WriteColor(value, ConsoleColor.Black);
        }

        public NConsole DarkBlue(object value)
        {
            return WriteColor(value, ConsoleColor.DarkBlue);
        }

        public NConsole DarkGreen(object value)
        {
            return WriteColor(value, ConsoleColor.DarkGreen);
        }

        public NConsole DarkCyan(object value)
        {
            return WriteColor(value, ConsoleColor.DarkCyan);
        }

        public NConsole DarkRed(object value)
        {
            return WriteColor(value, ConsoleColor.DarkRed);
        }

        public NConsole DarkMagenta(object value)
        {
            return WriteColor(value, ConsoleColor.DarkMagenta);
        }

        public NConsole DarkYellow(object value)
        {
            return WriteColor(value, ConsoleColor.DarkYellow);
        }

        public NConsole Gray(object value)
        {
            return WriteColor(value, ConsoleColor.Gray);
        }

        public NConsole DarkGray(object value)
        {
            return WriteColor(value, ConsoleColor.DarkGray);
        }

        public NConsole Blue(object value)
        {
            return WriteColor(value, ConsoleColor.Blue);
        }

        public NConsole Green(object value)
        {
            return WriteColor(value, ConsoleColor.Green);
        }

        public NConsole Cyan(object value)
        {
            return WriteColor(value, ConsoleColor.Cyan);
        }

        public NConsole Red(object value)
        {
            return WriteColor(value, ConsoleColor.Red);
        }

        public NConsole Magenta(object value)
        {
            return WriteColor(value, ConsoleColor.Magenta);
        }

        public NConsole Yellow(object value)
        {
            return WriteColor(value, ConsoleColor.Yellow);
        }

        public NConsole White(object value)
        {
            return WriteColor(value, ConsoleColor.White);
        }
    }
}
