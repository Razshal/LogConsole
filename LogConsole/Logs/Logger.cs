using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogConsole.Logs
{
    public static class Logger
    {
        private static ConsoleVM? _consoleVM;

        public static void RegisterConsoleVM(ConsoleVM consoleVM)
        {
            _consoleVM = consoleVM;
        }

        //public static void 
    }
}
