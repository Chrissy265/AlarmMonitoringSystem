using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    public interface INotification
    {
        
        void TurnOnSound();

        string userCredentials();

        int resetSensor();

        void notifyEmergencyServices();

        void notifyMonitoringServices();

        void LogTable(); 

    }
}
