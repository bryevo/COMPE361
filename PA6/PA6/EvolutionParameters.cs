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
    public partial class EvolutionParameters : Form
    {
        public EvolutionParameters()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the click event that sends back the "OK" dialog result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }
        /// <summary>
        /// All of these are properties from the class so that the form can comunicate with other forms  
        /// </summary>
        public int BMIN
        {
            get { return (int)numBMIN.Value; }
            set { numBMIN.Value = (int)value; }
        }

        public int BMAX
        {
            get { return (int)numBMAX.Value; }
            set { numBMAX.Value = (int)value; }
        }

        public int SMIN
        {
            get { return (int)numSMIN.Value; }
            set { numSMIN.Value = (int)value; }
        }

        public int SMAX
        {
            get { return (int)numSMAX.Value; }
            set { numSMAX.Value = (int)value; }
        }
        public int Generations
        {
            get { return (int)numericUpDownGenerations.Value; }
            set { numericUpDownGenerations.Value = (int)value; }
        }
    }
}
