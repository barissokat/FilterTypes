using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilterTypes.Models
{
    public class Log
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public DateTime ProcessDate { get; set; }
        public string Type { get; set; }
    }
}