using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogConsole.Logs;

namespace LogConsole
{
    public class ConsoleVM : ViewModel
    {
        public ObservableCollection<Log> Logs { get; } = new();

        public ConsoleVM()
        {
            Logger.RegisterConsoleVM(this);
        }

        public void PostLog(Log log)
        {
            Logs.Add(log);
            if (Logs.Count > 1000)
                Logs.RemoveAt(0);
        }
    }
}
