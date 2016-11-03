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

        public int BMIN
        {
            get { return (int)numBMIN.Value; }
        }

        public int BMAX
        {
            get { return (int)numBMAX.Value; }
        }

        public int SMIN
        {
            get { return (int)numBMIN.Value; }
        }

        public int SMAX
        {
            get { return (int)numSMAX.Value; }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
