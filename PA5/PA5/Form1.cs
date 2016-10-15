using System;
using System.CodeDom.Compiler;
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
            lbTime.Text = DateTime.Now.ToString("MMM dd, yyyy      hh:mm:ss tt");
            //Current Time
            dateTimeAlarm.Value = DateTime.Now;
            cbOptions.SelectedIndex = 0;
        }
        /// <summary>
        /// Using timer to continously update the time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Time_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("MMM dd, yyyy      hh:mm:ss tt");
        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            cbAlarm.Items.Add(dateTimeAlarm.Value);
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOptions.SelectedIndex == 0)
            {
                cbOptions.BeginUpdate();
                dateTimeAlarm.CustomFormat = "hh:mm:ss tt";
                cbOptions.EndUpdate();

            }
            if (cbOptions.SelectedIndex == 1)
            {
                cbOptions.BeginUpdate();
                dateTimeAlarm.CustomFormat = "MM/dd/yyyy";
                cbOptions.EndUpdate();
            }
        }

        /// <summary>
        /// Delete the highlighted item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelAlarm_Click(object sender, EventArgs e)
        {
            cbAlarm.Items.Remove(cbAlarm.SelectedItem);
        }

        private void alarm_Elapsed(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString();
            int t = 0;
            while (t < cbAlarm.CheckedItems.Count)
            {
                string alarm = cbAlarm.CheckedItems[t].ToString();
                if (alarm == currentTime)
                {
                    timer_Snooze.Enabled = true;
                    AlarmMessageBox message = new AlarmMessageBox(timer_Snooze);
                    message.Show();
                }
                t++;
            }
        }

        //fix countdown
        public void timer_Snooze_Tick(object sender, EventArgs e)
        {
            for (int timer = Int32.Parse(snzText.Text); timer > 0; timer--)
            {
                if (timer == 0)
                    timer_Snooze.Stop();
                    AlarmMessageBox message = new AlarmMessageBox(timer_Snooze);
                    message.Show();
            }
        }

        private void snzAdd_Click(object sender, EventArgs e)
        {
            int add = Int32.Parse(snzText.Text);
            add++;
            snzText.Text = add.ToString();
        }

        private void snzDel_Click(object sender, EventArgs e)
        {
            int dec = Int32.Parse(snzText.Text);
            dec--;
            snzText.Text = dec.ToString();
        }
    }
}
