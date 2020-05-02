using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Model
{
    public class Input
    {
        string state = "0" ;
        string fireHazard = "0";
        string standby = "1";
        string fire = "2";
        string smoke = "3";
        int heat = 4; 
        public int securityPin { get; set; }    

        public string firehazard { get; set; }
        public string Fire { get; set; }

        public string Smoke { get; set; }

        public string  Heat { get; set; }
        public string zoneArea { get; set; }









    }
}
