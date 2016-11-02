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
    public partial class ResizeGrid : Form
    {
        private Form1 _form;
        public ResizeGrid()
        {
            InitializeComponent();
        }
        public ResizeGrid(Form1 form1)
        {
            InitializeComponent();
            this._form = form1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((Int32.Parse(txtRow.Text) > 1000) || (Int32.Parse(txtRow.Text) > 1000))
            {
                MessageBox.Show("Grid cannot exceed 1000x1000 row/column");
            }
            else
            {
                _form.row = Int32.Parse(txtRow.Text);
                _form.col = Int32.Parse(txtCol.Text);
                _form.SetCell();
                _form.Invalidate();
                Close();
            }
        }
    }
}
