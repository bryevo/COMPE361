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
    public partial class AppMessageBox : Form
    {
        private Button _btn;
        public AppMessageBox(Button btn)
        {
            _btn = btn;
            InitializeComponent();
            dtApp.Value = DateTime.Now.AddSeconds(20);  //Default setting for appointment
            cbApp.SelectedIndex = 0;
            dtReminder.Value = DateTime.Now.AddSeconds(10);  //Default setting for reminder
            cbReminder.SelectedIndex = 0;
        }

        public AppMessageBox()
        {
            
        }
        private void cbApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbApp.SelectedIndex == 0)
            {
                cbApp.BeginUpdate();
                dtApp.CustomFormat = "hh:mm:ss tt";
                cbApp.EndUpdate();

            }
            if (cbApp.SelectedIndex == 1)
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
            if (cbReminder.SelectedIndex == 1)
            {
                cbReminder.BeginUpdate();
                dtReminder.CustomFormat = "MM/dd/yyyy";
                cbReminder.EndUpdate();
            }
        }

        private void btnSetApp_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
