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
        public Form1()
        {
            InitializeComponent();
            homePage1.BringToFront();
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
            options1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GoodBye!");
            Close();
        }
    }
}
