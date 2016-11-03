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
    public partial class Form1 : Form
    {
        public int row = 20;
        public int col = 20;
        public static float cellWidth, cellHeight;
        Pen pen = new Pen(Color.Black, 1);
        Grid grid;
        public Form1()
        {
            InitializeComponent();
            SetCell();
            LoadGrid();
        }

        public void SetCell()
        {
            cellHeight = (ClientSize.Height - menuStrip1.Height)/ (float)row;
            cellWidth = ClientSize.Width / (float)col;
        }

        public void LoadGrid()
        {
            grid = new Grid(row, col, cellHeight, cellWidth);
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float x = 0;
            float y = menuStrip1.Height;
            for (int i = 1; i < col + 1; i++)
            {
                //Offset Drawing row lines to start at the base of the menuStrip
                g.DrawLine(pen, x, y, x, menuStrip1.Height + ClientSize.Height);
                x += cellWidth;
            }
            x = 0;
            for (int i = 1; i < row + 1; i++)
            {
                //Offset Drawing row lines to start at the base of the menuStrip
                g.DrawLine(pen, x, y, ClientSize.Width, y);
                y += cellHeight;
            }
        }

        /// <summary>
        /// Mouse event that gets the coordinate of the mouse click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y - menuStrip1.Height;
            int r = (int)Math.Ceiling((double) y/cellHeight);
            int c = (int)Math.Ceiling((double)x/cellWidth);
            textBox1.Text = String.Format("{0}, {1}", x, y);
    

        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResizeGrid newGrid = new ResizeGrid(this, grid);
            newGrid.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetCell();
            Invalidate();
        }
    }
}
