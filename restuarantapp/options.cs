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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            prkct++;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            bbqct++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chickct++;
            panel3.Hide();
        }
    }
}
