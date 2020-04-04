using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Notification
{
    public class Sensor_FireHazardModel
    {

        /

        //Securitypin

        public string securityPin { get; set; }

        public bool securityPinEntered { get; set; }

        //Flag if the sensor is selected 

        public bool _isSelected { get; set; }
        public bool  _notSelected { get; set; }

        //Sensors properties
        public int sensor1 { get; set; }
        public int sensor2 { get; set; }

        public int sensor3 { get; set; }

        public int sensor4 { get; set; }


        //Fire Harzard properties for monitor panel 
        public string Smoke { get; set; }
        public string Fire { get; set; }

        public string Heat { get; set; }


        //Fire Hazard properties for analyzing

        public int fire { get; set; }
        public int smoke { get; set; }
        public int  heat { get; set; }


        //Flag Logging Table 
        public bool isFlaggedEnabled { get; set; }

    }
}
