using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5
{
    public partial class AppMessageBox : Form
    {
        private ListBox _app;   //variables to manipulate data from Form1
        private object _obj;
        private readonly List<object> _storeProperties = new List<object>();

        /// <summary>
        /// Constructor for the Appointment Message box
        /// </summary>
        /// <param name="app"></param>
        public AppMessageBox(ListBox app)
        {
            _app = app;
            InitializeComponent();
            dtApp.Value = DateTime.Now.AddSeconds(20);  //Default setting for appointment
            cbApp.SelectedIndex = 0;
            dtReminder.Value = DateTime.Now.AddSeconds(10);  //Default setting for reminder
            cbReminder.SelectedIndex = 0;
        }

        /// <summary>
        /// Another constructor for the message box
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="app"></param>
        public AppMessageBox(object obj, ListBox app)
        {
            //sets variables
            _obj = obj;
            _app = app;

            //gets the properties of each item
            Type parseObj = _obj.GetType();
            InitializeComponent();
            IList<PropertyInfo> props = new List<PropertyInfo>(parseObj.GetProperties());
            foreach (PropertyInfo item in props)
            {
                object propValue = item.GetValue(_obj, null); //stores the data in the List
                _storeProperties.Add(propValue);
            }

            //sets data in the form from the List of stored properties
            tbName.Text = _storeProperties[0].ToString();
            dtApp.Value = (DateTime)_storeProperties[1];
            dtReminder.Value = (DateTime)_storeProperties[2];
            tbNote.Text = _storeProperties[3].ToString();
            cbApp.SelectedIndex = 0;
            cbReminder.SelectedIndex = 0;
        }

        /// <summary>
        /// changes the date and time format for appointment due
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbApp.SelectedIndex == 0)
            {
                cbApp.BeginUpdate();
                dtApp.CustomFormat = "hh:mm:ss tt";
                cbApp.EndUpdate();

            }
            else if (cbApp.SelectedIndex == 1)
            {
                cbApp.BeginUpdate();
                dtApp.CustomFormat = "MM/dd/yyyy";
                cbApp.EndUpdate();
            }
        }

        /// <summary>
        /// changes the date and time format for reminder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbReminder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReminder.SelectedIndex == 0)
            {
                cbReminder.BeginUpdate();
                dtReminder.CustomFormat = "hh:mm:ss tt";
                cbReminder.EndUpdate();

            }
            else if (cbReminder.SelectedIndex == 1)
            {
                cbReminder.BeginUpdate();
                dtReminder.CustomFormat = "MM/dd/yyyy";
                cbReminder.EndUpdate();
            }
        }

        /// <summary>
        /// the Ok button in the appointment form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetApp_Click(object sender, EventArgs e)
        {
            //create a new appointment class; set its properties to the data in the form
            Appointment info = new Appointment();
            info.Name = tbName.Text;
            info.Note = tbNote.Text;
            info.AppDateTime = dtApp.Value;
            info.ReminderTime = dtReminder.Value;

            //this is a check for when after you add your first appointment/change its data and won't affect other appointments
            if (_obj != null)
            {
                //if your selected item in your appointment listBox is equal to the data youre manipulating
                if (_app.SelectedItem.Equals(_obj))
                {
                    //remove old and insert new data
                    _app.Items.Remove(_app.SelectedItem);
                    _app.DisplayMember = "Name";
                    _app.Items.Add(info);
                }
            }
            else //if youre adding your first appointment data
            {
                _app.DisplayMember = "Name";
                _app.Items.Add(info);
            }
            Dispose();
        }
    }
}
