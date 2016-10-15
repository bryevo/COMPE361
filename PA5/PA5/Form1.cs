using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbTime.Text = DateTime.Now.ToString();  //Current Time
        }
        /// <summary>
        /// Using timer to continously update the time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Time_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
        }
    }
}
