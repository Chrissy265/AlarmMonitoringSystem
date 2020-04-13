using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmMonitor
{
    public partial class MonitorPanel : Form
    {
        public MonitorPanel()
        {
            InitializeComponent();
        }

        //public string[] numberEntries = new string[5];
        //Create a global list that keeps the number of entries stored 
        List <string> numbersEntered = new List<string>();
        private readonly int intnumList;

        public void displayPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPanel.View = View.SmallIcon;
             
            displayPanel.Columns.Add("Pin Code", -2,HorizontalAlignment.Left); 
            
            ListViewItem item = new ListViewItem();

        displayPanel.View = View.List;

            displayPanel.Items.Add(item);

           

            //ListViewItem item = new ListViewItem();

            //string num = "0";
            //item.Text = num.ToString();




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

   
    }
}
