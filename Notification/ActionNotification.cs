using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Models; 


namespace Notification
{
    public class ActionNotification : INotification
    {
         

        //1 means the flag is on to log to the table 
        int logFlag = 1;
        private string _securitypin;

        public void insertSecuritypin(Sensor_FireHazardModel sensor)
        {
            User user = new User();
            //User security pin 
          
            //verify the sensor 

            if(sensor != null)
            {
                //Ask the user to the insert pin on the monitor 
                Console.WriteLine("Insert the same security pin");

                string  _securitypin = Console.ReadLine(); 
                

            } 
            
           if( _securitypin == user.securityPin)
            {
                resetSensor(); 
            }
        }

        public void insertSecuritypin(User user)
        {
            
        }

        public void LogTable()
        {
           
            

           


            
            
        }



     

        public void notifyEmergencyServices(EmergencyServices services)
        {
          

            if(services.enabled == true)
            {
                displayPanel.ToString(" Emergency Services"); 
            }


        }

        public void notifyMonitoringServices( EmergencyServices services)
        {
            if(services.enabled ==true)
            {
                displayPanel.ToString("Notify Monitor "); 
            }

        }

        public int resetSensor(Sensor_FireHazardModel sensor)
        {
            if(sensor = 0)
            {
                bool resetDisplayPanel = true; 
            }

            return resetDisplayPanel; 

            

        }

      

      
        public void  userCredentials()
        {
           

            User user1 = new User();

            Console.WriteLine("Insert the username");
            user1.username = Console.ReadLine();


            Console.WriteLine("Insert password");
            user1.password = Console.ReadLine();

            
        }
    }
}
