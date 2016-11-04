using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6
{
    public partial class Form1 : Form
    {

        int BMIN = 3;   //Birth Law min
        int BMAX = 3;   //Birth Law max
        int SMIN = 2;   //Survival Law min
        int SMAX = 3;   //Survival Law max
        int Generations = 10; //Generations to iterate when "Start" is pushed
        int generationCounter = 0;

        public Cell[,] cellArray;
        public int row;
        public int col;
        public static float cellWidth, cellHeight;
        Pen pen = new Pen(Color.Black, 1);
        SolidBrush sb = new SolidBrush(Color.Yellow);

        Grid grid;
        public Form1()
        {
            
            bool startGrid = ShowStartupForm();
            if (startGrid)
            {
                InitializeComponent();
                SetCell();
            } else {
                Application.Exit();
            }
                
            
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
            if (toggleGridToolStripMenuItem.Checked)
            {
                LoadGrid(e);
            }
            
        }

        public void LoadGrid(PaintEventArgs e)
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
            Graphics g = CreateGraphics();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    int x = e.X;
                    int y = e.Y - menuStrip1.Height;
                    int c = (int)Math.Floor((double)y / cellHeight);
                    int r = (int)Math.Floor((double)x / cellWidth);
                    cellArray = grid.getCellArray;
                    cellArray[r, c].ToggleAlive(true, g);
                    Console.WriteLine("Element {0},{1},{2}", cellArray[r,c].ElementX, cellArray[r,c].ElementY, cellArray[r, c].IsAlive);
                    Invalidate();
                    break;
                case MouseButtons.Right:
                    int x1 = e.X;
                    int y1 = e.Y - menuStrip1.Height;
                    int c1 = (int)Math.Floor((double)y1 / cellHeight);
                    int r1 = (int)Math.Floor((double)x1 / cellWidth);
                    cellArray = grid.getCellArray;
                    cellArray[r1, c1].ToggleAlive(false, g);
                    Console.WriteLine("Element {0},{1},{2}", cellArray[r1, c1].ElementX, cellArray[r1, c1].ElementY, cellArray[r1, c1].IsAlive);
                    Invalidate();
                    break;
            }
            
        }

       
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetCell();
            Invalidate();
        }

        private void evolutionParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvolutionParameters ep = new EvolutionParameters();
            
            ep.SMIN = this.SMIN;
            ep.SMAX = this.SMAX;
            ep.BMAX = this.BMAX;
            ep.BMIN = this.BMIN;
            ep.Generations = this.Generations;
            DialogResult dr = ep.ShowDialog();

            //retrieve the user set evolution paramters
            if (dr == DialogResult.OK)
            {
                this.BMIN = ep.BMIN;
                this.BMAX = ep.BMAX;
                this.SMIN = ep.SMIN;
                this.SMAX = ep.SMAX;
                this.Generations = ep.Generations;
                //Console.WriteLine("BMIN: {0}, BMAX: {1}, SMIN: {2}, SMAX: {3}, Generations: {4}", BMIN, BMAX, SMIN, SMAX, Generations);

               // label1.Text = String.Format("Bmin is {0}, Bmax is {1}, Smin is {2}, Smax is {3}", BMIN, BMAX, SMIN, SMAX);
            }
            //do nothing. dont really need this
            else if (dr == DialogResult.Cancel)
            {

            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            Graphics g = CreateGraphics();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.sb = new SolidBrush(cd.Color);
                for(int i = 0; i < cellArray.GetLength(0); i++)
                {
                    for(int j = 0; i < cellArray.GetLength(1); j++)
                    {
                        if (cellArray[i, j].IsAlive == false)
                            cellArray[i, j].ToggleAlive(false, g);
                    }
                }
            }
            

        }

        private void creatureColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                sb = new SolidBrush(cd.Color);
            }

            Invalidate();
        }

        private void gridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(cd.Color);
                // SetCell();
                Invalidate();
            }
        }

        public bool ShowStartupForm()
        {
            StartupForm StartupDialog = new StartupForm();
            var result = StartupDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                this.col = StartupDialog.StartupColumns;
                this.row = StartupDialog.StartupRows;
                cellArray = new Cell[row, col];
                return true;
            } else
            {
                return false;
            }
            

        }

        private void generateRandomStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid = grid.randomGrid(grid);
            Invalidate();
        }
        List<Cell> cellsToActivate = new List<Cell>();
        List<Cell> cellsToKill = new List<Cell>();
        private void checkNeighbors(Cell[,] cellArray, int r, int c)
        {
            int activeNeighbors = 0;
            int[] temp = new int[12];
            //neighbor 1
            temp[0] = mod((c - 1), col);
            //Console.WriteLine("Checking element {0}, {1}", r, temp[0]);
            if (cellArray[r, mod((c - 1), col)].IsAlive) { activeNeighbors++; }
            //n2
            temp[1] = mod((r - 1), col);
            temp[2] = mod((c - 1), col);
            //Console.WriteLine("Checking element {0}, {1}", temp[1], temp[2]);
            if (cellArray[mod((r - 1), row), mod((c - 1), col)].IsAlive) { activeNeighbors++; }
            //n3
            temp[3] = mod((r - 1), row);
           // Console.WriteLine("Checking element {0}, {1}", temp[3], c);
            if (cellArray[mod((r - 1), row), c].IsAlive) { activeNeighbors++; }
            //n4
            temp[4] = mod((r - 1), row);
            temp[5] = mod((c + 1), col);
           // Console.WriteLine("Checking element {0}, {1}", temp[4], temp[5]);
            if (cellArray[mod((r - 1), row), mod((c + 1), col)].IsAlive) { activeNeighbors++; }
            //n5
            temp[6] = mod((c + 1), col);
           // Console.WriteLine("Checking element {0}, {1}", r, temp[6]);
            if (cellArray[r, mod((c + 1), col)].IsAlive) { activeNeighbors++; }
            //n6
            temp[7] = mod((r + 1), row);
            temp[8] = mod((c + 1), col);
            ///Console.WriteLine("Checking element {0}, {1}", temp[7], temp[8]);
            if (cellArray[mod((r + 1), row), mod((c + 1), col)].IsAlive) { activeNeighbors++; }
            //n7
            temp[9] = mod((r + 1), row);
            //Console.WriteLine("Checking element {0}, {1}", temp[9], c);
            if (cellArray[mod((r + 1), row), c].IsAlive) { activeNeighbors++; }
            //n8
            temp[10] = mod((r + 1), row);
            temp[11] = mod((c - 1), col);
            //Console.WriteLine("Checking element {0}, {1}", temp[10], temp[11]);
            if (cellArray[mod((r + 1), row), mod((c - 1), col)].IsAlive) { activeNeighbors++; }

            //this checks alive cell with neighbors
            //Console.WriteLine("Element: {0},{1} Neighboors {2}", r,c,activeNeighbors);
            //survival
            if (cellArray[r,c].IsAlive && activeNeighbors >= SMIN && activeNeighbors <= SMAX)
            {
                //cellArray[r, c].ToggleAlive(true, g);
                cellsToActivate.Add(cellArray[r, c]);
            }
            else if (!cellArray[r, c].IsAlive && (activeNeighbors >= BMIN && activeNeighbors <= BMAX)){
                //cellArray[r, c].ToggleAlive(true, g);
                cellsToActivate.Add(cellArray[r, c]);
            }

            else {
                cellsToKill.Add(cellArray[r, c]);
                //cellArray[r, c].ToggleAlive(false, g);
            }
        }

       

        private void oneGeneration()
        {
            generationTimer.Interval = (int) (1000 / numEvoRate.Value);
            for (int i = 0; i < cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < cellArray.GetLength(1); j++)
                {
                    checkNeighbors(cellArray, i, j);
                }
            }
            activateCellList(cellsToActivate);
            killCellList(cellsToKill);
            cellsToActivate.Clear();
            cellsToKill.Clear();
            generationLabel.Text = String.Format("Successful Generation: {0}", ++this.generationCounter);
        }
        int mod(int a, int n)
        {
           int result = ((a % n) + n) % n;
            //Console.WriteLine("Modulo is: {0}", result);
            return result;
        }

        private void killCellList(List<Cell> temp)
        {
            Graphics g = CreateGraphics();
            foreach (Cell c in temp){
                //Console.WriteLine("Killing {0},{1}", c.ElementRow, c.ElementColumn);
                c.ToggleAlive(false, g);
            }
        }
        int index = 0;
        private void generationTimer_Tick(object sender, EventArgs e)
        {
            if (index < Generations)
            {
                oneGeneration();
                Invalidate();
                index++;
            }
        /*
            for (int i = 0; i < Generations; i++)
            {
                oneGeneration();

                Invalidate();
            }
            */
        }

        private void singleStepEvolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oneGeneration();
            Invalidate();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.index == Generations)                            //if game has already started, continue with the last gen by setting index to counter
            {
                this.index = 0;
            }
            //generationTimer.Enabled = true;
            generationTimer.Start();
        }

        private void clear_Grid(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            // this.generationTimer.Enabled = false;
            for (int i = 0; i < cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < cellArray.GetLength(1); j++)
                {
                    cellArray[i, j].IsAlive = false;
                    //cellArray[i, j].ToggleAlive(false, g);
                }
            }
            //this.generationCounter = 0;
            Invalidate();
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.index = generationCounter;
            this.generationTimer.Stop();
        }

        private void toggleGridToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (toggleGridToolStripMenuItem.Checked)
            {
                toggleGridToolStripMenuItem.Text = "Grid Toggle: OFF";
                toggleGridToolStripMenuItem.Checked = false;
                Invalidate();
            }
            else if (!toggleGridToolStripMenuItem.Checked)
            {
                toggleGridToolStripMenuItem.Text = "Grid Toggle: ON";
                toggleGridToolStripMenuItem.Checked = true;
                Invalidate();
            }
        }

        private void activateCellList(List<Cell> temp1)
        {
            Graphics g = CreateGraphics();
            foreach (Cell c in temp1)
            {
                //Console.WriteLine("Activating {0},{1}", c.ElementRow, c.ElementColumn);
                c.ToggleAlive(true, g);
            }
        }
        


    }
}
