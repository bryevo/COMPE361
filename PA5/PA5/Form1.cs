using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PA5
{
    public partial class Form1 : Form
    {
        private int _counter;
        SoundPlayer ring = new SoundPlayer(Properties.Resources.my_name_jeff);
        public Form1()
        {
            InitializeComponent();
            lbTime.Text = DateTime.Now.ToString("MMM dd, yyyy      hh:mm:ss tt"); //Current Time
            dateTimeAlarm.Value = DateTime.Now.AddSeconds(10); //Default setting for alarm
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

        /// <summary>
        /// Adds the alarm to the queue.  Must checkbox/double click to activate alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            cbAlarm.Items.Add(dateTimeAlarm.Value);
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

        /// <summary>
        /// Functionality to change time/date easier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Activate message box if the alarm is checked off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alarm_Elapsed(object sender, EventArgs e)
        {
            int t = 0;

            //Checks the time for all checked elements for the alarm clock
            while (t < cbAlarm.CheckedItems.Count)
            {
                //if the alarm time is equal to the current time
                string alarm = cbAlarm.CheckedItems[t].ToString();
                if (alarm == DateTime.Now.ToString())
                {
                    //creates new message box which passes in the snooze timer
                    AlarmMessageBox message = new AlarmMessageBox(timer_Snooze);
                    message.Show();
                }
                t++;
            }
        }

        /// <summary>
        /// Counter to countdown the snooze timer in seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer_Snooze_Tick(object sender, EventArgs e)
        {
            //counter increments until it hits the set snooze time
            if (_counter < int.Parse(snzText.Text))
                _counter++;

            //once time it shows the alarm message box to stop/reset snooze
            else
            {
                timer_Snooze.Stop();
                _counter = 0;
                AlarmMessageBox message = new AlarmMessageBox(timer_Snooze);
                message.Show();
            }
        }

        /// <summary>
        /// increment the Snooze timer in seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snzAdd_Click(object sender, EventArgs e)
        {
            int add = int.Parse(snzText.Text);
            add++;
            snzText.Text = add.ToString();
        }

        /// <summary>
        /// decrement the Snooze timer in seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snzDel_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(snzText.Text);
            if (dec >= 2) //so the snooze cannot be less than 1 second
                dec--;
            snzText.Text = dec.ToString();
        }

        /// <summary>
        /// Prompts new window to add an appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddApp_Click(object sender, EventArgs e)
        {
            AppMessageBox app = new AppMessageBox(lbApp);
            app.ShowDialog();
        }

        /// <summary>
        /// Deletes the highlighted appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelApp_Click(object sender, EventArgs e)
        {
            lbApp.Items.Remove(lbApp.SelectedItem);
        }

        /// <summary>
        /// Opens the appointment's details, creates a new form
        /// which passes in the selected items details so it retains data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbApp_DoubleClick(object sender, EventArgs e)
        {
            AppMessageBox app = new AppMessageBox(lbApp.SelectedItem, lbApp);
            app.ShowDialog();
        }

        /// <summary>
        /// Timer for appointment due
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
//        private void timer_Appointment_Tick(object sender, EventArgs e)
//        {
//            int t = 0;
//            
//            //checks every item in the appointment list
//            while (t < lbApp.Items.Count)
//            {
//                List<object> compareType = new List<object>();
//
//                //gets the properties of each item
//                Type parseType = lbApp.Items[t].GetType();
//                IList<PropertyInfo> props = new List<PropertyInfo>(parseType.GetProperties());
//                foreach (PropertyInfo item in props)
//                {
//                    object propValue = item.GetValue(lbApp.Items[t], null); //stores the data in the List
//                    compareType.Add(propValue);
//                }
//
//                //I know that the index #1 dt is a datetime based on how i stored my data, so i
//                //compared it to the current time.  this will play the sound.
//                if (compareType[1].ToString().Equals(DateTime.Now.ToString()))
//                {
//                    SoundPlayer ring = new SoundPlayer(Properties.Resources.yeet);
//                    ring.PlayLooping();
//                    string msgStr = $"{compareType[0]} Due Now!\nNote: {compareType[3]}";
//                    MessageBox.Show(msgStr);
//                    ring.Stop();
//                }
//                t++;
//            }
//        }

        /// <summary>
        /// Timer for appointment reminder. same functionality as the appointment timer
        /// except it shows the animation; no sound.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Reminder_Tick(object sender, EventArgs e)
        {
            int t = 0;
            while (t < lbApp.Items.Count)
            {
                List<object> compareType = new List<object>();
                Type parseType = lbApp.Items[t].GetType();
                IList<PropertyInfo> props = new List<PropertyInfo>(parseType.GetProperties());
                foreach (PropertyInfo item in props)
                {
                    object propValue = item.GetValue(lbApp.Items[t], null);
                    compareType.Add(propValue);
                }
                if (compareType[2].ToString().Equals(DateTime.Now.ToString()))
                {
                    ring.Play();
                    picRemind.Visible = true;
                    lbReminder.Visible = true;

                }
                t++;
            }
        }

        private void lbAppointment_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ring.Stop();
            picRemind.Visible = false;
            lbReminder.Visible = false;
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Tip: Click on the Date/Time Picker and type to change the desired time for Alarm.\n        Double click or check the box to enable the alarm.\nTip: Double click the appointment to modify it.");
        }
    }
}