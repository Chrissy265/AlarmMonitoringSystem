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
    public partial class SensorStrobe : Form
    {
        public SensorStrobe()
        {
            InitializeComponent();
        }

        //pen - for border color 
        Pen black = new Pen(Color.Black);

        //fill shape
        System.Drawing.SolidBrush fillBlack = new System.Drawing.SolidBrush(Color.Black);

        //Create the shape in this order (x position, y position, width and height 
        Rectangle circle = new Rectangle(20, 20, 220, 90);
        

        private void SensorStrobe_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(black, circle); //draw circle 

            //g.FillRectangles(fillBlack, rect); //fill rectangle 
        }

        private void SensorText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
