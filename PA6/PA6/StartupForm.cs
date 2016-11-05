using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }
        public int StartupRows { get; set; }
        public int StartupColumns { get; set; }

        private void buttonSetStartupDimensions_Click(object sender, EventArgs e)
        {
            StartupColumns = (int) numericUpDownColumns.Value;
            StartupRows = (int)numericUpDownRows.Value;
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
