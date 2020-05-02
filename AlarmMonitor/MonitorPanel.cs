using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmMonitor.Model; 


namespace AlarmMonitor
{
    public partial class MonitorPanel : Form
    { 
        public MonitorPanel()
        {
            InitializeComponent();
        }

   

       
     


        private void enteredSecurityPin()
        {
            //string one = "1";

            //ListViewItem item = new ListViewItem();
            //displayPanel.Items.Add(item);
            //item.Text = one.ToString();

            //if (item != null)
            //{
            //    numbersEntered.Add(one);
            //}


            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);

            //Tell the user insert pin 
            string EnteredpinSecurity = "Insert pin";
            string notifyService = "Notifying Service"; 

            item.Text = EnteredpinSecurity.ToString();

            //string pinSecurity = "1234";


            Timer timer = new Timer();
            //Keep track how much time is remaining
            int timeLeft = 60;

            timer.Start();
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                //firehazard_listView.Items.Add(item);
                item.Text = timeLeft + "seconds";
                
                if(pinSecurity.Contains("1234"))
                {
                    timer.Stop(); 
                }
                else
                {
                    item.Text = notifyService;


                    notifyServices();
                }
            }
        
         
        }

        private void notifyServices()
        {

            string contact911 = "Contacting 911";
            string notifyMonitorService = "Contacting IIS";

            firehazard_listView.View = View.Details;
            firehazard_listView.Columns.Add("Notify Service", -2, HorizontalAlignment.Center);

            ListViewItem item = new ListViewItem();
            firehazard_listView.View = View.Details;

           
                item.Text = contact911;
                item.Text = notifyMonitorService;
                firehazard_listView.Items.Add(item);
            
            
            
        }
        //public string[] numberEntries = new string[5];
        //Create a global list that keeps the number of entries stored 
        List <string> numbersEntered = new List<string>();

        List<string> pinSecurity = new List<string>();

        private readonly int intnumList;
        private readonly int pin_entered;
        public int securityPinForPanel = 1234;

        public void displayPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPanel.View = View.SmallIcon;
             
            displayPanel.Columns.Add("Pin Code", -2,HorizontalAlignment.Center); 
            
            ListViewItem item = new ListViewItem();

        displayPanel.View = View.List;

            displayPanel.Items.Add(item);



            //ListViewItem item = new ListViewItem();

            //string num = "0";
            //item.Text = num.ToString();




        }


        private void firehazard_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            firehazard_listView.View = View.LargeIcon;
            firehazard_listView.Columns.Add("Fire Hazard :", -2, HorizontalAlignment.Left);
            


        }

       

        

        private void btnThree_Click(object sender, EventArgs e)
        {
            string three = "3";

          
            
           
            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            
            item.Text = three.ToString(); 
            
            if(item != null)

            {
                
                numbersEntered.Add(three); 
            }

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            string one = "1";

            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text = one.ToString(); 

            if(item != null)
            {
                numbersEntered.Add(one); 
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            string two = "2";


            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text = two.ToString();

            if(item != null)
            {
                numbersEntered.Add(two); 
            }

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            string four = "4";

            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text = four.ToString();

            if(item != null)
            {
                numbersEntered.Add(four); 
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            string five = "5";

            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text = five.ToString();

            if(item != null)
            {
                numbersEntered.Add(five); 
            }

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            string six = "6";

            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text = six.ToString();

            if(item !=null)
            {
                numbersEntered.Add(six); 
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            string seven = "7";
            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text = seven.ToString();

            if(item !=null)
            {
                numbersEntered.Add(seven); 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eight = "8";

            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text = eight.ToString();

            if(item !=null)
            {
                numbersEntered.Add(eight); 
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            string nine = "9";

            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text = nine.ToString();

            if(item !=null)
            {
                numbersEntered.Add(nine); 
            }


        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            string zero = "0";

            ListViewItem item = new ListViewItem();
            displayPanel.Items.Add(item);
            item.Text =zero.ToString();

            if(item != null)
            {
                numbersEntered.Add(zero); 
            }


        }

    
        private void btnEnter_Click(object sender, EventArgs e)
        {

            //var pin_entered = pinSecurity.Select(n => Convert.ToInt32(n)).ToList();
            //ListViewItem item = new ListViewItem();
            
            //firehazard_listView.Focus();
            //if (firehazard_listView.Items.Contains()
            //{
            //    firehazard_listView.SelectedIndices.Contains(securityPinForPanel);
            //    enteredSecurityPin();
            //}

           



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Convert the list from string to int list 
            //List<string> numbersEntered = new List<string>();
            var intNumsList = numbersEntered.Select(n => Convert.ToInt32(n)).ToList();
            
        
            displayPanel.Focus();


            if (displayPanel.Items[intnumList].Selected ==true)
            {
                displayPanel.Items.RemoveAt(0);  // removes the first item on the list
            }
        
           
        }

        private void btnSensor1_Click(object sender, EventArgs e)
        {
            
            
            Sensor sensor1 = new Sensor();
            
            sensor1.Fire = "Fire";
            sensor1.zoneArea = "Kitchen";


            ListViewItem item = new ListViewItem();
            ListViewItem item2 = new ListViewItem(); 
            firehazard_listView.Items.Add(item);
            displayPanel.Items.Add(item2); 
            item.Text = sensor1.Fire.ToString();
            item2.Text = sensor1.zoneArea.ToString();

            enteredSecurityPin();

        }

        private void btnSensor2_Click(object sender, EventArgs e)
        {
            Sensor sensor2 = new Sensor();

            sensor2.Smoke = "Smoke";
            sensor2.zoneArea = "Dining Area";

            ListViewItem item = new ListViewItem();
            ListViewItem item2 = new ListViewItem(); 
            firehazard_listView.Items.Add(item);
            displayPanel.Items.Add(item2); 
            item.Text = sensor2.Smoke.ToString();
            item2.Text = sensor2.zoneArea.ToString(); 

            enteredSecurityPin(); 
        }

        private void btnSensor3_Click(object sender, EventArgs e)
        {
            Sensor sensor3 = new Sensor();

            sensor3.Heat = "Overheating Alert";
            sensor3.zoneArea = "Kitchen";

            ListViewItem item = new ListViewItem();
            ListViewItem item2 = new ListViewItem(); 
            firehazard_listView.Items.Add(item);
            displayPanel.Items.Add(item2); 
            item.Text = sensor3.Heat.ToString();
            item2.Text = sensor3.zoneArea.ToString(); 

            enteredSecurityPin(); 
        }
    }
}
