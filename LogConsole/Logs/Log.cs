using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogConsole.Logs
{
    public class Log
    {
        public LogType LogType { get; }
        public string Message { get; }

        public Log(LogType logType, string message)
        {
            LogType = logType;
            Message = message;
        }
    }
}
