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
        private ListBox _app;
        private object _obj;
        private List<object> refer = new List<object>();
        public AppMessageBox(ListBox app)
        {
            _app = app;
            InitializeComponent();
            dtApp.Value = DateTime.Now.AddSeconds(20);  //Default setting for appointment
            cbApp.SelectedIndex = 0;
            dtReminder.Value = DateTime.Now.AddSeconds(10);  //Default setting for reminder
            cbReminder.SelectedIndex = 0;
        }

        public AppMessageBox(object obj, ListBox app)
        {
            _obj = obj;
            _app = app;
            Type parseObj = _obj.GetType();
            InitializeComponent();
            IList<PropertyInfo> props = new List<PropertyInfo>(parseObj.GetProperties());
            foreach (PropertyInfo item in props)
            {
                object propValue = item.GetValue(_obj, null);
                refer.Add(propValue);
            }
            tbName.Text = refer[0].ToString();
            dtApp.Value = (DateTime)refer[1];
            dtReminder.Value = (DateTime)refer[2];
            tbNote.Text = refer[3].ToString();
            cbApp.SelectedIndex = 0;
            cbReminder.SelectedIndex = 0;
        }

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


    private void btnSetApp_Click(object sender, EventArgs e)
        {
           Appointment info = new Appointment();
            info.Name = tbName.Text;
            info.Note = tbNote.Text;
            info.AppDateTime = dtApp.Value;
            info.ReminderTime = dtReminder.Value;
            if (_obj != null)
            {
                if (_app.SelectedItem.Equals(_obj))
                {
                    _app.Items.Remove(_app.SelectedItem);
                    _app.DisplayMember = "Name";
                    _app.Items.Add(info);
                }
            }
            else
            {
                _app.DisplayMember = "Name";
                _app.Items.Add(info);
            }
            Dispose();
        }
    }
}
