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
        /// <summary>
        /// StartupRows and StartupColumns are properties so that other forms can communicate with the data from this form
        /// </summary>
        public int StartupRows { get; set; }
        public int StartupColumns { get; set; }
        /// <summary>
        /// This is the click event that gets the values from the form elements and stores them in the class's properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetStartupDimensions_Click(object sender, EventArgs e)
        {
            StartupColumns = (int) numericUpDownColumns.Value;
            StartupRows = (int)numericUpDownRows.Value;
        }
    }
}
