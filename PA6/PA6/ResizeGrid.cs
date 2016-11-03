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
        private Grid grid;
        public ResizeGrid()
        {
            InitializeComponent();
        }
        public ResizeGrid(Form1 form1, Grid grid)
        {
            InitializeComponent();
            this._form = form1;
            this.grid = grid;
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
                grid.ResizeGrid(Int32.Parse(txtRow.Text), Int32.Parse(txtRow.Text));    //resize grid
                _form.SetCell();
                _form.Invalidate();
                Close();
            }
        }
    }
}
