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
    public partial class EvolutionRate : Form
    {
        public EvolutionRate()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This form sets the evolution rate. It uses properties to communicate with other forms
        /// </summary>
        public int EvoRate
        {
            get { return (int) numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        /// <summary>
        /// Sets the "EvoRate" property on click. Also sends the "OK" dialog result. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDone_Click(object sender, EventArgs e)
        {
            EvoRate = (int) numericUpDown1.Value;
            DialogResult = DialogResult.OK;
        }   
    }
}
