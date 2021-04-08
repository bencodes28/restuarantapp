using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restuarantapp
{
    public partial class Form1 : Form
    {
        double prkchop = 12.99;
        double bbq = 10.99;
        double chicken = 8.99;
        int prkct = 0;
        int bbqct = 0;
        int chickct = 0;
        public Form1()
        {
            InitializeComponent();
            homePage1.BringToFront();
            homePage1.Refresh();
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage1.BringToFront();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            options1.Refresh();

            options1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GoodBye!");
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            takeout1.BringToFront();
          
        }

        private void takeout1_Load(object sender, EventArgs e)
        {

        }

        private void orderz1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderz1.BringToFront();
        }
    }
}
