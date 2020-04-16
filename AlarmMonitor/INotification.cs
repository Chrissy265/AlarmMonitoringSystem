using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor
{
    public interface INotification
    {
    
            void userCredentials();

            int Resetsensor();

            void notifyEmergencyServices();

            void notifyMonitoringServices();

            void LogTable();

            void insertSecuritypin();
        
    }
}
