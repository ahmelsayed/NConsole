using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NConsole.NConsole;

namespace NConsole.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console()
                .Write("Hello")
                .Background.Red("There")
                .Foreground.WriteLine().Blue("Hello again").WriteLine();
        }
    }
}
