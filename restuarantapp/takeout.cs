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
    public partial class takeout : UserControl
    {

        double porkchops = 12.99;
        double fried = 8.99;
        double bbq = 10.99;
        double total = 0;
        double fries = 1.99;
        double drink = 2.99;

        public takeout()
        {

            InitializeComponent();
            prkchoplabel.Hide();
            label3.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
        }

        private void takeout_Load(object sender, EventArgs e)
        {
           
           
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Fried Chicken")
            {
                label6.Show();
                total += fried;
                label5.Text = total.ToString();
            }
            if (comboBox1.SelectedItem == "Pork Chops")
            {
                ///label6.Hide();
                total += porkchops;
                prkchoplabel.Show();
                label5.Text = total.ToString();
            }
          if (comboBox1.SelectedItem == "BBQ Sandwhich")
            {
              //  prkchoplabel.Hide();
                total += bbq;
                label3.Show();
                label5.Text = total.ToString();
            }
         if (comboBox1.SelectedItem == "Fries")
            {
                //label3.Hide();
                total += fries;
                label7.Show();
                label5.Text = total.ToString();
            }
         if(comboBox1.SelectedItem== "Drink")
            {
                total += drink;
                label8.Show();
                label5.Text = total.ToString();
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            total = 0;
            label5.Text = "";
            label3.Hide();
            label6.Hide();
            label7.Hide();
            label10.Hide();
            prkchoplabel.Hide();
            label9.Hide();
            label8.Hide();

        }

        private void prkchoplabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label9.Show();
            label10.Show();
            label10.Text = total.ToString();
            label2.Text = "Total Checkout";
            label1.Text = "Final Order";
            MessageBox.Show("Thank u, Order Complete!");
            reseter();
            void reseter()
            {
                total = 0;
                label5.Text = "";
                label3.Hide();
                label6.Hide();
                label7.Hide();
                label10.Hide();
                prkchoplabel.Hide();
                label9.Hide();
                label8.Hide();

            }

    }
    }
    }
