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

        public int EvoRate
        {
            get { return (int) numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            EvoRate = (int) numericUpDown1.Value;
            DialogResult = DialogResult.OK;
        }

       
    }
}
