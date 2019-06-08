using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ManagerClass manager;
        public int date;

        private void button_start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                manager = new ManagerClass(label_y, label_x, label_ta, flowpanel_agent);
                timer1.Enabled = true;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            manager.TimerTick((double)date/10);
            date++;
            label_time.Text = "Time: " + (double)date / 10;
        }
    }
}
