using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Notification
{
    public class ActionNotification : INotification
    {
        int monitor = 0;
        public void LightPanel()
        {
            

            int green = 1;
            int yellow = 2;
            int red = 3;
           
            int light;

            while(monitor !=0)
            {
               if( monitor ==1)
                {
                    light = green;

                }
               else if(monitor ==2)
                {
                    light = yellow; 
                }
                else
                {
                    light = red; 
                }
            }
           
          
            


        }

  
        public void LogTable()
        {
            throw new NotImplementedException();
        }

        public void notifyEmergencyServices()
        {
            throw new NotImplementedException();
        }

        public void notifyMonitoringServices()
        {
            throw new NotImplementedException();
        }

        public int resetSensor()
        {
            throw new NotImplementedException();
        }

        public void TurnOnSound()
        {
            throw new NotImplementedException();
        }

        public string userCredentials()
        {
            throw new NotImplementedException();
        }
    }
}
