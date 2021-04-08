using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restuarantapp
{
    public partial class options : UserControl
    {
        double prkchop = 12.99;
        double bbq = 10.99;
        double chicken = 8.99;
        int prkct = 0;
        int bbqct = 0;
        int chickct = 0;
        
       
       
        public options()
            
        {
           

            InitializeComponent();
      


        }
        public options(string x)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            prkct++;
            textBox1.BringToFront();
            if (prkct % 2 == 0)
            {
                textBox1.Hide();
                button1.Text = "Info";
            }
            else
            {
                textBox1.Show();
                button1.Text = "Buy!";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.BringToFront();
        
            bbqct++;
            if (bbqct%2==0 )
            {
                textBox2.Hide();
                button2.Text = "Info";
            }
           if(bbqct % 3 == 0)
            {
                textBox2.Show();
                button2.Text = "Buy!";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            chickct++;
            textBox3.BringToFront();
            if (chickct % 2 == 0)
            {
                textBox3.Hide();
                button3.Text = "Info";
            }
            else
            {
                textBox3.Show();
                button3.Text = "Buy";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
