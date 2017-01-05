using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilterTypes.Models
{
    public class LogsData
    {
        private static List<Log> _logs = new List<Log>();
        public static List<Log> Logs
        {
            get { return _logs; }
        }
    }
}