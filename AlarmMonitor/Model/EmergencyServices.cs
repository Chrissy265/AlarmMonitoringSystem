using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Model
{
    class EmergencyServices
    {
        public string Emergency { get; set; }

        public int notifyServices { get; set; }

        public string MonitorServices { get; set; }

        public int monitorServices { get; set; }

        public bool enabled { get; set; }
    }
}
