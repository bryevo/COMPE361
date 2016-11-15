using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6
{
    public partial class Form1 : Form
    {
        int BMIN = 3; //Birth Law min
        int BMAX = 3; //Birth Law max
        int SMIN = 2; //Survival Law min
        int SMAX = 3; //Survival Law max
        int Generations = 10; //Generations to iterate when "Start" is pushed
        int index, generationCounter, evolutionRate;
        List<Cell> cellsToActivate = new List<Cell>();  //holds cells to be activated
        List<Cell> cellsToKill = new List<Cell>();      //holds cells to be killed
        public Cell[,] cellArray;                       //2 dimensional cell array
        public int row;
        public int col;
        public static float cellWidth, cellHeight;
        Pen pen = new Pen(Color.Black, 1);
        SolidBrush sbAlive = new SolidBrush(Color.Green);
        SolidBrush sbDead = new SolidBrush(Color.DarkGray);
        Grid grid;  //creating a grid object that is going to hold the cells

        /// <summary>
        /// When the program starts, the start up form pops up. User sets the grid dimensions in this form.
        /// </summary>
        public Form1()
        {
            bool startGrid = ShowStartupForm();
            if (startGrid)
            {
                InitializeComponent();
                SetCell();
            }
            else
                Application.Exit();
        }

        /// <summary>
        /// Sets the cell width and cell height.
        /// The Clientsize height needs to be subtracted by the menustrip to offset the height of the menustrip
        /// </summary>
        public void SetCell()
        {
            cellHeight = (ClientSize.Height - menuStrip1.Height)/(float) row;
            cellWidth = ClientSize.Width/(float) col;
        }

        /// <summary>
        /// If user clicks on the grid toggle option, load the grid.
        /// If grid has not been created yet, create a new grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (toggleGridToolStripMenuItem.Checked)
                LoadGrid(e);
            grid = new Grid(cellArray, cellHeight, cellWidth, menuStrip1.Height, e, sbAlive, sbDead);
        }

        /// <summary>
        /// Draw grid lines based on the grid dimensions the user set on the start up form
        /// </summary>
        /// <param name="e"></param>
        public void LoadGrid(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            BackColor = pen.Color;
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
        /// Left click activate cells to alive
        /// Right click deactive cells to dead
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            try
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        int x = e.X;
                        int y = e.Y - menuStrip1.Height;
                        int c = (int) Math.Floor((double) y/cellHeight);
                        int r = (int) Math.Floor((double) x/cellWidth);
                        cellArray = grid.GetCellArray;
                        cellArray[r, c].ToggleAlive(true, g, sbAlive);
                        break;
                    case MouseButtons.Right:
                        int x1 = e.X;
                        int y1 = e.Y - menuStrip1.Height;
                        int c1 = (int) Math.Floor((double) y1/cellHeight);
                        int r1 = (int) Math.Floor((double) x1/cellWidth);
                        cellArray = grid.GetCellArray;
                        cellArray[r1, c1].ToggleAlive(false, g, sbDead);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Something went wrong. Please enter valid values.");
                Dispose();
            }
        }

        /// <summary>
        /// Whenever the form is resized, program gets the new cell width and height.
        /// Then redraw the grid based on the cell dimensions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetCell();
            Invalidate();
        }

        /// <summary>
        /// When user clicks on the evolution parameters option, a new form pops up where the user
        /// can set the values for SMIN, SMAX, BMAX, BMIN, and generations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evolutionParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvolutionParameters ep = new EvolutionParameters();
            ep.SMIN = SMIN;
            ep.SMAX = SMAX;
            ep.BMAX = BMAX;
            ep.BMIN = BMIN;
            ep.Generations = Generations;
            DialogResult dr = ep.ShowDialog();

            //retrieve the user set evolution paramters
            if (dr == DialogResult.OK)
            {
                BMIN = ep.BMIN;
                BMAX = ep.BMAX;
                SMIN = ep.SMIN;
                SMAX = ep.SMAX;
                Generations = ep.Generations;
            }
            else if (dr == DialogResult.Cancel){}
        }
        /// <summary>
        /// This function sets a different background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            Graphics g = CreateGraphics();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                sbDead = new SolidBrush(cd.Color);
                for (int i = 0; i < cellArray.GetLength(0); i++)
                    for (int j = 0; j < cellArray.GetLength(1); j++)
                        if (cellArray[i, j].IsAlive == false)
                            cellArray[i, j].ToggleAlive(false, g, sbDead);
            }
        }
        /// <summary>
        /// This function changes the color of the cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void creatureColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                sbAlive = new SolidBrush(cd.Color);
                for (int i = 0; i < cellArray.GetLength(0); i++)
                    for (int j = 0; j < cellArray.GetLength(1); j++)
                        if (cellArray[i, j].IsAlive)
                            cellArray[i, j].ToggleAlive(true, g, sbAlive);
            }
        }
        /// <summary>
        /// This function changes the color of the grid lines
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(cd.Color);
                Invalidate();
            }
        }
        /// <summary>
        /// This function shows the "StartUp" form that allows the user to select the starting dimensions
        /// </summary>
        /// <returns></returns>
        public bool ShowStartupForm()
        {
            StartupForm StartupDialog = new StartupForm();
            var result = StartupDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                col = StartupDialog.StartupColumns;
                row = StartupDialog.StartupRows;
                cellArray = new Cell[col, row];
                return true;
            }
            return false;
        }
        /// <summary>
        /// This function goes through each cell and checks its neighbors to determine if it has to be killed/survived/born. Adds it to a "Kill" list or
        /// a "Activate" list that is later iterated to kill/activate cells
        /// </summary>
        /// <param name="cellArray"></param>
        /// <param name="c"></param>
        /// <param name="r"></param>
        private void CheckNeighbors(Cell[,] cellArray, int c, int r)
        {
            int activeNeighbors = 0;
            int[] temp = new int[12];
            //neighbor 1
            temp[0] = Mod((c - 1), row);
            if (cellArray[r, Mod((c - 1), row)].IsAlive)
                activeNeighbors++;
            //n2
            temp[1] = Mod((r - 1), row);
            temp[2] = Mod((c - 1), row);
            if (cellArray[Mod((r - 1), col), Mod((c - 1), row)].IsAlive)
                activeNeighbors++;
            //n3
            temp[3] = Mod((r - 1), col);
            if (cellArray[Mod((r - 1), col), c].IsAlive)
                activeNeighbors++;
           //n4
            temp[4] = Mod((r - 1), col);
            temp[5] = Mod((c + 1), row);
            if (cellArray[Mod((r - 1), col), Mod((c + 1), row)].IsAlive)
                activeNeighbors++;
            //n5
            temp[6] = Mod((c + 1), row);
            if (cellArray[r, Mod((c + 1), row)].IsAlive)
                activeNeighbors++;
            //n6
            temp[7] = Mod((r + 1), col);
            temp[8] = Mod((c + 1), row);
            if (cellArray[Mod((r + 1), col), Mod((c + 1), row)].IsAlive)
                activeNeighbors++;
            //n7
            temp[9] = Mod((r + 1), col);
            if (cellArray[Mod((r + 1), col), c].IsAlive)
                activeNeighbors++;
            //n8
            temp[10] = Mod((r + 1), col);
            temp[11] = Mod((c - 1), row);
            if (cellArray[Mod((r + 1), col), Mod((c - 1), row)].IsAlive)
                activeNeighbors++;

            //this checks alive cell with neighbors
            //Survival
            if (cellArray[r, c].IsAlive && activeNeighbors >= SMIN && activeNeighbors <= SMAX)
                cellsToActivate.Add(cellArray[r, c]);
            //Birth
            else if (!cellArray[r, c].IsAlive && (activeNeighbors >= BMIN && activeNeighbors <= BMAX))
                cellsToActivate.Add(cellArray[r, c]);
            //Death
            else if (cellArray[r,c].IsAlive)
                cellsToKill.Add(cellArray[r, c]);
        }

        /// <summary>
        /// This function steps one single generation by calling the "Cell List" function and then clears the "Activate" and "Kill list"
        /// </summary>
        private void OneGeneration()
        {
            for (int i = 0; i < cellArray.GetLength(0); i++)
                for (int j = 0; j < cellArray.GetLength(1); j++)
                    CheckNeighbors(cellArray, j, i);
            CellList(cellsToActivate, cellsToKill);
            cellsToActivate.Clear();
            cellsToKill.Clear();
            generationLabel.Text = String.Format("Generation Count: {0}", ++generationCounter);;
        }
        /// <summary>
        /// This is a Modulo function because C#'s native "%" returns negatives. This doesn't. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Mod(int a, int n)
        {
            return ((a % n) + n) % n;
        }

        /// <summary>
        /// This function goes through the "kill" and "activate" lists and kills/activates accordingly.
        /// </summary>
        /// <param name="aliveCells"></param>
        /// <param name="deadCells"></param>
        private void CellList(List<Cell> aliveCells, List<Cell> deadCells )
        {
            Graphics g = CreateGraphics();
            foreach (Cell c in aliveCells)
                c.ToggleAlive(true, g, sbAlive);
            foreach (Cell c in deadCells)
                c.ToggleAlive(false, g, sbDead);
        }

        /// <summary>
        /// Timer event that handles the the generations from the Play button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generationTimer_Tick(object sender, EventArgs e)
        {
            //generationTimer.Interval = (int)(1000 / numEvoRate.Value);
            if (evolutionRate > 0)
                generationTimer.Interval = (int)(1000 / evolutionRate);
            //index used to handle how many iterations of OneGeneration has been counted.
            if (index < Generations)
            {
                index++;
                OneGeneration();
            }
        }

        /// <summary>
        /// Play button event that triggers the Timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index == Generations)   //if game has already started, continue with the last gen by setting index to counter
                index = 0;
            generationTimer.Start();
        }

        /// <summary>
        /// Button event that handles one generation of evolution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void singleStepEvolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OneGeneration();
            index = Generations;  //Set index to Generations to let Timer be unaffected.
        }

        /// <summary>
        /// Pause button to handle pausing the evolution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            generationTimer.Stop();
        }

        /// <summary>
        /// Clears everything off the grid by setting the Cell to be dead.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_Grid(object sender, EventArgs e)
        {
            for (int i = 0; i < cellArray.GetLength(0); i++)
                for (int j = 0; j < cellArray.GetLength(1); j++)
                    cellArray[i, j].IsAlive = false; 
            Invalidate();
        }

        /// <summary>
        /// When the evolution rate option menu is clicked, a new form pops up where the user can set the evolution rate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evolutionRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvolutionRate evoRate = new EvolutionRate();
            var result = evoRate.ShowDialog();

            if (result == DialogResult.OK)
            {
                evolutionRate = evoRate.EvoRate;
                this.label1.Text = evolutionRate.ToString();
            }
        }

        /// <summary>
        /// When the help option menu button is clicked, a message box pops up displaying the instructions
        /// on how to play the game and what each keyboard shortcut does
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Options' menu allows you to performs things like set the evolution parameters"
                            +"change the color of the background or the grid, clear the grid, or hide the grid lines."
                            +"\n'Generate Random State' fills the grid with a random state. 'Play' starts evolution to the desired number of generations that can be set in the evolution parameters."
                            +"\n'Pause' pauses the evolution process. 'Single Step Evolution' makes the grid evolve only once."
                            +"\n'Evolution Rate' constantly shows the evolution rate that can be set by pressing the up arrow of the keyboard."
                            +"\n'Generation Count' can also be increased by pressing the right arrow in the keyboard."
                            +"\nPressing the enter button will start the evolution process.Pressing the spacebar will stop the evolution process."); 
        }

        /// <summary>
        /// When user clicks on the grid dimensions option, a form pops up. In this form, the user sets the 
        /// new grid dimensions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridDimensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartupForm StartupDialog = new StartupForm();
            var result = StartupDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                col = StartupDialog.StartupColumns;
                row = StartupDialog.StartupRows;
                cellArray = new Cell[col, row];  
            }
            SetCell();
            this.generationCounter = 0;
            this.generationLabel.Text = "Generation Label: 0";
            this.generationTimer.Stop();
            Invalidate();
        }

        /// <summary>
        /// Keyboard events that interacts with the program's generations when key is pressed
        /// Right Arrow Key: single step evolution
        /// Enter Key: Start game
        /// Space Key: Pause game
        /// Up Arrow Key: Increase evolution rate
        /// Down Arrow Key: Decrease evolution rate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)        //single step evolution
                OneGeneration();
            if (e.KeyCode == Keys.Enter)        //start
            {
                if (index == Generations)   //if game has already started, continue with the last gen by setting index to counter
                    index = 0;
                generationTimer.Start();
            }
            if (e.KeyCode == Keys.Space)        //pause 
                generationTimer.Stop();
            if (e.KeyCode == Keys.Up)           //increase evolution rate
            {      
                if (evolutionRate <= 100)
                {
                    evolutionRate++;
                    label1.Text = evolutionRate.ToString();
                }
                    
            }
            if (e.KeyCode == Keys.Down)         //decrease evolution rate
            {
                if (evolutionRate > 1)
                {
                    evolutionRate--;
                    label1.Text = evolutionRate.ToString();
                }
                    
            }
        }
 

        /// <summary>
        /// Button event that generates random cells dead or alive on the grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateRandomStateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grid = grid.RandomGrid(grid, sbAlive, sbDead);
            Invalidate();
        }

        /// <summary>
        /// If user clicks on the toggle grid option button, toggle the grid on and off.
        /// If off, set the grid line color to the background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggleGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleGridToolStripMenuItem.Checked)
            {
                toggleGridToolStripMenuItem.Text = "Grid Toggle: OFF";
                toggleGridToolStripMenuItem.Checked = false;
                BackColor = sbDead.Color;
                Invalidate();
            }
            else if (!toggleGridToolStripMenuItem.Checked)
            {
                toggleGridToolStripMenuItem.Text = "Grid Toggle: ON";
                toggleGridToolStripMenuItem.Checked = true;
                Invalidate();
            }
        }
    }
}