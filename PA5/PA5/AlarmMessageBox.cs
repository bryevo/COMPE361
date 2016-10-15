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

    public partial class AlarmMessageBox : Form
    {
        private readonly Timer _timer;
        public AlarmMessageBox(Timer timer)
        {
            InitializeComponent();
            _timer = timer;
        }
        public AlarmMessageBox()
        {
            InitializeComponent();
        }

        public void btSnooze_Click(object sender, EventArgs e)
        {
            _timer.Enabled = true;
            Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
