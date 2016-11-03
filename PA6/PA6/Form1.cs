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
        public Cell[,] cellArray;
        public int row;
        public int col;
        public static float cellWidth, cellHeight;
        Pen pen = new Pen(Color.Black, 1);
        Grid grid;
        public Form1()
        {
            ShowStartupForm();
            InitializeComponent();
            SetCell();
            //LoadGrid();
        }

        public void SetCell()
        {
            cellHeight = (ClientSize.Height - menuStrip1.Height)/ (float)row;
            cellWidth = ClientSize.Width / (float)col;
        }

//        public void LoadGrid()
//        {
//            grid = new Grid(cellArray, cellHeight + menuStrip1.Height, cellWidth, e);
//        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            grid = new Grid(cellArray, cellHeight, cellWidth, menuStrip1.Height, e);

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
            int c = (int)Math.Floor((double) y/cellHeight);
            int r = (int)Math.Floor((double)x/cellWidth);
            grid.LoadCell(cellArray);
            cellArray[r,c].Paint = CreateGraphics();
            cellArray[r,c].Paint.FillRectangle(new SolidBrush(Color.Green), r * cellWidth, ((c * cellHeight) + menuStrip1.Height), cellWidth, cellHeight);
            cellArray[r, c].IsAlive = true;
            textBox1.Text = String.Format("x: {0}, y: {1}", r+1, c+1);
        }

       
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetCell();
            Invalidate();
        }

        private void clear_Grid(object sender, EventArgs e)
        {
            for (int i = 0; i < cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < cellArray.GetLength(1); j++)
                {
                    cellArray[i, j].IsAlive = false;

                }
            }
            Invalidate();
        }

        public void ShowStartupForm()
        {
            StartupForm StartupDialog = new StartupForm();
            var result = StartupDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                this.col = StartupDialog.StartupColumns;
                this.row = StartupDialog.StartupRows;
                cellArray = new Cell[row, col];
            }

        }
    }
}
