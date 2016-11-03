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
        int BMIN;   //Birth Law min
        int BMAX;   //Birth Law max
        int SMIN;   //Survival Law min
        int SMAX;   //Survival Law max

        public int row;
        public int col;
        public static float cellWidth, cellHeight;
        Pen pen = new Pen(Color.Black, 1);
        SolidBrush sb = new SolidBrush(Color.Yellow);
        Grid grid;
        public Form1()
        {
            ShowStartupForm();
            InitializeComponent();
            SetCell();

            //Default evolution parameters
            BMIN = 3;
            BMAX = 3;
            SMIN = 2;
            SMAX = 3;
        }

        public void SetCell()
        {
            cellHeight = (ClientSize.Height - menuStrip1.Height)/ (float)row;
            cellWidth = ClientSize.Width / (float)col;
        }

//        public void LoadGrid()
//        {
//            grid = new Grid(row, col, cellHeight, cellWidth);
//        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.label1.Text = "cell height: " + cellHeight;
            this.label2.Text = "cell width: " + cellWidth;

            grid = new Grid(cellArray, cellHeight + menuStrip1.Height, cellWidth, e);
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
            int r = (int)Math.Floor((double) y/cellHeight);
            int c = (int)Math.Floor((double)x/cellWidth);
            textBox1.Text = String.Format("{0}, {1}", x, y);

            this.cellArray = grid.getCellArray;
            Graphics g = CreateGraphics();
            cellArray[r,c].Paint = CreateGraphics();
            //g.FillRectangle(sb, (r * cellHeight), (cellHeight * cellWidth), cellWidth, cellHeight);
            cellArray[r,c].Paint.FillRectangle(new SolidBrush(Color.Blue), ((c) * cellWidth), ((r * cellHeight) + menuStrip1.Height), cellWidth, cellHeight);

        }

       
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetCell();
            Invalidate();
        }

        private void evolutionParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvolutionParameters ep = new EvolutionParameters();
            DialogResult dr = ep.ShowDialog();

            //retrieve the user set evolution paramters
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.BMIN = ep.BMIN;
                this.BMAX = ep.BMAX;
                this.SMIN = ep.SMIN;
                this.SMAX = ep.SMAX;

                //testing values
                label3.Text = String.Format("BMIN is {0}, BMAX is {1}, SMIN is {2}, SMAX is {3}", BMIN, BMAX, SMIN, SMAX);
            }
            //do nothing. dont really need this
            else if (dr == System.Windows.Forms.DialogResult.Cancel)
            {

            }

            
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
